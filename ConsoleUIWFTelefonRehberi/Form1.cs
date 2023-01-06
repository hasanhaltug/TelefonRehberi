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
    public partial class Form1 : Form
    {
        Businnes.BusinessLogicLayer BLL;
        public Form1()
        {
            InitializeComponent();
            BLL = new Businnes.BusinessLogicLayer();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int result = BLL.UserCheck(txtUserName.Text, txtPassword.Text);
            if (result>0)
            {
                MainForm form = new MainForm();
                form.Show();

            }
            else if (result == -100)
            {
                MessageBox.Show("Fill in the form fields completely.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Wrong user", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
