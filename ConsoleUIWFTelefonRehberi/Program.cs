using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleUIWFTelefonRehberi
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool LK = LicenceCheck();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            if (LK)
            {
                Application.Run(new Form1());
            }
            else
            {
                Application.Run(new LicenceWindow());
            }
        }
        static bool LicenceCheck()
        {
            //Registry ana root içerisinde alt key arar.
            RegistryKey RK = Registry.CurrentUser.OpenSubKey("TelefonRehberi");
            if (RK!=null)
            {

                string HDDSeriesNumber = string.Empty;
                string MacAddress = string.Empty;
                string Root = "C";
                ManagementObject Disk = new ManagementObject("Win32_LogicalDisk.DeviceID=\"" + Root + ":\"");
                Disk.Get();
                HDDSeriesNumber = Disk["VolumeSerialNumber"].ToString();

                ManagementClass MACADD = new ManagementClass("Win32_NetworkAdapterConfiguration");
                ManagementObjectCollection NAL = MACADD.GetInstances();
                foreach (ManagementObject item in NAL)
                {
                    if ((bool)item["IPEnabled"])
                    {
                        MacAddress = item["MacAddress"].ToString();
                    }

                }
                string HDDSNSTR = RK.GetValue("HardDiskSerialNumber").ToString();
                string MACADDSTR = RK.GetValue("MACAddress").ToString();

                if (HDDSNSTR == HDDSeriesNumber && MACADDSTR ==MacAddress)
                {
                    return true;
                }
                else
                {
                    return false;
                }
                
            }
            else
            {
                return false;
            }
            
        }
    }
}
