using Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Businnes
{
    public class BusinessLogicLayer
    {
        DataBase.DBLogicLayer DLL;

        public BusinessLogicLayer()
        {
            DLL = new DataBase.DBLogicLayer();
        }


        public int UserCheck(string UserName,string Password)
        {
            int result = 0;

            if (!string.IsNullOrEmpty(UserName)&& !string.IsNullOrEmpty(Password))
            {
                User _user = new User();
                _user.UserName = UserName;
                _user.Password = Password;
                result = DLL.UserCheck(_user);
            }
            else
            {
                result = -100;
            }
            return result;
        }


        public int NewRecord(Guid ID,string Name,string Surname,string Phone1, string Phone2, string Phone3,
            string Adress,string EmailAdress,string Website,string Explain1)
        {
            int result = 0;
            if(ID != Guid.Empty && !string.IsNullOrEmpty(Name)&& !string.IsNullOrEmpty(Surname)&&!string.IsNullOrEmpty(Phone1))
            {
                Record _record = new Record();
                _record.ID = ID;
                _record.Name = Name;
                _record.Surname = Surname;
                _record.Phone1 = Phone1;
                _record.Phone2 = Phone2;
                _record.Phone3 = Phone3;
                _record.Adress = Adress;
                _record.EmailAdress = EmailAdress;
                _record.WebSite = Website;
                _record.Explain = Explain1;

                result = DLL.NewRecord(_record);
            }
            else
            {
                result = -100;
            }

            return result;
        }

        public int UpdateRecord(Guid ID, string Name, string Surname, string Phone1, string Phone2, string Phone3,
            string Adress, string EmailAdress, string Website, string Explain1)
        {
            int result = 0;
            if (ID!=Guid.Empty && !string.IsNullOrEmpty(Name)&&!string.IsNullOrEmpty(Surname)&&!string.IsNullOrEmpty(Phone1)  )
            {
                Record _record = new Record();
                _record.ID = ID;
                _record.Name = Name;
                _record.Surname = Surname;
                _record.Phone1 = Phone1;
                _record.Phone2 = Phone2;
                _record.Phone3 = Phone3;
                _record.Adress = Adress;
                _record.EmailAdress = EmailAdress;
                _record.WebSite = Website;
                _record.Explain = Explain1;
                result=DLL.UpdateRecord(_record);
            }
            else
            {
                result = -100;
            }
            return result;
        }

        public int DeleteRecord(Guid ID)
        {
            return DLL.DeleteRecord(ID);
        }

        public List<Record> GetRecordMethod()
        {
            return DLL.GetRecords();
        }



        public int GetXMLData()
        {
            int result = 0;
            try
            {
                List<Record> myrecords = DLL.GetRecords();
                XDocument Doc = new XDocument(new XDeclaration("1.0.0.1", "UTF-8", "yes"), new XElement("ContactRecords", myrecords.Select
                    (I => new XElement("Record", new XElement("ID", I.ID), new XElement("Name", I.Name), new XElement("Surname", I.Surname), new XElement("Phone1", I.Phone1),
                    new XElement("Phone2", I.Phone2), new XElement("Phone3", I.Phone3), new XElement("Email", I.EmailAdress), new XElement("Web", I.WebSite),
                    new XElement("Adress", I.Adress), new XElement("Explain", I.Explain)))));
                Doc.Save(@"C:\Users\hasan\Desktop\YazılımDersi\Projeler\Telefon Rehberi\TelefonRehberiDB\GetDataXML.xml");
                result = 1;
            }
            catch (Exception)
            {

                result = 0;
            }
            return result;
                
        }

        public int GetCSVData()
        {
            int result = 0;
            try
            {
                List<Record> _records = DLL.GetRecords();
                //CsvHelper by Josh Close nuget install 2.11.0 version
                StreamWriter SW = new StreamWriter(@"C:\Users\hasan\Desktop\YazılımDersi\Projeler\Telefon Rehberi\TelefonRehberiDB\GetDataCSV.csv");
                CsvHelper.CsvWriter Write = new CsvHelper.CsvWriter(SW);
                Write.WriteHeader(typeof(Record));
                foreach (var item in _records)
                {
                    Write.WriteRecord(item);
                }
                SW.Close();
                result = 1;
            }
            catch (Exception)
            {
                result = 0;
            }
            return result;


        }

        public int GetJSONData()
        {
            int result = 0;
            try
            {
               List<Record> _records = DLL.GetRecords();
               string JsonText= Newtonsoft.Json.JsonConvert.SerializeObject(_records);
               File.WriteAllText(@"C:\Users\hasan\Desktop\YazılımDersi\Projeler\Telefon Rehberi\TelefonRehberiDB\GetDataJSON.json", JsonText);
                result = 1; 
            }
            catch (Exception)
            {

                result =0;
            }
            return result;
        }

 







    }
}
