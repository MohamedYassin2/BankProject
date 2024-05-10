namespace BankSystemPresentationLayer
{
    partial class frmAddEditUser
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEditUser));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnSelectPerson = new System.Windows.Forms.Button();
            this.btnEditPersonInfo = new System.Windows.Forms.Button();
            this.ctrlPerson1 = new BankSystemPresentationLayer.ctrlPerson();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkAll = new System.Windows.Forms.CheckBox();
            this.chkWithdrawl = new System.Windows.Forms.CheckBox();
            this.chkDeposits = new System.Windows.Forms.CheckBox();
            this.chkTransfer = new System.Windows.Forms.CheckBox();
            this.chkUsers = new System.Windows.Forms.CheckBox();
            this.chkClients = new System.Windows.Forms.CheckBox();
            this.chkPeople = new System.Windows.Forms.CheckBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.chkIsActive = new System.Windows.Forms.CheckBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblUserID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMode = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.ItemSize = new System.Drawing.Size(80, 20);
            this.tabControl1.Location = new System.Drawing.Point(12, 79);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(827, 417);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.btnNext);
            this.tabPage1.Controls.Add(this.btnSelectPerson);
            this.tabPage1.Controls.Add(this.btnEditPersonInfo);
            this.tabPage1.Controls.Add(this.ctrlPerson1);
            this.tabPage1.Font = new System.Drawing.Font("Tahoma", 13F);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(819, 389);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Personal Info";
            // 
            // btnNext
            // 
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNext.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnNext.Image = global::BankSystemPresentationLayer.Properties.Resources.next;
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNext.Location = new System.Drawing.Point(732, 346);
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
            this.btnEditPersonInfo.Click += new System.EventHandler(this.btnEditPersonInfo_Click);
            // 
            // ctrlPerson1
            // 
            this.ctrlPerson1.Font = new System.Drawing.Font("Tahoma", 8F);
            this.ctrlPerson1.Location = new System.Drawing.Point(35, 48);
            this.ctrlPerson1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlPerson1.Name = "ctrlPerson1";
            this.ctrlPerson1.Size = new System.Drawing.Size(762, 290);
            this.ctrlPerson1.TabIndex = 0;
            this.ctrlPerson1.Load += new System.EventHandler(this.ctrlPerson1_Load);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.pictureBox4);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.pictureBox3);
            this.tabPage2.Controls.Add(this.chkIsActive);
            this.tabPage2.Controls.Add(this.txtConfirmPassword);
            this.tabPage2.Controls.Add(this.txtPassword);
            this.tabPage2.Controls.Add(this.txtUserName);
            this.tabPage2.Controls.Add(this.lblUserID);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(819, 389);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Log in Info";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkAll);
            this.groupBox1.Controls.Add(this.chkWithdrawl);
            this.groupBox1.Controls.Add(this.chkDeposits);
            this.groupBox1.Controls.Add(this.chkTransfer);
            this.groupBox1.Controls.Add(this.chkUsers);
            this.groupBox1.Controls.Add(this.chkClients);
            this.groupBox1.Controls.Add(this.chkPeople);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 13F);
            this.groupBox1.Location = new System.Drawing.Point(453, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 211);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Permissions";
            // 
            // chkAll
            // 
            this.chkAll.AutoSize = true;
            this.chkAll.Location = new System.Drawing.Point(6, 174);
            this.chkAll.Name = "chkAll";
            this.chkAll.Size = new System.Drawing.Size(48, 26);
            this.chkAll.TabIndex = 5;
            this.chkAll.Text = "All";
            this.chkAll.UseVisualStyleBackColor = true;
            this.chkAll.CheckedChanged += new System.EventHandler(this.chkAll_CheckedChanged);
            // 
            // chkWithdrawl
            // 
            this.chkWithdrawl.AutoSize = true;
            this.chkWithdrawl.Location = new System.Drawing.Point(6, 129);
            this.chkWithdrawl.Name = "chkWithdrawl";
            this.chkWithdrawl.Size = new System.Drawing.Size(175, 26);
            this.chkWithdrawl.TabIndex = 4;
            this.chkWithdrawl.Text = "WithDrawls Screen";
            this.chkWithdrawl.UseVisualStyleBackColor = true;
            this.chkWithdrawl.CheckedChanged += new System.EventHandler(this.chkWithdrawl_CheckedChanged);
            // 
            // chkDeposits
            // 
            this.chkDeposits.AutoSize = true;
            this.chkDeposits.Location = new System.Drawing.Point(187, 80);
            this.chkDeposits.Name = "chkDeposits";
            this.chkDeposits.Size = new System.Drawing.Size(154, 26);
            this.chkDeposits.TabIndex = 3;
            this.chkDeposits.Text = "Deposits Screen";
            this.chkDeposits.UseVisualStyleBackColor = true;
            // 
            // chkTransfer
            // 
            this.chkTransfer.AutoSize = true;
            this.chkTransfer.Location = new System.Drawing.Point(187, 129);
            this.chkTransfer.Name = "chkTransfer";
            this.chkTransfer.Size = new System.Drawing.Size(152, 26);
            this.chkTransfer.TabIndex = 3;
            this.chkTransfer.Text = "Transfer Screen";
            this.chkTransfer.UseVisualStyleBackColor = true;
            this.chkTransfer.CheckedChanged += new System.EventHandler(this.chkTransfer_CheckedChanged);
            // 
            // chkUsers
            // 
            this.chkUsers.AutoSize = true;
            this.chkUsers.Location = new System.Drawing.Point(6, 80);
            this.chkUsers.Name = "chkUsers";
            this.chkUsers.Size = new System.Drawing.Size(130, 26);
            this.chkUsers.TabIndex = 2;
            this.chkUsers.Text = "Users Screen";
            this.chkUsers.UseVisualStyleBackColor = true;
            this.chkUsers.CheckedChanged += new System.EventHandler(this.chkUsers_CheckedChanged);
            // 
            // chkClients
            // 
            this.chkClients.AutoSize = true;
            this.chkClients.Location = new System.Drawing.Point(187, 29);
            this.chkClients.Name = "chkClients";
            this.chkClients.Size = new System.Drawing.Size(139, 26);
            this.chkClients.TabIndex = 1;
            this.chkClients.Text = "Clients Screen";
            this.chkClients.UseVisualStyleBackColor = true;
            this.chkClients.CheckedChanged += new System.EventHandler(this.chkClients_CheckedChanged);
            // 
            // chkPeople
            // 
            this.chkPeople.AutoSize = true;
            this.chkPeople.Location = new System.Drawing.Point(6, 29);
            this.chkPeople.Name = "chkPeople";
            this.chkPeople.Size = new System.Drawing.Size(139, 26);
            this.chkPeople.TabIndex = 0;
            this.chkPeople.Text = "People Screen";
            this.chkPeople.UseVisualStyleBackColor = true;
            this.chkPeople.CheckedChanged += new System.EventHandler(this.chkPeople_CheckedChanged);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::BankSystemPresentationLayer.Properties.Resources.password;
            this.pictureBox4.Location = new System.Drawing.Point(162, 168);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(33, 22);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 35;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BankSystemPresentationLayer.Properties.Resources.password;
            this.pictureBox1.Location = new System.Drawing.Point(162, 127);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::BankSystemPresentationLayer.Properties.Resources.user__1_;
            this.pictureBox3.Location = new System.Drawing.Point(170, 83);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 22);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 33;
            this.pictureBox3.TabStop = false;
            // 
            // chkIsActive
            // 
            this.chkIsActive.AutoSize = true;
            this.chkIsActive.Checked = true;
            this.chkIsActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIsActive.Font = new System.Drawing.Font("Tahoma", 12F);
            this.chkIsActive.Location = new System.Drawing.Point(201, 215);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(84, 23);
            this.chkIsActive.TabIndex = 32;
            this.chkIsActive.Text = "IsActive";
            this.chkIsActive.UseVisualStyleBackColor = true;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(201, 168);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(156, 20);
            this.txtConfirmPassword.TabIndex = 31;
            this.txtConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtConfirmPassword_Validating_1);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(201, 127);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(156, 20);
            this.txtPassword.TabIndex = 30;
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassword_Validating_1);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(201, 83);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(156, 20);
            this.txtUserName.TabIndex = 29;
            this.txtUserName.Validating += new System.ComponentModel.CancelEventHandler(this.txtUserName_Validating_1);
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Tahoma", 13F);
            this.lblUserID.Location = new System.Drawing.Point(197, 42);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(37, 22);
            this.lblUserID.TabIndex = 28;
            this.lblUserID.Text = "???";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label4.Location = new System.Drawing.Point(6, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 22);
            this.label4.TabIndex = 27;
            this.label4.Text = "Confirm Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label2.Location = new System.Drawing.Point(66, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 22);
            this.label2.TabIndex = 26;
            this.label2.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label3.Location = new System.Drawing.Point(68, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 22);
            this.label3.TabIndex = 25;
            this.label3.Text = "UserName:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label5.Location = new System.Drawing.Point(99, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 22);
            this.label5.TabIndex = 24;
            this.label5.Text = "UserID:";
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Font = new System.Drawing.Font("Tahoma", 36F);
            this.lblMode.ForeColor = System.Drawing.Color.Red;
            this.lblMode.Location = new System.Drawing.Point(256, 18);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(325, 58);
            this.lblMode.TabIndex = 1;
            this.lblMode.Text = "Add New User";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(719, 502);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 34);
            this.btnSave.TabIndex = 45;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAddEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(849, 540);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblMode);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAddEditUser";
            this.Text = "Add New User";
            this.Load += new System.EventHandler(this.frmAddEditUser_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnSelectPerson;
        private System.Windows.Forms.Button btnEditPersonInfo;
        private ctrlPerson ctrlPerson1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.CheckBox chkIsActive;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkClients;
        private System.Windows.Forms.CheckBox chkPeople;
        private System.Windows.Forms.CheckBox chkAll;
        private System.Windows.Forms.CheckBox chkWithdrawl;
        private System.Windows.Forms.CheckBox chkDeposits;
        private System.Windows.Forms.CheckBox chkTransfer;
        private System.Windows.Forms.CheckBox chkUsers;
    }
}