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

namespace BankSystemPresentationLayer.Users
{
    public partial class frmChangeUserPassword : Form
    {
        int _UserID;
        clsUser _User;
        // Declare a delegate
        public delegate void DataBackEventHandler(object sender);

        // Declare an event using the delegate
        public event DataBackEventHandler DataBack;
        public frmChangeUserPassword(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
        }

        private void frmChangeUserPassword_Load(object sender, EventArgs e)
        {
            ctrlUserCard1.LoadUserInfo(_UserID);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if(MessageBox.Show("Are You sure you want to Change Password?","Question",MessageBoxButtons.OK,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2)==DialogResult.OK)
            {
                if(string.IsNullOrEmpty(txtConfirmPassword.Text)|| string.IsNullOrEmpty(txtNewPassword.Text) || string.IsNullOrEmpty(txtOldPassword.Text))
                {
                    MessageBox.Show("Error:Some Fileds Are Empty  ", "Cant Change Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                    _User = clsUser.Find(_UserID);
                if(_User!= null)
                {
                    if(_User.Password != txtOldPassword.Text)
                    {
                        MessageBox.Show("Error:Old Password Is Wrong. ", "Cant Change Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if(txtNewPassword.Text != txtConfirmPassword.Text)
                    {
                        MessageBox.Show("Error:New Password And Confirm Password Filed Is Not Compatib ", "Cant Change Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    _User.Password = txtConfirmPassword.Text;
                    if(_User.Save())
                    {
                        MessageBox.Show("Password Changed Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtConfirmPassword.Clear();
                        txtNewPassword.Clear();
                        txtOldPassword.Clear();
                        return;
                    }
                    MessageBox.Show("Error:Try Again Later", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }

        private void frmChangeUserPassword_FormClosed(object sender, FormClosedEventArgs e)
        {
            DataBack?.Invoke(this);
        }
    }
}
