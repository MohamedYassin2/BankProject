namespace BankSystemPresentationLayer
{
    partial class frmUserDetalis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserDetalis));
            this.ctrlUserCard1 = new BankSystemPresentationLayer.Controls.ctrlUserCard();
            this.SuspendLayout();
            // 
            // ctrlUserCard1
            // 
            this.ctrlUserCard1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ctrlUserCard1.Location = new System.Drawing.Point(0, 0);
            this.ctrlUserCard1.Name = "ctrlUserCard1";
            this.ctrlUserCard1.Size = new System.Drawing.Size(791, 475);
            this.ctrlUserCard1.TabIndex = 0;
            this.ctrlUserCard1.Load += new System.EventHandler(this.ctrlUserCard1_Load);
            // 
            // frmUserDetalis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 468);
            this.Controls.Add(this.ctrlUserCard1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmUserDetalis";
            this.Text = "User Details";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmUserDetalis_FormClosed);
            this.Load += new System.EventHandler(this.frmUserDetalis_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ctrlUserCard ctrlUserCard1;
    }
}