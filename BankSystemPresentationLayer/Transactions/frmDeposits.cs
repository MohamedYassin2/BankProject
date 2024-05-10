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

namespace BankSystemPresentationLayer.Transactions
{
    public partial class frmDeposits : Form
    {
        // Declare a delegate
        public delegate void DataBackEventHandler(object sender);

        // Declare an event using the delegate
        public event DataBackEventHandler DataBack;

        clsClient _Client;
        int _PersonID;
        clsDeposit _Deposit;
        public frmDeposits()
        {
            InitializeComponent();
        }

        private void frmDeposits_Load(object sender, EventArgs e)
        {
            cbDepositAmount.SelectedIndex = 0;
        }

        private void frmDeposits_ForeColorChanged(object sender, EventArgs e)
        {

        }

        private void frmDeposits_FormClosed(object sender, FormClosedEventArgs e)
        {
            DataBack?.Invoke(this);
        }
        public void LoadClientInfo(object sender, int PersonID)
        {
            ctrlClientCard1.LoadPersonInfoWithID(PersonID);
            _Client = clsClient.FindByPersonID(ctrlClientCard1.PersonID);
            if(_Client!=null)
            {
                ctrlClientCard1.LoadClientInfoByClientID(_Client.ClientID);
            }
        }
        private void btnSelectPerson_Click(object sender, EventArgs e)
        {
            frmFindPerson frm = new frmFindPerson();
            frm.DataBack += LoadClientInfo;
            frm.ShowDialog();
        }

        private void chkSpecificAmount_CheckedChanged(object sender, EventArgs e)
        {
            if(chkSpecificAmount.Checked)
            {
                txtSpecificAmount.Visible = true;
                cbDepositAmount.Visible = false;
                return;
            }
            else
            {
                txtSpecificAmount.Visible = false ;
                cbDepositAmount.Visible = true;
            }
        }


       
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ctrlClientCard1.lPersonID == "[????]")
            {
                MessageBox.Show("Please First Select A Person.", "Select Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            if(txtSpecificAmount.Visible)
            {
                int.TryParse(txtSpecificAmount.Text, out int tAmount);
                if (tAmount <= 0)
                {
                    MessageBox.Show("Please Enter Valid Amount For Deposit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }







            int Amount = 0 ;

                _PersonID = ctrlClientCard1.PersonID;
            _Client = clsClient.FindByPersonID(_PersonID);
            if (_Client != null)
            {
                if (cbDepositAmount.Visible)
                {
                    switch (cbDepositAmount.Text)
                    {
                        case "100":
                            _Client.Deposit(100);
                            Amount = 100;
                            break;

                        case "200":
                            _Client.Deposit(200);
                            Amount = 200;
                            break;

                        case "500":
                            _Client.Deposit(500);
                            Amount = 500;
                            break;
                        case "1000":
                            _Client.Deposit(1000);
                            Amount = 1000;
                            break;
                        case "1500":
                            _Client.Deposit(1500);
                            Amount = 1500;
                            break;
                        case "2000":
                            _Client.Deposit(2000);
                            Amount = 2000;
                            break;
                        default:
                            break;


                    }




                }

                if (txtSpecificAmount.Visible)
                {
                    if (int.TryParse(txtSpecificAmount.Text, out int DAmount))
                    {
                        _Client.Deposit(DAmount);
                        Amount = DAmount;
                    }


                }
            }
           

            _Deposit = new clsDeposit();
            _Deposit.ClientID = _Client.ClientID;
            _Deposit.Amount = Amount;
            _Deposit.DTransactionDate = DateTime.Now;


            if (MessageBox.Show($"Are You Sure You Want To Deposit {Amount}", "Question", MessageBoxButtons.OKCancel,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2)==DialogResult.OK)
            {
                lblTransactionID.Text = "???";

                if (_Client.Save()&& _Deposit.Save())
                {
                    lblTransactionID.Text = _Deposit.DTransactionID.ToString();
                    lblDepositAmount.Text = _Deposit.Amount.ToString();
                    txtSpecificAmount.Clear();
                    ctrlClientCard1.LoadClientInfoByClientID(_Client.ClientID);
                    MessageBox.Show($"Deposit Done Successfuly Now Client Account Balance is {_Client.AccountBalance}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                    MessageBox.Show("Error: Something is wrong try again later.", "Deposit Failed ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
