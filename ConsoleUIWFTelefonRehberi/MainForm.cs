using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleUIWFTelefonRehberi
{
    public partial class MainForm : Form
    {
        Businnes.BusinessLogicLayer BLL;
        public MainForm()
        {
            InitializeComponent();
            BLL = new Businnes.BusinessLogicLayer();
        }

        private void _fill()
        {
            List<Record> Myrecords = BLL.GetRecordMethod();
            if (Myrecords != null && Myrecords.Count > 0)
            {
                lstList.DataSource = Myrecords;
            }
        }

        private void deleteText()
        {
            txtName.Text = string.Empty;
            txtSurname.Text = string.Empty;
            txtWeb.Text = string.Empty;
            txtPhone3.Text = string.Empty;
            txtPhone2.Text = string.Empty;
            txtPhone1.Text = string.Empty;
            txtAdress.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtExplain.Text = string.Empty;           
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _fill();
        }

        private void btnNewRecord_Click(object sender, EventArgs e)
        {
            int result = BLL.NewRecord(Guid.NewGuid(), txtName.Text, txtSurname.Text, txtPhone1.Text, txtPhone2.Text, txtPhone3.Text, txtAdress.Text, txtEmail.Text, txtWeb.Text, txtExplain.Text);
            if (result>0)
            {
                MessageBox.Show("Your registration has been successfully added.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _fill();
                deleteText();
            }
            else if (result == -100)
            {
                MessageBox.Show("Missing parameter error. Please fill in the Name, Surname and Phone I field", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("An error occurred while adding a record.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lstList_DoubleClick(object sender, EventArgs e)
        {
            ListBox L = (ListBox)sender;
            Record R = (Record)L.SelectedItem;
            txtName.Text = R.Name;
            txtSurname.Text = R.Surname;
            txtPhone1.Text = R.Phone1;
            txtPhone2.Text = R.Phone2;
            txtPhone3.Text = R.Phone3;
            txtAdress.Text = R.Adress;
            txtEmail.Text = R.EmailAdress;
            txtWeb.Text = R.WebSite;
            txtExplain.Text = R.Explain;
            grbRecord.Text = "Update Contact Record";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(lstList.SelectedItem!=null)
            {
                Record R = (Record)lstList.SelectedItem;
                int result = BLL.UpdateRecord(R.ID, txtName.Text, txtSurname.Text, txtPhone1.Text, txtPhone2.Text, txtPhone3.Text, txtAdress.Text, txtEmail.Text, txtWeb.Text, txtExplain.Text);
                if (result>0)
                {
                    MessageBox.Show("Your registration has been successfully updated");
                    _fill();
                    deleteText();
                }
                else if(result==-100)
                {
                    MessageBox.Show("Missing parameter error.");
                }
                else
                {
                    MessageBox.Show("An error occurred while updating a record.");
                }
            
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Guid DeleteId  =((Record)lstList.SelectedItem).ID;
            int result = BLL.DeleteRecord(DeleteId);
            if (result>0)
            {
                MessageBox.Show("Your registration has been successfully deleted");
                _fill();
                deleteText();
            }
            else
            {
                MessageBox.Show("An error occurred while deleting a record.");
            }
        }

        private void btnGetXml_Click(object sender, EventArgs e)
        {
            int result = BLL.GetXMLData();
            if (result>0)
            {
                lblStatus.Text = "Status: XML Data complate successfully.";
                lblStatus.Font = new Font("Microsoft Sans Serif", 8);
            }
            else
            {
                lblStatus.Text = "Status: Error";
                lblStatus.Font = new Font("Microsoft Sans Serif", 8);
            }
        }

        private void btnCsv_Click(object sender, EventArgs e)
        {
            int result = BLL.GetCSVData();
            if (result>0)
            {
                lblStatus.Text = "Status: CSV Data complate successfully.";
                lblStatus.Font = new Font("Microsoft Sans Serif", 8);
            }
            else
            {
                lblStatus.Text = "Status: Error";
                lblStatus.Font = new Font("Microsoft Sans Serif", 8);
            }
        }

        private void btnJSON_Click(object sender, EventArgs e)
        {
            int result =BLL.GetJSONData();
            if (result>0)
            {
                lblStatus.Text = "Status: JSON Data complate successfully.";
                lblStatus.Font = new Font("Microsoft Sans Serif", 8);
            }
            else
            {
                lblStatus.Text = "Status: Error";
                lblStatus.Font = new Font("Microsoft Sans Serif", 8);
            }
        }
    }
}
