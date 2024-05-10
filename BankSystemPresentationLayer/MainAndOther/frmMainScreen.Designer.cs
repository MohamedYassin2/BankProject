namespace BankSystemPresentationLayer
{
    partial class frmMainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainScreen));
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.PeopleMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ClientsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.UsersMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DepositMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.WithdrawMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.TransferMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.accountSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logedInUserInfoMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCurrentDate = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.lblCurrentUser = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.Font = new System.Drawing.Font("Segoe UI", 26F);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PeopleMenu,
            this.ClientsMenu,
            this.UsersMenu,
            this.transactionsToolStripMenuItem,
            this.accountSettingsToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(1372, 56);
            this.MenuStrip.TabIndex = 1;
            this.MenuStrip.Text = "menuStrip1";
            this.MenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuStrip_ItemClicked);
            // 
            // PeopleMenu
            // 
            this.PeopleMenu.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.PeopleMenu.Image = global::BankSystemPresentationLayer.Properties.Resources.People;
            this.PeopleMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.PeopleMenu.Name = "PeopleMenu";
            this.PeopleMenu.Size = new System.Drawing.Size(131, 52);
            this.PeopleMenu.Text = "People";
            this.PeopleMenu.Click += new System.EventHandler(this.sToolStripMenuItem_Click);
            // 
            // ClientsMenu
            // 
            this.ClientsMenu.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.ClientsMenu.Image = global::BankSystemPresentationLayer.Properties.Resources.Clients;
            this.ClientsMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ClientsMenu.Name = "ClientsMenu";
            this.ClientsMenu.Size = new System.Drawing.Size(130, 52);
            this.ClientsMenu.Text = "Clients";
            this.ClientsMenu.Click += new System.EventHandler(this.clientsToolStripMenuItem_Click);
            // 
            // UsersMenu
            // 
            this.UsersMenu.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.UsersMenu.Image = global::BankSystemPresentationLayer.Properties.Resources.Users;
            this.UsersMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.UsersMenu.Name = "UsersMenu";
            this.UsersMenu.Size = new System.Drawing.Size(119, 52);
            this.UsersMenu.Text = "Users";
            this.UsersMenu.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // transactionsToolStripMenuItem
            // 
            this.transactionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DepositMenu,
            this.WithdrawMenu,
            this.TransferMenu});
            this.transactionsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.transactionsToolStripMenuItem.Image = global::BankSystemPresentationLayer.Properties.Resources.Transactions;
            this.transactionsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.transactionsToolStripMenuItem.Name = "transactionsToolStripMenuItem";
            this.transactionsToolStripMenuItem.Size = new System.Drawing.Size(178, 52);
            this.transactionsToolStripMenuItem.Text = "Transactions";
            // 
            // DepositMenu
            // 
            this.DepositMenu.Image = global::BankSystemPresentationLayer.Properties.Resources.deposit;
            this.DepositMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.DepositMenu.Name = "DepositMenu";
            this.DepositMenu.Size = new System.Drawing.Size(185, 38);
            this.DepositMenu.Text = "Deposit";
            this.DepositMenu.Click += new System.EventHandler(this.depositToolStripMenuItem_Click);
            // 
            // WithdrawMenu
            // 
            this.WithdrawMenu.Image = global::BankSystemPresentationLayer.Properties.Resources.withdrawal;
            this.WithdrawMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.WithdrawMenu.Name = "WithdrawMenu";
            this.WithdrawMenu.Size = new System.Drawing.Size(185, 38);
            this.WithdrawMenu.Text = "Withdraw";
            this.WithdrawMenu.Click += new System.EventHandler(this.WithdrawMenu_Click);
            // 
            // TransferMenu
            // 
            this.TransferMenu.Image = global::BankSystemPresentationLayer.Properties.Resources.wire_transfer;
            this.TransferMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TransferMenu.Name = "TransferMenu";
            this.TransferMenu.Size = new System.Drawing.Size(185, 38);
            this.TransferMenu.Text = "Transfer";
            this.TransferMenu.Click += new System.EventHandler(this.TransferMenu_Click);
            // 
            // accountSettingsToolStripMenuItem
            // 
            this.accountSettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logedInUserInfoMenu,
            this.changePasswordMenu,
            this.logOutToolStripMenuItem});
            this.accountSettingsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.accountSettingsToolStripMenuItem.Image = global::BankSystemPresentationLayer.Properties.Resources.AccountSettings;
            this.accountSettingsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.accountSettingsToolStripMenuItem.Name = "accountSettingsToolStripMenuItem";
            this.accountSettingsToolStripMenuItem.Size = new System.Drawing.Size(220, 52);
            this.accountSettingsToolStripMenuItem.Text = "Account Settings";
            // 
            // logedInUserInfoMenu
            // 
            this.logedInUserInfoMenu.Image = global::BankSystemPresentationLayer.Properties.Resources.User_info;
            this.logedInUserInfoMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.logedInUserInfoMenu.Name = "logedInUserInfoMenu";
            this.logedInUserInfoMenu.Size = new System.Drawing.Size(259, 38);
            this.logedInUserInfoMenu.Text = "Loged in User Info";
            this.logedInUserInfoMenu.Click += new System.EventHandler(this.logedInUserInfoMenu_Click);
            // 
            // changePasswordMenu
            // 
            this.changePasswordMenu.Image = global::BankSystemPresentationLayer.Properties.Resources.password;
            this.changePasswordMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.changePasswordMenu.Name = "changePasswordMenu";
            this.changePasswordMenu.Size = new System.Drawing.Size(259, 38);
            this.changePasswordMenu.Text = "Change Password";
            this.changePasswordMenu.Click += new System.EventHandler(this.changePasswordMenu_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Image = global::BankSystemPresentationLayer.Properties.Resources.sign_out__1_;
            this.logOutToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(259, 38);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 50F);
            this.label1.Location = new System.Drawing.Point(585, 564);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 81);
            this.label1.TabIndex = 3;
            this.label1.Text = "MSS BANK";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblCurrentDate
            // 
            this.lblCurrentDate.AutoSize = true;
            this.lblCurrentDate.Font = new System.Drawing.Font("Tahoma", 15F);
            this.lblCurrentDate.ForeColor = System.Drawing.Color.Red;
            this.lblCurrentDate.Location = new System.Drawing.Point(572, 141);
            this.lblCurrentDate.Name = "lblCurrentDate";
            this.lblCurrentDate.Size = new System.Drawing.Size(64, 24);
            this.lblCurrentDate.TabIndex = 5;
            this.lblCurrentDate.Text = "label2";
            this.lblCurrentDate.Click += new System.EventHandler(this.lblCurrentDate_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(583, 517);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Current User:";
            // 
            // lblCurrentUser
            // 
            this.lblCurrentUser.AutoSize = true;
            this.lblCurrentUser.Font = new System.Drawing.Font("Tahoma", 15F);
            this.lblCurrentUser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCurrentUser.Location = new System.Drawing.Point(706, 517);
            this.lblCurrentUser.Name = "lblCurrentUser";
            this.lblCurrentUser.Size = new System.Drawing.Size(37, 24);
            this.lblCurrentUser.TabIndex = 8;
            this.lblCurrentUser.Text = "???";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BankSystemPresentationLayer.Properties.Resources.BaankICO;
            this.pictureBox1.Location = new System.Drawing.Point(533, 168);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(426, 393);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1372, 634);
            this.Controls.Add(this.lblCurrentUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCurrentDate);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "frmMainScreen";
            this.Text = "Bank Main Screen";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem PeopleMenu;
        private System.Windows.Forms.ToolStripMenuItem ClientsMenu;
        private System.Windows.Forms.ToolStripMenuItem UsersMenu;
        private System.Windows.Forms.ToolStripMenuItem transactionsToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCurrentDate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem accountSettingsToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCurrentUser;
        private System.Windows.Forms.ToolStripMenuItem DepositMenu;
        private System.Windows.Forms.ToolStripMenuItem WithdrawMenu;
        private System.Windows.Forms.ToolStripMenuItem TransferMenu;
        private System.Windows.Forms.ToolStripMenuItem logedInUserInfoMenu;
        private System.Windows.Forms.ToolStripMenuItem changePasswordMenu;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
    }
}

