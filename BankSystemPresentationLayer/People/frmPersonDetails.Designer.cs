namespace BankSystemPresentationLayer
{
    partial class frmPersonDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPersonDetails));
            this.ctrlPerson1 = new BankSystemPresentationLayer.ctrlPerson();
            this.SuspendLayout();
            // 
            // ctrlPerson1
            // 
            this.ctrlPerson1.Location = new System.Drawing.Point(0, 1);
            this.ctrlPerson1.Name = "ctrlPerson1";
            this.ctrlPerson1.Size = new System.Drawing.Size(788, 340);
            this.ctrlPerson1.TabIndex = 0;
            // 
            // frmPersonDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(791, 332);
            this.Controls.Add(this.ctrlPerson1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "frmPersonDetails";
            this.Text = "Person Info";
            this.Load += new System.EventHandler(this.frmPersonDetails_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlPerson ctrlPerson1;
    }
}