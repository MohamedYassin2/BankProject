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
    public partial class frmAddEditUser : Form
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;

        

        int _UserID;
        clsUser _User;
        public frmAddEditUser(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
            if (_UserID == -1)
                _Mode = enMode.AddNew;
            else
                _Mode = enMode.Update;
        }

        public void LoadPersonInfo(object sender, int PersonID)
        {
            ctrlPerson1.LoadPersonInfoWithID(PersonID);
        }
        private void btnSelectPerson_Click(object sender, EventArgs e)
        {
            frmFindPerson frm = new frmFindPerson();
            frm.DataBack += LoadPersonInfo;
            frm.ShowDialog();
        }

        private void frmAddEditUser_Load(object sender, EventArgs e)
        {
            //Add User
            ((Control)this.tabPage2).Enabled = false;
            if (_Mode == enMode.AddNew)
            {
                lblMode.Text = "Add New User";
                _User = new clsUser();
                this.Text = "Add New User";
                btnEditPersonInfo.Visible = false;
                btnNext.Visible = true;
                btnSelectPerson.Visible = true;
                btnEditPersonInfo.Visible = false;
                return;
            }

            //Edit User
            _User = clsUser.Find(_UserID);
            ((Control)this.tabPage2).Enabled = true;
            if (_User == null)
            {
                MessageBox.Show("This form will be closed because No User with ID = " + _UserID);
                this.Close();

                return;
            }
            btnNext.Visible = false;
            btnSelectPerson.Visible = false;
            btnEditPersonInfo.Visible = false;
            this.Text = "Edit User";
            lblMode.Text = "Edit User";
            ctrlPerson1.LoadPersonInfoWithID(_User.PersonID);
            lblUserID.Text = _User.UserID.ToString();
            txtUserName.Text = _User.UserName;
            txtPassword.Text = _User.Password;
            txtConfirmPassword.Text = _User.Password;
            chkIsActive.Checked = _User.IsActive;
            _LoadUserPermission();
        }
        private void _LoadUserPermission()
        {
            if (clsPermissions.HasPermission(_User.Permission, Convert.ToInt32(clsPermissions.enPermission.All)))
            {
                chkAll.Checked = true;
                return;
            }
            if (clsPermissions.HasPermission(_User.Permission, Convert.ToInt32(clsPermissions.enPermission.People)))
            {
                chkPeople.Checked = true;
            }
            if (clsPermissions.HasPermission(_User.Permission, Convert.ToInt32(clsPermissions.enPermission.Clients)))
            {
                chkClients.Checked = true;
            }
            if (clsPermissions.HasPermission(_User.Permission, Convert.ToInt32(clsPermissions.enPermission.Users)))
            {
                chkUsers.Checked = true;
            }
            if (clsPermissions.HasPermission(_User.Permission, Convert.ToInt32(clsPermissions.enPermission.Deposits)))
            {
                chkDeposits.Checked = true;
            }
            if (clsPermissions.HasPermission(_User.Permission, Convert.ToInt32(clsPermissions.enPermission.Withdrawls)))
            {
                chkWithdrawl.Checked = true;
            }
            if (clsPermissions.HasPermission(_User.Permission, Convert.ToInt32(clsPermissions.enPermission.Transfer)))
            {
                chkTransfer.Checked = true;
            }
        }

        private void btnEditPersonInfo_Click(object sender, EventArgs e)
        {
            if (ctrlPerson1.lPersonID == "[????]")
                return;
            frmAddEditPerson frm = new frmAddEditPerson(ctrlPerson1.PersonID);
            frm.ShowDialog();
            ctrlPerson1.LoadPersonInfoWithID(ctrlPerson1.PersonID);
        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {

        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {

        }

        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            if (ctrlPerson1.lPersonID == "[????]")
            {
                MessageBox.Show("Please First Select A Person.", "Select Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            if (_Mode == enMode.AddNew)
            {
                if (clsUser.IsUserExistByPersonID(ctrlPerson1.PersonID))
                {
                    MessageBox.Show("Selected Person Already has a user ,Choose another one.", "Select Another Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }   

            ((Control)this.tabPage2).Enabled = true;
            tabControl1.SelectedTab = tabPage2;
            tabPage2.Focus();
            btnNext.Visible = false;
        }

        private void txtUserName_Validating_1(object sender, CancelEventArgs e)
        {
            if (_Mode == enMode.Update)
                return;
            if (string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                e.Cancel = true;
                txtUserName.Focus();
                errorProvider1.SetError(txtUserName, "UserName Should Have Value!");
                return;
            }
            if (clsUser.IsUserExist(txtUserName.Text))
            {
                e.Cancel = true;
                txtUserName.Focus();
                errorProvider1.SetError(txtUserName, "UserName Is Already Exist");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtUserName, "");

            }
        }

        private void txtPassword_Validating_1(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                e.Cancel = true;
                txtPassword.Focus();
                errorProvider1.SetError(txtPassword, "Password Should Have Value!");
                return;
            }
            if (txtPassword.Text.Length < 8)
            {
                e.Cancel = true;
                txtPassword.Focus();
                errorProvider1.SetError(txtPassword, "Password Should be 8 Characters or more");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtPassword, "");

            }

        }

        private void txtConfirmPassword_Validating_1(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtConfirmPassword.Text))
            {
                e.Cancel = true;
                txtConfirmPassword.Focus();
                errorProvider1.SetError(txtConfirmPassword, "ConfirmPassword Should Have Value!");
                return;
            }
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                errorProvider1.SetError(txtConfirmPassword, "Password Enterd Dosnt match Password");
                return;
            }
        }


        private int _GetUserPermission()
        {
            int Permission = 0;
            if (chkAll.Checked)
                return Convert.ToInt32 (clsPermissions.enPermission.All);
            if(chkPeople.Checked)
                Permission  += Convert.ToInt32(clsPermissions.enPermission.People);
            if (chkClients.Checked)
                Permission += Convert.ToInt32(clsPermissions.enPermission.Clients);
            if (chkUsers.Checked)
                Permission += Convert.ToInt32(clsPermissions.enPermission.Users);
            if (chkDeposits.Checked)
                Permission += Convert.ToInt32(clsPermissions.enPermission.Deposits);
            if (chkWithdrawl.Checked)
                Permission += Convert.ToInt32(clsPermissions.enPermission.Withdrawls);
            if (chkTransfer.Checked)
                Permission += Convert.ToInt32(clsPermissions.enPermission.Transfer);

            return Permission;


        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserName.Text)
                || string.IsNullOrWhiteSpace(txtPassword.Text)
                || string.IsNullOrWhiteSpace(txtConfirmPassword.Text)
                )
            {
                MessageBox.Show("SomeFileds Are Epmty Please Fill All Fildes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_Mode == enMode.AddNew)
            {
                if (clsUser.IsUserExistByPersonID(ctrlPerson1.PersonID))
                {
                    MessageBox.Show("UserName Is Already Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (txtConfirmPassword.Text != txtPassword.Text)
            {
                MessageBox.Show("2 Password Enterd Dosnt Matched", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int UserPermission=_GetUserPermission();

            _User.PersonID = ctrlPerson1.PersonID;
            _User.UserName = txtUserName.Text;
            _User.Password = txtConfirmPassword.Text.ToString();
            _User.Permission = UserPermission;
            _User.IsActive = chkIsActive.Checked;

            if(MessageBox.Show("Are You Sure You Want to Save?","Question",MessageBoxButtons.OK,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                if (_User.Save())
                {
                    MessageBox.Show("Data Saved Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _Mode = enMode.Update;
                    lblMode.Text = "Edit User";
                    lblUserID.Text = _User.UserID.ToString();
                    btnEditPersonInfo.Visible = true;
                    btnSelectPerson.Visible = false;
                }
                else
                    MessageBox.Show("Error: Data Is not Saved.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void ctrlPerson1_Load(object sender, EventArgs e)
        {

        }

       

        private void UnCheckAllPerrmissionCheckBox()
        {
            if (chkAll.Checked)
                chkAll.Checked = false;
        }
        private void chkPeople_CheckedChanged(object sender, EventArgs e)
        {
            if(chkPeople.Checked)
            UnCheckAllPerrmissionCheckBox();
        }

        private void chkClients_CheckedChanged(object sender, EventArgs e)
        {
            if (chkClients.Checked)
                UnCheckAllPerrmissionCheckBox();

        }

        private void chkUsers_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUsers.Checked)
                UnCheckAllPerrmissionCheckBox();

        }

        private void chkWithdrawl_CheckedChanged(object sender, EventArgs e)
        {
            if (chkWithdrawl.Checked)
                UnCheckAllPerrmissionCheckBox();

        }

        private void chkAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAll.Checked)
            {
                chkPeople.Checked = false;
                chkClients.Checked = false;
                chkUsers.Checked = false;
                chkDeposits.Checked = false;
                chkWithdrawl.Checked = false;
                chkTransfer.Checked = false;
            }
           

        }

        private void chkTransfer_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTransfer.Checked)
                UnCheckAllPerrmissionCheckBox();

        }
    }
}
