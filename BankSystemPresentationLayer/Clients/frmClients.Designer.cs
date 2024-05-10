namespace BankSystemPresentationLayer
{
    partial class frmClients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClients));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.cbClientFilter = new System.Windows.Forms.ComboBox();
            this.dgvAllClients = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clientDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblRecords = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddNewClient = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllClients)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 36F);
            this.label1.Location = new System.Drawing.Point(273, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 58);
            this.label1.TabIndex = 3;
            this.label1.Text = "Clients";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 20F);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(1, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 33);
            this.label2.TabIndex = 10;
            this.label2.Text = "Filter By:";
            // 
            // txtFilter
            // 
            this.txtFilter.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txtFilter.Location = new System.Drawing.Point(310, 295);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(190, 32);
            this.txtFilter.TabIndex = 9;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // cbClientFilter
            // 
            this.cbClientFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClientFilter.Font = new System.Drawing.Font("Tahoma", 15F);
            this.cbClientFilter.FormattingEnabled = true;
            this.cbClientFilter.Items.AddRange(new object[] {
            "ClientID",
            "PersonID",
            "Name",
            "Account Number",
            "Account Type"});
            this.cbClientFilter.Location = new System.Drawing.Point(119, 295);
            this.cbClientFilter.Name = "cbClientFilter";
            this.cbClientFilter.Size = new System.Drawing.Size(185, 32);
            this.cbClientFilter.TabIndex = 8;
            this.cbClientFilter.SelectedIndexChanged += new System.EventHandler(this.cbClientFilter_SelectedIndexChanged);
            // 
            // dgvAllClients
            // 
            this.dgvAllClients.AllowUserToAddRows = false;
            this.dgvAllClients.AllowUserToDeleteRows = false;
            this.dgvAllClients.AllowUserToOrderColumns = true;
            this.dgvAllClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvAllClients.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvAllClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllClients.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvAllClients.Location = new System.Drawing.Point(7, 331);
            this.dgvAllClients.Name = "dgvAllClients";
            this.dgvAllClients.ReadOnly = true;
            this.dgvAllClients.Size = new System.Drawing.Size(731, 237);
            this.dgvAllClients.TabIndex = 11;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientDetailsToolStripMenuItem,
            this.addNewClientToolStripMenuItem,
            this.editClientToolStripMenuItem,
            this.deleteClientToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(174, 156);
            // 
            // clientDetailsToolStripMenuItem
            // 
            this.clientDetailsToolStripMenuItem.Image = global::BankSystemPresentationLayer.Properties.Resources.clientInfo;
            this.clientDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.clientDetailsToolStripMenuItem.Name = "clientDetailsToolStripMenuItem";
            this.clientDetailsToolStripMenuItem.Size = new System.Drawing.Size(173, 38);
            this.clientDetailsToolStripMenuItem.Text = "Client Details";
            this.clientDetailsToolStripMenuItem.Click += new System.EventHandler(this.clientDetailsToolStripMenuItem_Click);
            // 
            // addNewClientToolStripMenuItem
            // 
            this.addNewClientToolStripMenuItem.Image = global::BankSystemPresentationLayer.Properties.Resources.clientadd;
            this.addNewClientToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addNewClientToolStripMenuItem.Name = "addNewClientToolStripMenuItem";
            this.addNewClientToolStripMenuItem.Size = new System.Drawing.Size(173, 38);
            this.addNewClientToolStripMenuItem.Text = "Add New Client";
            this.addNewClientToolStripMenuItem.Click += new System.EventHandler(this.addNewClientToolStripMenuItem_Click);
            // 
            // editClientToolStripMenuItem
            // 
            this.editClientToolStripMenuItem.Image = global::BankSystemPresentationLayer.Properties.Resources.clientedit;
            this.editClientToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.editClientToolStripMenuItem.Name = "editClientToolStripMenuItem";
            this.editClientToolStripMenuItem.Size = new System.Drawing.Size(173, 38);
            this.editClientToolStripMenuItem.Text = "Edit Client";
            this.editClientToolStripMenuItem.Click += new System.EventHandler(this.editClientToolStripMenuItem_Click);
            // 
            // deleteClientToolStripMenuItem
            // 
            this.deleteClientToolStripMenuItem.Image = global::BankSystemPresentationLayer.Properties.Resources.clientdelete;
            this.deleteClientToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deleteClientToolStripMenuItem.Name = "deleteClientToolStripMenuItem";
            this.deleteClientToolStripMenuItem.Size = new System.Drawing.Size(173, 38);
            this.deleteClientToolStripMenuItem.Text = "Delete Client";
            this.deleteClientToolStripMenuItem.Click += new System.EventHandler(this.deleteClientToolStripMenuItem_Click);
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("Tahoma", 16F);
            this.lblRecords.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRecords.Location = new System.Drawing.Point(132, 571);
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
            this.label3.Location = new System.Drawing.Point(12, 571);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 27);
            this.label3.TabIndex = 47;
            this.label3.Text = "#Records:";
            // 
            // btnAddNewClient
            // 
            this.btnAddNewClient.Image = global::BankSystemPresentationLayer.Properties.Resources.Client_Add__2_;
            this.btnAddNewClient.Location = new System.Drawing.Point(668, 252);
            this.btnAddNewClient.Name = "btnAddNewClient";
            this.btnAddNewClient.Size = new System.Drawing.Size(70, 73);
            this.btnAddNewClient.TabIndex = 49;
            this.btnAddNewClient.UseVisualStyleBackColor = true;
            this.btnAddNewClient.Click += new System.EventHandler(this.btnAddNewClient_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BankSystemPresentationLayer.Properties.Resources.ClientsLarge_ICon;
            this.pictureBox1.Location = new System.Drawing.Point(256, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 172);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // frmClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(745, 606);
            this.Controls.Add(this.btnAddNewClient);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvAllClients);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.cbClientFilter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmClients";
            this.Text = "Clients";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmClients_FormClosed);
            this.Load += new System.EventHandler(this.frmClients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllClients)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.ComboBox cbClientFilter;
        private System.Windows.Forms.DataGridView dgvAllClients;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddNewClient;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteClientToolStripMenuItem;
    }
}