
namespace ConsoleUIWFTelefonRehberi
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstList = new System.Windows.Forms.ListBox();
            this.grbRecord = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNewRecord = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtPhone2 = new System.Windows.Forms.TextBox();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.txtWeb = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone1 = new System.Windows.Forms.TextBox();
            this.txtPhone3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtExplain = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.btnJSON = new System.Windows.Forms.Button();
            this.btnCsv = new System.Windows.Forms.Button();
            this.btnGetXml = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grbRecord.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstList);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 533);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contect List";
            // 
            // lstList
            // 
            this.lstList.FormattingEnabled = true;
            this.lstList.Location = new System.Drawing.Point(7, 20);
            this.lstList.Name = "lstList";
            this.lstList.Size = new System.Drawing.Size(187, 498);
            this.lstList.TabIndex = 0;
            this.lstList.DoubleClick += new System.EventHandler(this.lstList_DoubleClick);
            // 
            // grbRecord
            // 
            this.grbRecord.Controls.Add(this.btnDelete);
            this.grbRecord.Controls.Add(this.btnNewRecord);
            this.grbRecord.Controls.Add(this.tabControl1);
            this.grbRecord.Location = new System.Drawing.Point(228, 14);
            this.grbRecord.Name = "grbRecord";
            this.grbRecord.Size = new System.Drawing.Size(822, 364);
            this.grbRecord.TabIndex = 1;
            this.grbRecord.TabStop = false;
            this.grbRecord.Text = "New Contect Record";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(436, 330);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(360, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNewRecord
            // 
            this.btnNewRecord.Location = new System.Drawing.Point(11, 301);
            this.btnNewRecord.Name = "btnNewRecord";
            this.btnNewRecord.Size = new System.Drawing.Size(785, 23);
            this.btnNewRecord.TabIndex = 1;
            this.btnNewRecord.Text = "New Record";
            this.btnNewRecord.UseVisualStyleBackColor = true;
            this.btnNewRecord.Click += new System.EventHandler(this.btnNewRecord_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(7, 20);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(793, 275);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtPhone2);
            this.tabPage1.Controls.Add(this.txtAdress);
            this.tabPage1.Controls.Add(this.txtWeb);
            this.tabPage1.Controls.Add(this.txtEmail);
            this.tabPage1.Controls.Add(this.txtPhone1);
            this.tabPage1.Controls.Add(this.txtPhone3);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txtSurname);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtName);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(785, 249);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Personal Information";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtPhone2
            // 
            this.txtPhone2.Location = new System.Drawing.Point(112, 107);
            this.txtPhone2.Name = "txtPhone2";
            this.txtPhone2.Size = new System.Drawing.Size(293, 20);
            this.txtPhone2.TabIndex = 4;
            // 
            // txtAdress
            // 
            this.txtAdress.Location = new System.Drawing.Point(509, 29);
            this.txtAdress.Multiline = true;
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(249, 177);
            this.txtAdress.TabIndex = 8;
            // 
            // txtWeb
            // 
            this.txtWeb.Location = new System.Drawing.Point(112, 186);
            this.txtWeb.Name = "txtWeb";
            this.txtWeb.Size = new System.Drawing.Size(293, 20);
            this.txtWeb.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(112, 160);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(293, 20);
            this.txtEmail.TabIndex = 6;
            // 
            // txtPhone1
            // 
            this.txtPhone1.Location = new System.Drawing.Point(112, 81);
            this.txtPhone1.Name = "txtPhone1";
            this.txtPhone1.Size = new System.Drawing.Size(293, 20);
            this.txtPhone1.TabIndex = 3;
            // 
            // txtPhone3
            // 
            this.txtPhone3.Location = new System.Drawing.Point(112, 133);
            this.txtPhone3.Name = "txtPhone3";
            this.txtPhone3.Size = new System.Drawing.Size(293, 20);
            this.txtPhone3.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(440, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Adress:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(6, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Phone II:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(6, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Web Site:";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(112, 55);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(293, 20);
            this.txtSurname.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(6, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Email Adress:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(6, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Phone I:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(112, 29);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(293, 20);
            this.txtName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(6, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Phone III:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Surname:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtExplain);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(785, 249);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Explain";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtExplain
            // 
            this.txtExplain.Location = new System.Drawing.Point(6, 6);
            this.txtExplain.Multiline = true;
            this.txtExplain.Name = "txtExplain";
            this.txtExplain.Size = new System.Drawing.Size(773, 237);
            this.txtExplain.TabIndex = 0;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(239, 344);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(418, 23);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblStatus);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.btnJSON);
            this.groupBox3.Controls.Add(this.btnCsv);
            this.groupBox3.Controls.Add(this.btnGetXml);
            this.groupBox3.Location = new System.Drawing.Point(228, 395);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(822, 151);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Import Export Data";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStatus.Location = new System.Drawing.Point(482, 67);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(164, 25);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Status: Pending";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(376, 43);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(88, 79);
            this.button4.TabIndex = 0;
            this.button4.Text = "XML Import";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnJSON
            // 
            this.btnJSON.Location = new System.Drawing.Point(249, 43);
            this.btnJSON.Name = "btnJSON";
            this.btnJSON.Size = new System.Drawing.Size(88, 79);
            this.btnJSON.TabIndex = 0;
            this.btnJSON.Text = "JSON Export";
            this.btnJSON.UseVisualStyleBackColor = true;
            this.btnJSON.Click += new System.EventHandler(this.btnJSON_Click);
            // 
            // btnCsv
            // 
            this.btnCsv.Location = new System.Drawing.Point(123, 43);
            this.btnCsv.Name = "btnCsv";
            this.btnCsv.Size = new System.Drawing.Size(88, 79);
            this.btnCsv.TabIndex = 0;
            this.btnCsv.Text = "CSV Export";
            this.btnCsv.UseVisualStyleBackColor = true;
            this.btnCsv.Click += new System.EventHandler(this.btnCsv_Click);
            // 
            // btnGetXml
            // 
            this.btnGetXml.Location = new System.Drawing.Point(7, 43);
            this.btnGetXml.Name = "btnGetXml";
            this.btnGetXml.Size = new System.Drawing.Size(88, 79);
            this.btnGetXml.TabIndex = 0;
            this.btnGetXml.Text = "XML Export";
            this.btnGetXml.UseVisualStyleBackColor = true;
            this.btnGetXml.Click += new System.EventHandler(this.btnGetXml_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 558);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.grbRecord);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.grbRecord.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grbRecord;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone3;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnNewRecord;
        private System.Windows.Forms.TextBox txtPhone2;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.TextBox txtWeb;
        private System.Windows.Forms.TextBox txtPhone1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtExplain;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ListBox lstList;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnJSON;
        private System.Windows.Forms.Button btnCsv;
        private System.Windows.Forms.Button btnGetXml;
        private System.Windows.Forms.Button btnDelete;
    }
}