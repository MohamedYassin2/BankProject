namespace BankSystemPresentationLayer.Controls
{
    partial class ctrlClientCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ctrlPerson1 = new BankSystemPresentationLayer.ctrlPerson();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAccountType = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAccountBalance = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrlPerson1
            // 
            this.ctrlPerson1.Location = new System.Drawing.Point(0, 3);
            this.ctrlPerson1.Name = "ctrlPerson1";
            this.ctrlPerson1.Size = new System.Drawing.Size(788, 322);
            this.ctrlPerson1.TabIndex = 0;
            this.ctrlPerson1.Load += new System.EventHandler(this.ctrlPerson1_Load);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAccountType);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblAccountBalance);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblAccountNumber);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupBox1.Location = new System.Drawing.Point(3, 331);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(785, 120);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bnak Account Info";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblAccountType
            // 
            this.lblAccountType.AutoSize = true;
            this.lblAccountType.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblAccountType.Location = new System.Drawing.Point(174, 84);
            this.lblAccountType.Name = "lblAccountType";
            this.lblAccountType.Size = new System.Drawing.Size(36, 19);
            this.lblAccountType.TabIndex = 5;
            this.lblAccountType.Text = "???";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(30, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Account Type:";
            // 
            // lblAccountBalance
            // 
            this.lblAccountBalance.AutoSize = true;
            this.lblAccountBalance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblAccountBalance.ForeColor = System.Drawing.Color.Red;
            this.lblAccountBalance.Location = new System.Drawing.Point(174, 53);
            this.lblAccountBalance.Name = "lblAccountBalance";
            this.lblAccountBalance.Size = new System.Drawing.Size(36, 19);
            this.lblAccountBalance.TabIndex = 3;
            this.lblAccountBalance.Text = "???";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(6, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Account Balance:";
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblAccountNumber.ForeColor = System.Drawing.Color.Red;
            this.lblAccountNumber.Location = new System.Drawing.Point(174, 20);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(36, 19);
            this.lblAccountNumber.TabIndex = 1;
            this.lblAccountNumber.Text = "???";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account Number:";
            // 
            // ctrlClientCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ctrlPerson1);
            this.Name = "ctrlClientCard";
            this.Size = new System.Drawing.Size(791, 454);
            this.Load += new System.EventHandler(this.ctrlClientCard_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlPerson ctrlPerson1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblAccountType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAccountBalance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAccountNumber;
        private System.Windows.Forms.Label label1;
    }
}
