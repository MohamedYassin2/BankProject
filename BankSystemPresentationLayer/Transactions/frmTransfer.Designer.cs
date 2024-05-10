namespace BankSystemPresentationLayer.Transactions
{
    partial class frmTransfer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTransfer));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSelectSenderPerson = new System.Windows.Forms.Button();
            this.btnSelectReciverPerson = new System.Windows.Forms.Button();
            this.ctrSenderlClientCard1 = new BankSystemPresentationLayer.Controls.ctrlClientCard();
            this.ctrlRecieverClientCard = new BankSystemPresentationLayer.Controls.ctrlClientCard();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.txtSpecificAmount = new System.Windows.Forms.TextBox();
            this.chkSpecificAmount = new System.Windows.Forms.CheckBox();
            this.cbTransferAmount = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTransactionID = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblReciverClientID = new System.Windows.Forms.Label();
            this.lblSenderClientID = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label1.Location = new System.Drawing.Point(-2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sender Client";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label2.Location = new System.Drawing.Point(668, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Reciver Client";
            // 
            // btnSelectSenderPerson
            // 
            this.btnSelectSenderPerson.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnSelectSenderPerson.Location = new System.Drawing.Point(511, 2);
            this.btnSelectSenderPerson.Name = "btnSelectSenderPerson";
            this.btnSelectSenderPerson.Size = new System.Drawing.Size(151, 39);
            this.btnSelectSenderPerson.TabIndex = 5;
            this.btnSelectSenderPerson.Text = "Select Sender Person";
            this.btnSelectSenderPerson.UseVisualStyleBackColor = true;
            this.btnSelectSenderPerson.Click += new System.EventHandler(this.btnSelectPerson_Click);
            // 
            // btnSelectReciverPerson
            // 
            this.btnSelectReciverPerson.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnSelectReciverPerson.Location = new System.Drawing.Point(1175, 2);
            this.btnSelectReciverPerson.Name = "btnSelectReciverPerson";
            this.btnSelectReciverPerson.Size = new System.Drawing.Size(151, 39);
            this.btnSelectReciverPerson.TabIndex = 6;
            this.btnSelectReciverPerson.Text = "Select Reciver Person";
            this.btnSelectReciverPerson.UseVisualStyleBackColor = true;
            this.btnSelectReciverPerson.Click += new System.EventHandler(this.button1_Click);
            // 
            // ctrSenderlClientCard1
            // 
            this.ctrSenderlClientCard1.BackColor = System.Drawing.Color.White;
            this.ctrSenderlClientCard1.Font = new System.Drawing.Font("Tahoma", 7F);
            this.ctrSenderlClientCard1.Location = new System.Drawing.Point(2, 33);
            this.ctrSenderlClientCard1.Margin = new System.Windows.Forms.Padding(2);
            this.ctrSenderlClientCard1.Name = "ctrSenderlClientCard1";
            this.ctrSenderlClientCard1.Size = new System.Drawing.Size(660, 388);
            this.ctrSenderlClientCard1.TabIndex = 2;
            // 
            // ctrlRecieverClientCard
            // 
            this.ctrlRecieverClientCard.BackColor = System.Drawing.Color.White;
            this.ctrlRecieverClientCard.Font = new System.Drawing.Font("Tahoma", 7F);
            this.ctrlRecieverClientCard.Location = new System.Drawing.Point(666, 33);
            this.ctrlRecieverClientCard.Margin = new System.Windows.Forms.Padding(2);
            this.ctrlRecieverClientCard.Name = "ctrlRecieverClientCard";
            this.ctrlRecieverClientCard.Size = new System.Drawing.Size(660, 388);
            this.ctrlRecieverClientCard.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTransfer);
            this.groupBox1.Controls.Add(this.txtSpecificAmount);
            this.groupBox1.Controls.Add(this.chkSpecificAmount);
            this.groupBox1.Controls.Add(this.cbTransferAmount);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 13F);
            this.groupBox1.Location = new System.Drawing.Point(12, 422);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(650, 148);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transfer ";
            // 
            // btnTransfer
            // 
            this.btnTransfer.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnTransfer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransfer.Location = new System.Drawing.Point(482, 61);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(120, 34);
            this.btnTransfer.TabIndex = 60;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // txtSpecificAmount
            // 
            this.txtSpecificAmount.Location = new System.Drawing.Point(148, 61);
            this.txtSpecificAmount.Name = "txtSpecificAmount";
            this.txtSpecificAmount.Size = new System.Drawing.Size(121, 28);
            this.txtSpecificAmount.TabIndex = 59;
            this.txtSpecificAmount.Visible = false;
            // 
            // chkSpecificAmount
            // 
            this.chkSpecificAmount.AutoSize = true;
            this.chkSpecificAmount.Location = new System.Drawing.Point(290, 65);
            this.chkSpecificAmount.Name = "chkSpecificAmount";
            this.chkSpecificAmount.Size = new System.Drawing.Size(156, 26);
            this.chkSpecificAmount.TabIndex = 58;
            this.chkSpecificAmount.Text = "Specific Amount";
            this.chkSpecificAmount.UseVisualStyleBackColor = true;
            this.chkSpecificAmount.CheckedChanged += new System.EventHandler(this.chkSpecificAmount_CheckedChanged);
            // 
            // cbTransferAmount
            // 
            this.cbTransferAmount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTransferAmount.FormattingEnabled = true;
            this.cbTransferAmount.Items.AddRange(new object[] {
            "100",
            "200",
            "500",
            "1000",
            "1500",
            "2000"});
            this.cbTransferAmount.Location = new System.Drawing.Point(148, 61);
            this.cbTransferAmount.Name = "cbTransferAmount";
            this.cbTransferAmount.Size = new System.Drawing.Size(121, 29);
            this.cbTransferAmount.TabIndex = 57;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 19);
            this.label3.TabIndex = 56;
            this.label3.Text = "Amount:";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(154, 55);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(36, 19);
            this.lblAmount.TabIndex = 62;
            this.lblAmount.Text = "???";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(64, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 19);
            this.label5.TabIndex = 61;
            this.label5.Text = " Amount:";
            // 
            // lblTransactionID
            // 
            this.lblTransactionID.AutoSize = true;
            this.lblTransactionID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactionID.Location = new System.Drawing.Point(154, 24);
            this.lblTransactionID.Name = "lblTransactionID";
            this.lblTransactionID.Size = new System.Drawing.Size(36, 19);
            this.lblTransactionID.TabIndex = 60;
            this.lblTransactionID.Text = "???";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 19);
            this.label7.TabIndex = 59;
            this.label7.Text = "TransactionID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblReciverClientID);
            this.groupBox2.Controls.Add(this.lblSenderClientID);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lblDate);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lblAmount);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lblTransactionID);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 13F);
            this.groupBox2.Location = new System.Drawing.Point(672, 426);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(551, 148);
            this.groupBox2.TabIndex = 63;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transaction Info";
            // 
            // lblReciverClientID
            // 
            this.lblReciverClientID.AutoSize = true;
            this.lblReciverClientID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReciverClientID.Location = new System.Drawing.Point(414, 57);
            this.lblReciverClientID.Name = "lblReciverClientID";
            this.lblReciverClientID.Size = new System.Drawing.Size(36, 19);
            this.lblReciverClientID.TabIndex = 68;
            this.lblReciverClientID.Text = "???";
            // 
            // lblSenderClientID
            // 
            this.lblSenderClientID.AutoSize = true;
            this.lblSenderClientID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenderClientID.Location = new System.Drawing.Point(414, 24);
            this.lblSenderClientID.Name = "lblSenderClientID";
            this.lblSenderClientID.Size = new System.Drawing.Size(36, 19);
            this.lblSenderClientID.TabIndex = 67;
            this.lblSenderClientID.Text = "???";
            this.lblSenderClientID.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(260, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 19);
            this.label8.TabIndex = 66;
            this.label8.Text = "Reciver ClientID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(260, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 19);
            this.label6.TabIndex = 65;
            this.label6.Text = "Sender ClientID:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(154, 86);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(36, 19);
            this.lblDate.TabIndex = 64;
            this.lblDate.Text = "???";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(94, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 19);
            this.label4.TabIndex = 63;
            this.label4.Text = "Date:";
            // 
            // frmTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1323, 582);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSelectReciverPerson);
            this.Controls.Add(this.btnSelectSenderPerson);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrSenderlClientCard1);
            this.Controls.Add(this.ctrlRecieverClientCard);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTransfer";
            this.Text = "Transfer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.ctrlClientCard ctrlRecieverClientCard;
        private Controls.ctrlClientCard ctrSenderlClientCard1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSelectSenderPerson;
        private System.Windows.Forms.Button btnSelectReciverPerson;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSpecificAmount;
        private System.Windows.Forms.CheckBox chkSpecificAmount;
        private System.Windows.Forms.ComboBox cbTransferAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTransactionID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblReciverClientID;
        private System.Windows.Forms.Label lblSenderClientID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label4;
    }
}