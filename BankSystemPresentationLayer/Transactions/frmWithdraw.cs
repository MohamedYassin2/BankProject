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
    public partial class frmWithdraw : Form
    {
        // Declare a delegate
        public delegate void DataBackEventHandler(object sender);

        // Declare an event using the delegate
        public event DataBackEventHandler DataBack;
        public frmWithdraw()
        {
            InitializeComponent();
        }

        clsClient _Client;
        int _PersonID;
        clsWithdrawl _WithDrawl;
        private void frmWithdraw_Load(object sender, EventArgs e)
        {
            cbWithDrawlAmount.SelectedIndex = 0;
        }

        private void frmWithdraw_FormClosed(object sender, FormClosedEventArgs e)
        {
            DataBack?.Invoke(this);
        }

        public void LoadClientInfo(object sender, int PersonID)
        {
            ctrlClientCard1.LoadPersonInfoWithID(PersonID);
            _Client = clsClient.FindByPersonID(ctrlClientCard1.PersonID);
            if (_Client != null)
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
        private void RejectWithDrawl()
        {
            MessageBox.Show("Erro :Anount Exeed Client Balance", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }
        private void chkSpecificAmount_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSpecificAmount.Checked)
            {
                txtSpecificAmount.Visible = true;
                cbWithDrawlAmount.Visible = false;
                return;
            }
            else
            {
                txtSpecificAmount.Visible = false;
                cbWithDrawlAmount.Visible = true;
            }
        }

        
        private void btnWithDrawl_Click(object sender, EventArgs e)
        {
            if (ctrlClientCard1.lPersonID == "[????]")
            {
                MessageBox.Show("Please First Select A Person.", "Select Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            if (txtSpecificAmount.Visible)
            {
                int.TryParse(txtSpecificAmount.Text, out int tAmount);
                if (tAmount <= 0)
                {
                    MessageBox.Show("Please Enter Valid Amount For Withdraw", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            






            int Amount = 0;

            _PersonID = ctrlClientCard1.PersonID;
            _Client = clsClient.FindByPersonID(_PersonID);
            if (_Client != null)
            {
                if (cbWithDrawlAmount.Visible)
                {
                    switch (cbWithDrawlAmount.Text)
                    {
                        case "100":
                            Amount = 100;    
                            if(!_Client.Withdrawl(100))
                            {
                                RejectWithDrawl();
                                return;
                            }
                            break;

                        case "200":
                            Amount = 200;
                            if (!_Client.Withdrawl(200))
                            {
                                RejectWithDrawl();
                                return;
                            }
                            break;

                        case "500":
                            Amount = 500;
                            if (!_Client.Withdrawl(500))
                            {
                                RejectWithDrawl();
                                return;
                            }
                            break;
                        case "1000":
                            Amount = 1000;
                            if (!_Client.Withdrawl(1000))
                            {
                                RejectWithDrawl();
                                return;
                            }
                            break;
                        case "1500":
                            Amount = 1500;
                            if (!_Client.Withdrawl(1500))
                            {
                                RejectWithDrawl();
                                return;
                            }
                            break;
                        case "2000":
                            Amount = 2000;
                            if (!_Client.Withdrawl(2000))
                            {
                                RejectWithDrawl();
                                return;
                            }
                            break;
                        default:
                            break;


                    }




                }

                if (txtSpecificAmount.Visible)
                {
                    if (int.TryParse(txtSpecificAmount.Text, out int WAmount))
                    {
                        Amount = WAmount;
                        if(!_Client.Withdrawl(WAmount))
                        {
                            RejectWithDrawl();
                            return;
                        }
                        
                    }


                }
            }


            _WithDrawl = new clsWithdrawl();
            _WithDrawl.ClientID = _Client.ClientID;
            _WithDrawl.Amount = Amount;
            _WithDrawl.WTransactionDate = DateTime.Now;


            if (MessageBox.Show($"Are You Sure You Want To Witdrawl {Amount}", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                lblTransactionID.Text = "???";

                if (_Client.Save() && _WithDrawl.Save())
                {
                    lblTransactionID.Text = _WithDrawl.WTransactionID.ToString();
                    lblWithdrawAmount.Text = _WithDrawl.Amount.ToString();
                    txtSpecificAmount.Clear();
                    ctrlClientCard1.LoadClientInfoByClientID(_Client.ClientID);
                    MessageBox.Show($"WithDrawl Done Successfuly Now Client Account Balance is {_Client.AccountBalance}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                    MessageBox.Show("Error: Something is wrong try again later.", "Deposit Failed ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSelectPerson_Click_1(object sender, EventArgs e)
        {
            frmFindPerson frm = new frmFindPerson();
            frm.DataBack += LoadClientInfo;
            frm.ShowDialog();
        }
    }
}
