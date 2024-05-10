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

namespace BankSystemPresentationLayer.Controls
{
    public partial class ctrlUserCard : UserControl
    {
        public ctrlUserCard()
        {
            InitializeComponent();
        }
        clsUser _User;

        public void LoadUserInfo(int UserID)
        {
            _User = clsUser.Find(UserID);

            if (_User != null)
            {
                lblUserName.Text = _User.UserName;
                lblUserID.Text = UserID.ToString();
                if (_User.IsActive)
                    lblIsActive.Text = "Yes";
                else
                    lblIsActive.Text = "No";

                ctrlPerson1.LoadPersonInfoWithID(_User.PersonID);
            }
            else
                MessageBox.Show($"Error : User With ID[{UserID}] is not Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void ctrlUserCard_Load(object sender, EventArgs e)
        {

        }
    }
}
