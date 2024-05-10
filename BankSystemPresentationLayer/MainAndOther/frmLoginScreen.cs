using BankSystemBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystemPresentationLayer
{
    public partial class frmLoginScreen : Form
    {
        public frmLoginScreen()
        {
            InitializeComponent();
        }
        clsUser User;
       
        

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUserName.Text == string.Empty&&txtPassword.Text == string.Empty)
            {
                MessageBox.Show("Please Enter UserName And Password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            User = clsUser.Find(txtUserName.Text,txtPassword.Text);

            if (User == null || (!txtPassword.Text.Equals(User.Password)) || (!txtUserName.Text.Equals(User.UserName)))
            {
                MessageBox.Show("Invalid UserName Or Password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (User.IsActive == false)
                {
                    MessageBox.Show("Your Account Is DeActive Contact Your Admin ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    this.Hide();
                    clsCurrentUser.CurrentUser = User;
                    frmMainScreen frm = new frmMainScreen(User.UserID) ;
                    frm.ShowDialog();
                    this.Close();
                    return;
                }




            }


        }

        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.Green;
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.White;

        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode  ==Keys.Enter)
            {
                btnLogin.BackColor = Color.Green;
                btnLogin_Click(sender, e);
            }
            
        }

        private void txtPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLogin.BackColor = Color.White;
        }

        private void frmLoginScreen_Load(object sender, EventArgs e)
        {

        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.BackColor = Color.Green;
                btnLogin_Click(sender, e);
            }

        }

        private void txtUserName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLogin.BackColor = Color.White;
        }
    }
}
