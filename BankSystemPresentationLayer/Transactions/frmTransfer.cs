using BankSystemBusinessLayer;
using BankSystemPresentationLayer.Controls;
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
    public partial class frmTransfer : Form
    {
        clsClient _Client;
        clsClient _SenderClient;
        clsClient _ReciverClient;
        clsTransfer _Transfer;
        public frmTransfer()
        {
            InitializeComponent();
        }

        private void _ResetTransactionInfo()
        {
            lblTransactionID.Text = "???";
            lblSenderClientID.Text = "???";
            lblReciverClientID.Text = "???";
            lblDate.Text = "???";
            lblAmount.Text = "???";
        }
        public void LoadSenderClientInfo(object sender, int PersonID)
        {
            ctrSenderlClientCard1.LoadPersonInfoWithID(PersonID);
            _Client = clsClient.FindByPersonID(ctrSenderlClientCard1.PersonID);
            if (_Client != null)
            {
                ctrSenderlClientCard1.LoadClientInfoByClientID(_Client.ClientID);
            }
        }
        public void LoadReciverClientInfo(object sender, int PersonID)
        {
            ctrlRecieverClientCard.LoadPersonInfoWithID(PersonID);
            _Client = clsClient.FindByPersonID(ctrlRecieverClientCard.PersonID);
            if (_Client != null)
            {
                ctrlRecieverClientCard.LoadClientInfoByClientID(_Client.ClientID);
            }
        }
        private void btnSelectPerson_Click(object sender, EventArgs e)
        {
            _ResetTransactionInfo();
          frmFindPerson frm = new frmFindPerson();
          frm.DataBack += LoadSenderClientInfo;
          frm.ShowDialog();
          return;
              
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _ResetTransactionInfo();
            frmFindPerson frm = new frmFindPerson();
            frm.DataBack += LoadReciverClientInfo;
            frm.ShowDialog();
        }

        private void _RejectTransfer()
        {
            MessageBox.Show("Amount Exeed Sender Client Account Balance", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btnTransfer_Click(object sender, EventArgs e)
        {
            _ResetTransactionInfo();
            if (ctrlRecieverClientCard.lPersonID == "[????]")
            {
                MessageBox.Show("Please First Select A Reciver Person.", "Select Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            if (ctrSenderlClientCard1.lPersonID == "[????]")
            {
                MessageBox.Show("Please First Select A Sender Person.", "Select Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (txtSpecificAmount.Visible)
            {
                int.TryParse(txtSpecificAmount.Text, out int tAmount);
                if (tAmount <= 0)
                {
                    MessageBox.Show("Please Enter Valid Amount For Transfer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (MessageBox.Show($"Are You Sure You Want To Do Transfer ?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                _Transfer = new clsTransfer();
                int TotalAmount = -1;
                _SenderClient = clsClient.FindByPersonID(ctrSenderlClientCard1.PersonID);
                _ReciverClient = clsClient.FindByPersonID(ctrlRecieverClientCard.PersonID);
                if (_SenderClient != null && _ReciverClient != null)
                {
                    if (txtSpecificAmount.Visible)
                    {
                        int.TryParse(txtSpecificAmount.Text, out int ttAmount);
                        if (ttAmount > _SenderClient.AccountBalance)
                        {
                            _RejectTransfer();
                            return;
                        }
                        else
                        {
                            _SenderClient.Transfer(_ReciverClient, ttAmount);
                            TotalAmount = ttAmount;
                        }
                    }
                    if (cbTransferAmount.Visible)
                    {
                        switch (cbTransferAmount.Text)
                        {
                            case "100":
                                if (!_SenderClient.Transfer(_ReciverClient, 100))
                                {
                                    _RejectTransfer();
                                    return;
                                }
                                TotalAmount = 100;
                                break;
                            case "200":
                                if (!_SenderClient.Transfer(_ReciverClient, 200))
                                {
                                    _RejectTransfer();
                                    return;
                                }
                                TotalAmount = 200;
                                break;
                            case "500":
                                if (!_SenderClient.Transfer(_ReciverClient, 500))
                                {
                                    _RejectTransfer();
                                    return;
                                }
                                TotalAmount = 500;
                                break;
                            case "1000":
                                if (!_SenderClient.Transfer(_ReciverClient, 1000))
                                {
                                    _RejectTransfer();
                                    return;
                                }
                                TotalAmount = 1000;
                                break;
                            case "1500":
                                if (!_SenderClient.Transfer(_ReciverClient, 1500))
                                {
                                    _RejectTransfer();
                                    return;
                                }
                                TotalAmount = 1500;
                                break;
                            case "2000":
                                if (!_SenderClient.Transfer(_ReciverClient, 2000))
                                {
                                    _RejectTransfer();
                                    return;
                                }
                                TotalAmount = 2000;
                                break;

                        }

                    }

                    _Transfer.SenderClientID = _SenderClient.ClientID;
                    _Transfer.ReciverClientID = _ReciverClient.ClientID;
                    _Transfer.TTransactionDate = DateTime.Now;
                    _Transfer.Amount = TotalAmount;

                    if (_Transfer.Save() & _SenderClient.Save() && _ReciverClient.Save())
                    {
                        MessageBox.Show($"Transfer Done Successfuly with Amount {TotalAmount}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lblTransactionID.Text = _Transfer.TTransactionID.ToString();
                        lblSenderClientID.Text = _Transfer.SenderClientID.ToString();
                        lblReciverClientID.Text = _Transfer.ReciverClientID.ToString();
                        lblDate.Text = _Transfer.TTransactionDate.Date.ToString();
                        lblAmount.Text = _Transfer.Amount.ToString();
                        ctrSenderlClientCard1.LoadClientInfoByClientID(_SenderClient.ClientID);
                        ctrlRecieverClientCard.LoadClientInfoByClientID(_ReciverClient.ClientID);

                    }
                    else
                        MessageBox.Show("Error: Something is wrong try again later.", "Deposit Failed ", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }

            }


        }

        private void chkSpecificAmount_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSpecificAmount.Checked)
            {
                txtSpecificAmount.Visible = true;
                cbTransferAmount.Visible = false;
                return;
            }
            else
            {
                txtSpecificAmount.Visible = false;
                cbTransferAmount.Visible = true;
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
