namespace BankSystemPresentationLayer
{
    partial class frmAddEditClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEditClient));
            this.lblMode = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnSelectPerson = new System.Windows.Forms.Button();
            this.btnEditPersonInfo = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chkChangePIN = new System.Windows.Forms.CheckBox();
            this.btnGenerateAccountNumber = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.txtOldPIN = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cbAccountType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txtConfirmPIN = new System.Windows.Forms.TextBox();
            this.txtPIN = new System.Windows.Forms.TextBox();
            this.txtAccountBalance = new System.Windows.Forms.TextBox();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.ctrlClientCard1 = new BankSystemPresentationLayer.Controls.ctrlClientCard();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Font = new System.Drawing.Font("Tahoma", 36F);
            this.lblMode.ForeColor = System.Drawing.Color.Red;
            this.lblMode.Location = new System.Drawing.Point(260, 9);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(350, 58);
            this.lblMode.TabIndex = 2;
            this.lblMode.Text = "Add New Client";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.ItemSize = new System.Drawing.Size(80, 20);
            this.tabControl1.Location = new System.Drawing.Point(11, 62);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(827, 577);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.ctrlClientCard1);
            this.tabPage1.Controls.Add(this.btnNext);
            this.tabPage1.Controls.Add(this.btnSelectPerson);
            this.tabPage1.Controls.Add(this.btnEditPersonInfo);
            this.tabPage1.Font = new System.Drawing.Font("Tahoma", 13F);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(819, 549);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Personal Info";
            // 
            // btnNext
            // 
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNext.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnNext.Image = global::BankSystemPresentationLayer.Properties.Resources.next;
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNext.Location = new System.Drawing.Point(720, 509);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(81, 34);
            this.btnNext.TabIndex = 48;
            this.btnNext.Text = "Next";
            this.btnNext.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnSelectPerson
            // 
            this.btnSelectPerson.Location = new System.Drawing.Point(662, 6);
            this.btnSelectPerson.Name = "btnSelectPerson";
            this.btnSelectPerson.Size = new System.Drawing.Size(151, 39);
            this.btnSelectPerson.TabIndex = 2;
            this.btnSelectPerson.Text = "Select A Person";
            this.btnSelectPerson.UseVisualStyleBackColor = true;
            this.btnSelectPerson.Click += new System.EventHandler(this.btnSelectPerson_Click);
            // 
            // btnEditPersonInfo
            // 
            this.btnEditPersonInfo.Location = new System.Drawing.Point(450, 6);
            this.btnEditPersonInfo.Name = "btnEditPersonInfo";
            this.btnEditPersonInfo.Size = new System.Drawing.Size(206, 39);
            this.btnEditPersonInfo.TabIndex = 1;
            this.btnEditPersonInfo.Text = "Edit Person Information";
            this.btnEditPersonInfo.UseVisualStyleBackColor = true;
            this.btnEditPersonInfo.Visible = false;
            this.btnEditPersonInfo.Click += new System.EventHandler(this.btnEditPersonInfo_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.chkChangePIN);
            this.tabPage2.Controls.Add(this.btnGenerateAccountNumber);
            this.tabPage2.Controls.Add(this.pictureBox5);
            this.tabPage2.Controls.Add(this.txtOldPIN);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Controls.Add(this.cbAccountType);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.pictureBox4);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.pictureBox3);
            this.tabPage2.Controls.Add(this.txtConfirmPIN);
            this.tabPage2.Controls.Add(this.txtPIN);
            this.tabPage2.Controls.Add(this.txtAccountBalance);
            this.tabPage2.Controls.Add(this.lblAccountNumber);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(819, 549);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Bank Account Info";
            // 
            // chkChangePIN
            // 
            this.chkChangePIN.AutoSize = true;
            this.chkChangePIN.Font = new System.Drawing.Font("Tahoma", 13F);
            this.chkChangePIN.Location = new System.Drawing.Point(363, 148);
            this.chkChangePIN.Name = "chkChangePIN";
            this.chkChangePIN.Size = new System.Drawing.Size(123, 26);
            this.chkChangePIN.TabIndex = 43;
            this.chkChangePIN.Text = "Change PIN";
            this.chkChangePIN.UseVisualStyleBackColor = true;
            this.chkChangePIN.CheckedChanged += new System.EventHandler(this.chkChangePIN_CheckedChanged);
            // 
            // btnGenerateAccountNumber
            // 
            this.btnGenerateAccountNumber.Font = new System.Drawing.Font("Tahoma", 13F);
            this.btnGenerateAccountNumber.Location = new System.Drawing.Point(590, 6);
            this.btnGenerateAccountNumber.Name = "btnGenerateAccountNumber";
            this.btnGenerateAccountNumber.Size = new System.Drawing.Size(226, 36);
            this.btnGenerateAccountNumber.TabIndex = 36;
            this.btnGenerateAccountNumber.Text = "Generate Account Number";
            this.btnGenerateAccountNumber.UseVisualStyleBackColor = true;
            this.btnGenerateAccountNumber.Click += new System.EventHandler(this.btnGenerateAccountNumber_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::BankSystemPresentationLayer.Properties.Resources.password;
            this.pictureBox5.Location = new System.Drawing.Point(162, 152);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(33, 22);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox5.TabIndex = 42;
            this.pictureBox5.TabStop = false;
            // 
            // txtOldPIN
            // 
            this.txtOldPIN.Location = new System.Drawing.Point(201, 152);
            this.txtOldPIN.MaxLength = 4;
            this.txtOldPIN.Name = "txtOldPIN";
            this.txtOldPIN.PasswordChar = '*';
            this.txtOldPIN.Size = new System.Drawing.Size(156, 20);
            this.txtOldPIN.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label6.Location = new System.Drawing.Point(78, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 22);
            this.label6.TabIndex = 40;
            this.label6.Text = "Old PIN:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BankSystemPresentationLayer.Properties.Resources.account;
            this.pictureBox2.Location = new System.Drawing.Point(164, 112);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 39;
            this.pictureBox2.TabStop = false;
            // 
            // cbAccountType
            // 
            this.cbAccountType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAccountType.FormattingEnabled = true;
            this.cbAccountType.Items.AddRange(new object[] {
            "Saving Account",
            "VIP Account"});
            this.cbAccountType.Location = new System.Drawing.Point(203, 112);
            this.cbAccountType.Name = "cbAccountType";
            this.cbAccountType.Size = new System.Drawing.Size(156, 21);
            this.cbAccountType.TabIndex = 38;
            this.cbAccountType.SelectedIndexChanged += new System.EventHandler(this.cbAccountType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label1.Location = new System.Drawing.Point(34, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 22);
            this.label1.TabIndex = 37;
            this.label1.Text = "Account Type:";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::BankSystemPresentationLayer.Properties.Resources.password;
            this.pictureBox4.Location = new System.Drawing.Point(162, 231);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(33, 22);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 35;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BankSystemPresentationLayer.Properties.Resources.password;
            this.pictureBox1.Location = new System.Drawing.Point(162, 191);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::BankSystemPresentationLayer.Properties.Resources.coin_dollar2;
            this.pictureBox3.Location = new System.Drawing.Point(164, 71);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 22);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 33;
            this.pictureBox3.TabStop = false;
            // 
            // txtConfirmPIN
            // 
            this.txtConfirmPIN.Location = new System.Drawing.Point(201, 231);
            this.txtConfirmPIN.MaxLength = 4;
            this.txtConfirmPIN.Name = "txtConfirmPIN";
            this.txtConfirmPIN.PasswordChar = '*';
            this.txtConfirmPIN.Size = new System.Drawing.Size(156, 20);
            this.txtConfirmPIN.TabIndex = 31;
            // 
            // txtPIN
            // 
            this.txtPIN.Location = new System.Drawing.Point(201, 191);
            this.txtPIN.MaxLength = 4;
            this.txtPIN.Name = "txtPIN";
            this.txtPIN.PasswordChar = '*';
            this.txtPIN.Size = new System.Drawing.Size(156, 20);
            this.txtPIN.TabIndex = 30;
            // 
            // txtAccountBalance
            // 
            this.txtAccountBalance.Location = new System.Drawing.Point(203, 71);
            this.txtAccountBalance.Name = "txtAccountBalance";
            this.txtAccountBalance.Size = new System.Drawing.Size(156, 20);
            this.txtAccountBalance.TabIndex = 29;
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.Font = new System.Drawing.Font("Tahoma", 13F);
            this.lblAccountNumber.Location = new System.Drawing.Point(166, 27);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(37, 22);
            this.lblAccountNumber.TabIndex = 28;
            this.lblAccountNumber.Text = "???";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label4.Location = new System.Drawing.Point(43, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 22);
            this.label4.TabIndex = 27;
            this.label4.Text = "Confirm PIN:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label2.Location = new System.Drawing.Point(71, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 22);
            this.label2.TabIndex = 26;
            this.label2.Text = "New PIN:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label3.Location = new System.Drawing.Point(13, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 22);
            this.label3.TabIndex = 25;
            this.label3.Text = "Account Balance:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label5.Location = new System.Drawing.Point(11, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 22);
            this.label5.TabIndex = 24;
            this.label5.Text = "Account Number:";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(718, 635);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 34);
            this.btnSave.TabIndex = 46;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ctrlClientCard1
            // 
            this.ctrlClientCard1.BackColor = System.Drawing.Color.White;
            this.ctrlClientCard1.Font = new System.Drawing.Font("Tahoma", 8F);
            this.ctrlClientCard1.Location = new System.Drawing.Point(13, 45);
            this.ctrlClientCard1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlClientCard1.Name = "ctrlClientCard1";
            this.ctrlClientCard1.Size = new System.Drawing.Size(806, 465);
            this.ctrlClientCard1.TabIndex = 49;
            // 
            // frmAddEditClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 673);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblMode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAddEditClient";
            this.Text = "Add New Client";
            this.Load += new System.EventHandler(this.frmAddEditClient_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnSelectPerson;
        private System.Windows.Forms.Button btnEditPersonInfo;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txtConfirmPIN;
        private System.Windows.Forms.TextBox txtPIN;
        private System.Windows.Forms.TextBox txtAccountBalance;
        private System.Windows.Forms.Label lblAccountNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGenerateAccountNumber;
        private System.Windows.Forms.ComboBox cbAccountType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.TextBox txtOldPIN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox chkChangePIN;
        private Controls.ctrlClientCard ctrlClientCard1;
    }
}