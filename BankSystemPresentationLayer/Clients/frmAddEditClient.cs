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
    public partial class frmAddEditClient : Form
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;


        int _ClientID;
        clsClient _Client;
        public frmAddEditClient(int ClientID)
        {
            InitializeComponent();
            _ClientID = ClientID;
            if (_ClientID == -1)
                _Mode = enMode.AddNew;
            else
                _Mode = enMode.Update;
        }
        private string GenerateRandomAccountNumber()
        {
            Random random = new Random();

            
            const int accountNumberLength = 12;

            // Generate a random account number
            string accountNumber = "";
            for (int i = 0; i < accountNumberLength; i++)
            {
               
                int randomNumber = random.Next(48, 58);
                char randomDigit = (char)randomNumber;
                accountNumber += randomDigit;
            }

            return accountNumber;
        }

        private void HideOldPINBlock()
        {
            txtOldPIN.Visible = false;
            pictureBox5.Visible = false;
            label6.Visible = false;
        }
        private void ShowOldPINBlock()
        {
            txtOldPIN.Visible = true;
            pictureBox5.Visible = true;
            label6.Visible = true;
        }
        private void frmAddEditClient_Load(object sender, EventArgs e)
        {

            //Add User
            ((Control)this.tabPage2).Enabled = false;
            if (_Mode == enMode.AddNew)
            {
                lblMode.Text = "Add New Client";
                _Client = new clsClient();
                this.Text = "Add New Client";
                btnEditPersonInfo.Visible = false;
                cbAccountType.SelectedIndex = 0;
                HideOldPINBlock();
                chkChangePIN.Visible = false;
                btnNext.Visible = true;
                btnGenerateAccountNumber.Visible = true;
               
                return; 
            }

            //Edit User
            _Client = clsClient.Find(_ClientID);
            ((Control)this.tabPage2).Enabled = true;
            if (_Client == null)
            {
                MessageBox.Show("This form will be closed because No Client with ID = " + _ClientID);
                this.Close();

                return;
            }
            btnSelectPerson.Visible = false;
            btnNext.Visible = false;
            chkChangePIN.Visible = true;
            HideOldPINBlock();
            btnEditPersonInfo.Visible = false;
            this.Text = "Edit Client";
            lblMode.Text = "Edit Client";
            ctrlClientCard1.LoadClientInfoByClientID(_Client.ClientID);
            lblAccountNumber.Text = _Client.AccountNumber;
            txtAccountBalance.Text = _Client.AccountBalance.ToString();
            btnGenerateAccountNumber.Visible = false;
            if (_Client.AccountType == "Saving Account")
                cbAccountType.SelectedIndex = 0;
            else
                cbAccountType.SelectedIndex = 1;
            btnGenerateAccountNumber.Visible = false;

        }

        public void LoadPersonInfo(object sender, int PersonID)
        {
            ctrlClientCard1.LoadPersonInfoWithID(PersonID);
        }

        private void btnSelectPerson_Click(object sender, EventArgs e)
        {
            frmFindPerson frm = new frmFindPerson();
            frm.DataBack += LoadPersonInfo;
            frm.ShowDialog();
        }

        private void btnEditPersonInfo_Click(object sender, EventArgs e)
        {
            if (ctrlClientCard1.lPersonID == "[????]")
                return;
            frmAddEditPerson frm = new frmAddEditPerson(ctrlClientCard1.PersonID);
            frm.ShowDialog();
            ctrlClientCard1.LoadPersonInfoWithID(ctrlClientCard1.PersonID);
        }

        private void btnGenerateAccountNumber_Click(object sender, EventArgs e)
        {
            string NewAccountNumber = GenerateRandomAccountNumber();
            if (clsClient.IsAccountNumberExist(NewAccountNumber))
                return;
            lblAccountNumber.Text = NewAccountNumber;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (ctrlClientCard1.lPersonID == "[????]")
            {
                MessageBox.Show("Please First Select A Person.", "Select Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (_Mode == enMode.AddNew)
            {
                if (clsClient.IsClientExistByPersonID(ctrlClientCard1.PersonID))
                {
                    MessageBox.Show("Selected Person Already has a Client ,Choose another one.", "Select Another Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            //go to page 2 in tap control
            ((Control)this.tabPage2).Enabled = true;
            tabControl1.SelectedTab = tabPage2;
            tabPage2.Focus();
            btnNext.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAccountBalance.Text)
                || string.IsNullOrWhiteSpace(cbAccountType.Text)
                )
            {
                MessageBox.Show("SomeFileds Are Epmty Please Fill All Fildes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(lblAccountNumber.Text)
                
               )
            {
                MessageBox.Show("Plase Genrate Account Number For The Client", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (_Mode == enMode.AddNew)
            {
                if (string.IsNullOrWhiteSpace(txtPIN.Text)
                || string.IsNullOrWhiteSpace(txtConfirmPIN.Text)
                )
                {
                    MessageBox.Show("Client Should Enter a PIN", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txtPIN.Text != txtConfirmPIN.Text)
                {
                    MessageBox.Show("2 Password Enterd Dosnt Matched", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
               


            }
            if (_Mode == enMode.Update)
            {
                int.TryParse(txtAccountBalance.Text, out int AccountBalanc1);
                if (AccountBalanc1 < _Client.AccountBalance)
                {
                    MessageBox.Show("You Cannot Decrease the account balance Of Current Client", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }





            _Client.PersonID = ctrlClientCard1.PersonID;
            _Client.AccountNumber = lblAccountNumber.Text;
             int.TryParse(txtAccountBalance.Text, out int NewBalance);
             _Client.AccountBalance = NewBalance;
             if (cbAccountType.Text == "Saving Account")
                 _Client.AccountType = "Saving Account";
             else
               _Client.AccountType = "VIP Account";
            if (_Mode == enMode.AddNew)
                _Client.PIN = txtConfirmPIN.Text;

            if (chkChangePIN.Checked)
            {
                if (_Mode == enMode.Update)
                {
                    clsClient C = clsClient.FindByPersonID(_Client.PersonID);
                    if (txtOldPIN.Text != C.PIN)
                    {
                        MessageBox.Show("Old PIN is wrong System Cant Update PIN", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (txtPIN.Text != txtConfirmPIN.Text)
                    {
                        MessageBox.Show("2 Password Enterd Dosnt Matched", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    _Client.PIN = txtConfirmPIN.Text;
                }
            }
            

            

            if (_Client.Save())
            {
                MessageBox.Show("Data Saved Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _Mode = enMode.Update;
                lblMode.Text = "Edit Client";
                lblAccountNumber.Text = _Client.AccountNumber.ToString();
                chkChangePIN.Visible = true;
                ctrlClientCard1.LoadClientInfoByClientID(_Client.ClientID);
                btnSelectPerson.Visible = false;
                btnGenerateAccountNumber.Visible = false;
                chkChangePIN.Checked = false;
                txtOldPIN.Clear();
                txtConfirmPIN.Clear();
                txtPIN.Clear();
            }
            else
                MessageBox.Show("Error: Data Is not Saved.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //btnNext.Visible = true;
        }

        private void cbAccountType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_Mode == enMode.Update)
            {
                int.TryParse(txtAccountBalance.Text, out int AccountBalanc2);
                if (_Client.AccountType == "Saving Account")
                {
                    if (cbAccountType.Text == "VIP Account")
                    {
                        AccountBalanc2 += 500;
                        txtAccountBalance.Text = AccountBalanc2.ToString();

                    }
                }
            }
             if (_Mode == enMode.AddNew)
            {
                if (cbAccountType.Text == "VIP Account")
                {
                    int.TryParse(txtAccountBalance.Text, out int AccountBalanc3);
                    AccountBalanc3 += 500;
                    txtAccountBalance.Text = AccountBalanc3.ToString();

                }
            }
        }

        private void chkChangePIN_CheckedChanged(object sender, EventArgs e)
        {
            if(chkChangePIN.Checked ==false)
            {
                HideOldPINBlock();
                return;
            }
            ShowOldPINBlock();
        }
    }
}
