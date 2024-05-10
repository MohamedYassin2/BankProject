namespace BankSystemPresentationLayer.Transactions
{
    partial class frmDepositMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDepositMain));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvAllDeposits = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.cbDepositFilter = new System.Windows.Forms.ComboBox();
            this.lblRecords = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDateFilter = new System.Windows.Forms.DateTimePicker();
            this.btnAddNewUser = new System.Windows.Forms.Button();
            this.deleteTransactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeDepositToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllDeposits)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 36F);
            this.label1.Location = new System.Drawing.Point(230, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 58);
            this.label1.TabIndex = 3;
            this.label1.Text = "Deposits";
            // 
            // dgvAllDeposits
            // 
            this.dgvAllDeposits.AllowUserToAddRows = false;
            this.dgvAllDeposits.AllowUserToDeleteRows = false;
            this.dgvAllDeposits.AllowUserToOrderColumns = true;
            this.dgvAllDeposits.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvAllDeposits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllDeposits.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvAllDeposits.Location = new System.Drawing.Point(12, 341);
            this.dgvAllDeposits.Name = "dgvAllDeposits";
            this.dgvAllDeposits.ReadOnly = true;
            this.dgvAllDeposits.Size = new System.Drawing.Size(669, 237);
            this.dgvAllDeposits.TabIndex = 4;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteTransactionToolStripMenuItem,
            this.makeDepositToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(187, 80);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 20F);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(15, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 33);
            this.label2.TabIndex = 10;
            this.label2.Text = "Filter By:";
            // 
            // txtFilter
            // 
            this.txtFilter.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txtFilter.Location = new System.Drawing.Point(324, 303);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(190, 32);
            this.txtFilter.TabIndex = 9;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // cbDepositFilter
            // 
            this.cbDepositFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepositFilter.Font = new System.Drawing.Font("Tahoma", 15F);
            this.cbDepositFilter.FormattingEnabled = true;
            this.cbDepositFilter.Items.AddRange(new object[] {
            "DTransactionID",
            "ClientID",
            "Amount",
            "Name",
            "Date"});
            this.cbDepositFilter.Location = new System.Drawing.Point(133, 303);
            this.cbDepositFilter.Name = "cbDepositFilter";
            this.cbDepositFilter.Size = new System.Drawing.Size(185, 32);
            this.cbDepositFilter.TabIndex = 8;
            this.cbDepositFilter.SelectedIndexChanged += new System.EventHandler(this.cbDepositFilter_SelectedIndexChanged);
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("Tahoma", 16F);
            this.lblRecords.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRecords.Location = new System.Drawing.Point(128, 595);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(42, 27);
            this.lblRecords.TabIndex = 48;
            this.lblRecords.Text = "???";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(8, 595);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 27);
            this.label3.TabIndex = 47;
            this.label3.Text = "#Records:";
            // 
            // dtpDateFilter
            // 
            this.dtpDateFilter.CustomFormat = "yyyy-MM-dd";
            this.dtpDateFilter.Font = new System.Drawing.Font("Tahoma", 15F);
            this.dtpDateFilter.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateFilter.Location = new System.Drawing.Point(324, 303);
            this.dtpDateFilter.Name = "dtpDateFilter";
            this.dtpDateFilter.Size = new System.Drawing.Size(190, 32);
            this.dtpDateFilter.TabIndex = 50;
            this.dtpDateFilter.Visible = false;
            this.dtpDateFilter.ValueChanged += new System.EventHandler(this.dtpDateFilter_ValueChanged);
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.Image = global::BankSystemPresentationLayer.Properties.Resources.payment_add__2_;
            this.btnAddNewUser.Location = new System.Drawing.Point(606, 253);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.Size = new System.Drawing.Size(75, 83);
            this.btnAddNewUser.TabIndex = 49;
            this.btnAddNewUser.UseVisualStyleBackColor = true;
            this.btnAddNewUser.Click += new System.EventHandler(this.btnAddNewUser_Click);
            // 
            // deleteTransactionToolStripMenuItem
            // 
            this.deleteTransactionToolStripMenuItem.Image = global::BankSystemPresentationLayer.Properties.Resources.payment_delete;
            this.deleteTransactionToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deleteTransactionToolStripMenuItem.Name = "deleteTransactionToolStripMenuItem";
            this.deleteTransactionToolStripMenuItem.Size = new System.Drawing.Size(186, 38);
            this.deleteTransactionToolStripMenuItem.Text = "Delete Transaction";
            this.deleteTransactionToolStripMenuItem.Click += new System.EventHandler(this.deleteTransactionToolStripMenuItem_Click);
            // 
            // makeDepositToolStripMenuItem
            // 
            this.makeDepositToolStripMenuItem.Image = global::BankSystemPresentationLayer.Properties.Resources.payment_add;
            this.makeDepositToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.makeDepositToolStripMenuItem.Name = "makeDepositToolStripMenuItem";
            this.makeDepositToolStripMenuItem.Size = new System.Drawing.Size(186, 38);
            this.makeDepositToolStripMenuItem.Text = "Make Deposit";
            this.makeDepositToolStripMenuItem.Click += new System.EventHandler(this.makeDepositToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BankSystemPresentationLayer.Properties.Resources.DepositMain;
            this.pictureBox1.Location = new System.Drawing.Point(236, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmDepositMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(687, 631);
            this.Controls.Add(this.dtpDateFilter);
            this.Controls.Add(this.btnAddNewUser);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.cbDepositFilter);
            this.Controls.Add(this.dgvAllDeposits);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmDepositMain";
            this.Text = "Deposit Main";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDepositMain_FormClosed);
            this.Load += new System.EventHandler(this.frmDepositMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllDeposits)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvAllDeposits;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.ComboBox cbDepositFilter;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddNewUser;
        private System.Windows.Forms.DateTimePicker dtpDateFilter;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteTransactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeDepositToolStripMenuItem;
    }
}