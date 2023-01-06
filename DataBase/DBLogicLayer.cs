using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataBase
{
    public class DBLogicLayer
    {
        List<Record> MyRecord;
        public DBLogicLayer()
        {
            DBCheck();
            MyRecord = new List<Record>();
        }

        private void DBCheck()
        {
            bool check = Directory.Exists(@"C:\Users\hasan\Desktop\YazılımDersi\Projeler\Telefon Rehberi\TelefonRehberiDB\");
            if (!check)
            {
                Directory.CreateDirectory(@"C:\Users\hasan\Desktop\YazılımDersi\Projeler\Telefon Rehberi\TelefonRehberiDB\");
                User Demo = new User();
                Demo.ID = Guid.NewGuid();
                Demo.UserName = "Admin";
                Demo.Password = "Admin";

                string JsonUserText = Newtonsoft.Json.JsonConvert.SerializeObject(Demo);
                File.WriteAllText(@"C:\Users\hasan\Desktop\YazılımDersi\Projeler\Telefon Rehberi\TelefonRehberiDB\kullanici.json", JsonUserText);
            }

        }

        public int NewRecord(Record R)
        {
            int result = 0;
            try
            {
                GetRecords();
                MyRecord.Add(R);
                JsonDBUpdate();
                result = 1;

            }
            catch (Exception ex)
            {

                result = 0;
            }
            return result;
        }

        public int UpdateRecord(Record R)
        {
            int result = 0;
            try
            {
                GetRecords();
                int Index = MyRecord.FindIndex(i => i.ID == R.ID);
                if (Index>-1)
                {
                    MyRecord[Index].Name = R.Name;
                    MyRecord[Index].Surname = R.Surname;
                    MyRecord[Index].Phone1 = R.Phone1;
                    MyRecord[Index].Phone2 = R.Phone2;
                    MyRecord[Index].Phone3 = R.Phone3;
                    MyRecord[Index].EmailAdress = R.EmailAdress;
                    MyRecord[Index].WebSite = R.WebSite;
                    MyRecord[Index].Adress = R.Adress;
                    MyRecord[Index].Explain = R.Explain;
                }
                JsonDBUpdate();
                result = 1;
            }
            catch (Exception)
            {
                
            }
            return result;



        }

        public int DeleteRecord(Guid Id)
        {
            int result = 0;
            try
            {
                GetRecords();
                Record _deleteRecord = MyRecord.Find(i => i.ID == Id);
                if (_deleteRecord!=null)
                {
                    MyRecord.Remove(_deleteRecord);
                }
                JsonDBUpdate();
                result = 1;
            }
            catch (Exception)
            {

                
            }
            return result;

        }

        public List<Record> GetRecords()
        {
            if (File.Exists(@"C:\Users\hasan\Desktop\YazılımDersi\Projeler\Telefon Rehberi\TelefonRehberiDB\Directory.json"))
            {
                string JsonDBText = File.ReadAllText(@"C:\Users\hasan\Desktop\YazılımDersi\Projeler\Telefon Rehberi\TelefonRehberiDB\Directory.json");
                MyRecord = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Record>>(JsonDBText);//*!!!

            }
            return MyRecord;

        }

        public int UserCheck(User user)
        {
            int UserResult = 0;
            if (File.Exists(@"C:\Users\hasan\Desktop\YazılımDersi\Projeler\Telefon Rehberi\TelefonRehberiDB\kullanici.json"))
            {
                string JsonUserText = File.ReadAllText(@"C:\Users\hasan\Desktop\YazılımDersi\Projeler\Telefon Rehberi\TelefonRehberiDB\kullanici.json");
                List<User> users = Newtonsoft.Json.JsonConvert.DeserializeObject<List<User>>(JsonUserText);
                UserResult = users.FindAll(i => i.UserName == user.UserName && i.Password == user.Password).ToList().Count();
            }
            return UserResult;
        }



        #region Helper Methot   
        private void JsonDBUpdate ()
        {
            if (MyRecord != null && MyRecord.Count>0)
            {
                string JsonDB = Newtonsoft.Json.JsonConvert.SerializeObject(MyRecord);
                File.WriteAllText(@"C:\Users\hasan\Desktop\YazılımDersi\Projeler\Telefon Rehberi\TelefonRehberiDB\Directory.json", JsonDB);
            }
        }
        





        #endregion







    }
}
