namespace BankSystemPresentationLayer.Transactions
{
    partial class frmDeposits
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDeposits));
            this.btnSave = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnSelectPerson = new System.Windows.Forms.Button();
            this.ctrlClientCard1 = new BankSystemPresentationLayer.Controls.ctrlClientCard();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSpecificAmount = new System.Windows.Forms.TextBox();
            this.chkSpecificAmount = new System.Windows.Forms.CheckBox();
            this.cbDepositAmount = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTransactionID = new System.Windows.Forms.Label();
            this.lblDepositAmount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(691, 571);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 34);
            this.btnSave.TabIndex = 50;
            this.btnSave.Text = "Deposit";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnSelectPerson);
            this.tabPage1.Controls.Add(this.ctrlClientCard1);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(813, 509);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Person Info";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnSelectPerson
            // 
            this.btnSelectPerson.Location = new System.Drawing.Point(640, 6);
            this.btnSelectPerson.Name = "btnSelectPerson";
            this.btnSelectPerson.Size = new System.Drawing.Size(151, 39);
            this.btnSelectPerson.TabIndex = 3;
            this.btnSelectPerson.Text = "Select A Person";
            this.btnSelectPerson.UseVisualStyleBackColor = true;
            this.btnSelectPerson.Click += new System.EventHandler(this.btnSelectPerson_Click);
            // 
            // ctrlClientCard1
            // 
            this.ctrlClientCard1.BackColor = System.Drawing.Color.White;
            this.ctrlClientCard1.Font = new System.Drawing.Font("Tahoma", 8F);
            this.ctrlClientCard1.Location = new System.Drawing.Point(3, 46);
            this.ctrlClientCard1.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlClientCard1.Name = "ctrlClientCard1";
            this.ctrlClientCard1.Size = new System.Drawing.Size(803, 456);
            this.ctrlClientCard1.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(821, 541);
            this.tabControl1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSpecificAmount);
            this.groupBox1.Controls.Add(this.chkSpecificAmount);
            this.groupBox1.Controls.Add(this.cbDepositAmount);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.groupBox1.Location = new System.Drawing.Point(8, 544);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 76);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Deposit";
            // 
            // txtSpecificAmount
            // 
            this.txtSpecificAmount.Location = new System.Drawing.Point(91, 20);
            this.txtSpecificAmount.Name = "txtSpecificAmount";
            this.txtSpecificAmount.Size = new System.Drawing.Size(121, 27);
            this.txtSpecificAmount.TabIndex = 55;
            this.txtSpecificAmount.Visible = false;
            // 
            // chkSpecificAmount
            // 
            this.chkSpecificAmount.AutoSize = true;
            this.chkSpecificAmount.Location = new System.Drawing.Point(233, 24);
            this.chkSpecificAmount.Name = "chkSpecificAmount";
            this.chkSpecificAmount.Size = new System.Drawing.Size(143, 23);
            this.chkSpecificAmount.TabIndex = 54;
            this.chkSpecificAmount.Text = "Specific Amount";
            this.chkSpecificAmount.UseVisualStyleBackColor = true;
            this.chkSpecificAmount.CheckedChanged += new System.EventHandler(this.chkSpecificAmount_CheckedChanged);
            // 
            // cbDepositAmount
            // 
            this.cbDepositAmount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepositAmount.FormattingEnabled = true;
            this.cbDepositAmount.Items.AddRange(new object[] {
            "100",
            "200",
            "500",
            "1000",
            "1500",
            "2000"});
            this.cbDepositAmount.Location = new System.Drawing.Point(91, 20);
            this.cbDepositAmount.Name = "cbDepositAmount";
            this.cbDepositAmount.Size = new System.Drawing.Size(121, 27);
            this.cbDepositAmount.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 19);
            this.label1.TabIndex = 52;
            this.label1.Text = "Amount:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(413, 555);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 19);
            this.label2.TabIndex = 53;
            this.label2.Text = "TransactionID:";
            // 
            // lblTransactionID
            // 
            this.lblTransactionID.AutoSize = true;
            this.lblTransactionID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactionID.Location = new System.Drawing.Point(549, 555);
            this.lblTransactionID.Name = "lblTransactionID";
            this.lblTransactionID.Size = new System.Drawing.Size(36, 19);
            this.lblTransactionID.TabIndex = 54;
            this.lblTransactionID.Text = "???";
            // 
            // lblDepositAmount
            // 
            this.lblDepositAmount.AutoSize = true;
            this.lblDepositAmount.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepositAmount.Location = new System.Drawing.Point(549, 586);
            this.lblDepositAmount.Name = "lblDepositAmount";
            this.lblDepositAmount.Size = new System.Drawing.Size(36, 19);
            this.lblDepositAmount.TabIndex = 56;
            this.lblDepositAmount.Text = "???";
            this.lblDepositAmount.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(397, 586);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 19);
            this.label4.TabIndex = 55;
            this.label4.Text = "Deposit Amount:";
            // 
            // frmDeposits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(822, 625);
            this.Controls.Add(this.lblDepositAmount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTransactionID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmDeposits";
            this.Text = "Deposits";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDeposits_FormClosed);
            this.Load += new System.EventHandler(this.frmDeposits_Load);
            this.ForeColorChanged += new System.EventHandler(this.frmDeposits_ForeColorChanged);
            this.tabPage1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnSelectPerson;
        private Controls.ctrlClientCard ctrlClientCard1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSpecificAmount;
        private System.Windows.Forms.CheckBox chkSpecificAmount;
        private System.Windows.Forms.ComboBox cbDepositAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTransactionID;
        private System.Windows.Forms.Label lblDepositAmount;
        private System.Windows.Forms.Label label4;
    }
}