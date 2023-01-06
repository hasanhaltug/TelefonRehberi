using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleUIWFTelefonRehberi
{
    public partial class LicenceWindow : Form
    {
        public LicenceWindow()
        {
            InitializeComponent();
        }

        private void btnUpLicence_Click(object sender, EventArgs e)
        {
            if (txtLicence.Text == "644e1dd7-2a7f-18fb-b8ed-ed78c3f92c2b")
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
                if (!string.IsNullOrEmpty(HDDSeriesNumber) && !string.IsNullOrEmpty(MacAddress))
                {
                    RegistryKey Key = Registry.CurrentUser.CreateSubKey("TelefonRehberi", true);
                    Key.SetValue("HardDiskSerialNumber", HDDSeriesNumber);
                    Key.SetValue("MACAddress", MacAddress);

                    MessageBox.Show("Licence is complate.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("The licence number you entered is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
