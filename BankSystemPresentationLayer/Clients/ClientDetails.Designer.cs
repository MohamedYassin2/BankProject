namespace BankSystemPresentationLayer
{
    partial class frmClientDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClientDetails));
            this.ctrlClientCard1 = new BankSystemPresentationLayer.Controls.ctrlClientCard();
            this.SuspendLayout();
            // 
            // ctrlClientCard1
            // 
            this.ctrlClientCard1.BackColor = System.Drawing.Color.White;
            this.ctrlClientCard1.Location = new System.Drawing.Point(-3, -2);
            this.ctrlClientCard1.Name = "ctrlClientCard1";
            this.ctrlClientCard1.Size = new System.Drawing.Size(806, 454);
            this.ctrlClientCard1.TabIndex = 0;
            // 
            // frmClientDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ctrlClientCard1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmClientDetails";
            this.Text = "Client Details";
            this.Load += new System.EventHandler(this.frmClientDetails_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ctrlClientCard ctrlClientCard1;
    }
}