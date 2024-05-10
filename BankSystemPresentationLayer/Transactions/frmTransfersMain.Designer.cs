namespace BankSystemPresentationLayer.Transactions
{
    partial class frmTransfersMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTransfersMain));
            this.dgvAllTransfers = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteTransactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeDepositToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDateFilter = new System.Windows.Forms.DateTimePicker();
            this.lblRecords = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.cbTransferFilter = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAddNewTransfer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllTransfers)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAllTransfers
            // 
            this.dgvAllTransfers.AllowUserToAddRows = false;
            this.dgvAllTransfers.AllowUserToDeleteRows = false;
            this.dgvAllTransfers.AllowUserToOrderColumns = true;
            this.dgvAllTransfers.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvAllTransfers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllTransfers.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvAllTransfers.Location = new System.Drawing.Point(12, 343);
            this.dgvAllTransfers.Name = "dgvAllTransfers";
            this.dgvAllTransfers.ReadOnly = true;
            this.dgvAllTransfers.Size = new System.Drawing.Size(862, 237);
            this.dgvAllTransfers.TabIndex = 53;
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
            this.makeDepositToolStripMenuItem.Text = "Make Transfer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 36F);
            this.label1.Location = new System.Drawing.Point(337, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 58);
            this.label1.TabIndex = 52;
            this.label1.Text = "Transfers";
            // 
            // dtpDateFilter
            // 
            this.dtpDateFilter.CustomFormat = "yyyy-MM-dd";
            this.dtpDateFilter.Font = new System.Drawing.Font("Tahoma", 15F);
            this.dtpDateFilter.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateFilter.Location = new System.Drawing.Point(324, 305);
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
            this.lblRecords.Location = new System.Drawing.Point(128, 597);
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
            this.label3.Location = new System.Drawing.Point(8, 597);
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
            this.label2.Location = new System.Drawing.Point(15, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 33);
            this.label2.TabIndex = 56;
            this.label2.Text = "Filter By:";
            // 
            // txtFilter
            // 
            this.txtFilter.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txtFilter.Location = new System.Drawing.Point(324, 305);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(190, 32);
            this.txtFilter.TabIndex = 55;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // cbTransferFilter
            // 
            this.cbTransferFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTransferFilter.Font = new System.Drawing.Font("Tahoma", 15F);
            this.cbTransferFilter.FormattingEnabled = true;
            this.cbTransferFilter.Items.AddRange(new object[] {
            "TTransactionID",
            "Sender ClientID",
            "Reciver ClientID",
            "Sender Name",
            "Reciver Name",
            "Amount",
            "Date"});
            this.cbTransferFilter.Location = new System.Drawing.Point(133, 305);
            this.cbTransferFilter.Name = "cbTransferFilter";
            this.cbTransferFilter.Size = new System.Drawing.Size(185, 32);
            this.cbTransferFilter.TabIndex = 54;
            this.cbTransferFilter.SelectedIndexChanged += new System.EventHandler(this.cbTransferFilter_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BankSystemPresentationLayer.Properties.Resources.transfer;
            this.pictureBox1.Location = new System.Drawing.Point(343, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // btnAddNewTransfer
            // 
            this.btnAddNewTransfer.Image = global::BankSystemPresentationLayer.Properties.Resources.money_add__1_;
            this.btnAddNewTransfer.Location = new System.Drawing.Point(791, 255);
            this.btnAddNewTransfer.Name = "btnAddNewTransfer";
            this.btnAddNewTransfer.Size = new System.Drawing.Size(75, 83);
            this.btnAddNewTransfer.TabIndex = 59;
            this.btnAddNewTransfer.UseVisualStyleBackColor = true;
            this.btnAddNewTransfer.Click += new System.EventHandler(this.btnAddNewTransfer_Click);
            // 
            // frmTransfersMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(878, 631);
            this.Controls.Add(this.dgvAllTransfers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dtpDateFilter);
            this.Controls.Add(this.btnAddNewTransfer);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.cbTransferFilter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmTransfersMain";
            this.Text = "Transfers Main";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmTransfers_FormClosed);
            this.Load += new System.EventHandler(this.frmTransfers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllTransfers)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAllTransfers;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteTransactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeDepositToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dtpDateFilter;
        private System.Windows.Forms.Button btnAddNewTransfer;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.ComboBox cbTransferFilter;
    }
}