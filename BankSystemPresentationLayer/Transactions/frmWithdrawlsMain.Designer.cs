namespace BankSystemPresentationLayer.Transactions
{
    partial class frmWithdrawlsMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWithdrawlsMain));
            this.dtpDateFilter = new System.Windows.Forms.DateTimePicker();
            this.lblRecords = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.cbWithdrawlFilter = new System.Windows.Forms.ComboBox();
            this.dgvAllWithdrawls = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteTransactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeDepositToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddNewWithdrawl = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllWithdrawls)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDateFilter
            // 
            this.dtpDateFilter.CustomFormat = "yyyy-MM-dd";
            this.dtpDateFilter.Font = new System.Drawing.Font("Tahoma", 15F);
            this.dtpDateFilter.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateFilter.Location = new System.Drawing.Point(318, 299);
            this.dtpDateFilter.Name = "dtpDateFilter";
            this.dtpDateFilter.Size = new System.Drawing.Size(190, 32);
            this.dtpDateFilter.TabIndex = 60;
            this.dtpDateFilter.Visible = false;
            this.dtpDateFilter.ValueChanged += new System.EventHandler(this.dtpDateFilter_ValueChanged);
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("Tahoma", 16F);
            this.lblRecords.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRecords.Location = new System.Drawing.Point(122, 591);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(42, 27);
            this.lblRecords.TabIndex = 58;
            this.lblRecords.Text = "???";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(2, 591);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 27);
            this.label3.TabIndex = 57;
            this.label3.Text = "#Records:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 20F);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(9, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 33);
            this.label2.TabIndex = 56;
            this.label2.Text = "Filter By:";
            // 
            // txtFilter
            // 
            this.txtFilter.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txtFilter.Location = new System.Drawing.Point(318, 299);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(190, 32);
            this.txtFilter.TabIndex = 55;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // cbWithdrawlFilter
            // 
            this.cbWithdrawlFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWithdrawlFilter.Font = new System.Drawing.Font("Tahoma", 15F);
            this.cbWithdrawlFilter.FormattingEnabled = true;
            this.cbWithdrawlFilter.Items.AddRange(new object[] {
            "WTransactionID",
            "ClientID",
            "Amount",
            "Name",
            "Date"});
            this.cbWithdrawlFilter.Location = new System.Drawing.Point(127, 299);
            this.cbWithdrawlFilter.Name = "cbWithdrawlFilter";
            this.cbWithdrawlFilter.Size = new System.Drawing.Size(185, 32);
            this.cbWithdrawlFilter.TabIndex = 54;
            this.cbWithdrawlFilter.SelectedIndexChanged += new System.EventHandler(this.cbWithdrawlFilter_SelectedIndexChanged);
            // 
            // dgvAllWithdrawls
            // 
            this.dgvAllWithdrawls.AllowUserToAddRows = false;
            this.dgvAllWithdrawls.AllowUserToDeleteRows = false;
            this.dgvAllWithdrawls.AllowUserToOrderColumns = true;
            this.dgvAllWithdrawls.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvAllWithdrawls.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllWithdrawls.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvAllWithdrawls.Location = new System.Drawing.Point(6, 337);
            this.dgvAllWithdrawls.Name = "dgvAllWithdrawls";
            this.dgvAllWithdrawls.ReadOnly = true;
            this.dgvAllWithdrawls.Size = new System.Drawing.Size(669, 237);
            this.dgvAllWithdrawls.TabIndex = 53;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteTransactionToolStripMenuItem,
            this.makeDepositToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(187, 80);
            // 
            // deleteTransactionToolStripMenuItem
            // 
            this.deleteTransactionToolStripMenuItem.Image = global::BankSystemPresentationLayer.Properties.Resources.withdrawal_delete;
            this.deleteTransactionToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deleteTransactionToolStripMenuItem.Name = "deleteTransactionToolStripMenuItem";
            this.deleteTransactionToolStripMenuItem.Size = new System.Drawing.Size(186, 38);
            this.deleteTransactionToolStripMenuItem.Text = "Delete Transaction";
            this.deleteTransactionToolStripMenuItem.Click += new System.EventHandler(this.deleteTransactionToolStripMenuItem_Click);
            // 
            // makeDepositToolStripMenuItem
            // 
            this.makeDepositToolStripMenuItem.Image = global::BankSystemPresentationLayer.Properties.Resources.withdrawal_add;
            this.makeDepositToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.makeDepositToolStripMenuItem.Name = "makeDepositToolStripMenuItem";
            this.makeDepositToolStripMenuItem.Size = new System.Drawing.Size(186, 38);
            this.makeDepositToolStripMenuItem.Text = "Make Deposit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 36F);
            this.label1.Location = new System.Drawing.Point(207, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 58);
            this.label1.TabIndex = 52;
            this.label1.Text = "WithDrawls";
            // 
            // btnAddNewWithdrawl
            // 
            this.btnAddNewWithdrawl.Image = global::BankSystemPresentationLayer.Properties.Resources.withdrawal_add__1_;
            this.btnAddNewWithdrawl.Location = new System.Drawing.Point(600, 249);
            this.btnAddNewWithdrawl.Name = "btnAddNewWithdrawl";
            this.btnAddNewWithdrawl.Size = new System.Drawing.Size(75, 83);
            this.btnAddNewWithdrawl.TabIndex = 59;
            this.btnAddNewWithdrawl.UseVisualStyleBackColor = true;
            this.btnAddNewWithdrawl.Click += new System.EventHandler(this.btnAddNewWithdrawl_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BankSystemPresentationLayer.Properties.Resources.Withdrawls_main;
            this.pictureBox1.Location = new System.Drawing.Point(230, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // frmWithdrawlsMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(687, 631);
            this.Controls.Add(this.dtpDateFilter);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.cbWithdrawlFilter);
            this.Controls.Add(this.dgvAllWithdrawls);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddNewWithdrawl);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmWithdrawlsMain";
            this.Text = "Withdrawls Main";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmWithdrawlsMain_FormClosed);
            this.Load += new System.EventHandler(this.frmWithdrawlsMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllWithdrawls)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDateFilter;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.ComboBox cbWithdrawlFilter;
        private System.Windows.Forms.DataGridView dgvAllWithdrawls;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteTransactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeDepositToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddNewWithdrawl;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}