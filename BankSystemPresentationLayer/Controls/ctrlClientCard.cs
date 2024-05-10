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
    public partial class ctrlClientCard : UserControl
    {
        clsClient _Client;
        public ctrlClientCard()
        {
            InitializeComponent();
        }
        public int PersonID
        {
            get
            {
                if (ctrlPerson1.lPersonID == "[????]")
                    return -1;

                return Convert.ToInt32(ctrlPerson1.lPersonID);
            }
        }

        public string lPersonID
        {
            get { return ctrlPerson1.lPersonID; }
        }
        public void LoadPersonInfoWithID(int PersonID)
        {
            ctrlPerson1.LoadPersonInfoWithID(PersonID);
        }
        public void LoadClientInfoByClientID(int ClientID)
        {
            if (ClientID < 0)
                return;
            _Client = clsClient.Find(ClientID);
            if (_Client != null)
            {
                ctrlPerson1.LoadPersonInfoWithID(_Client.PersonID);
                lblAccountNumber.Text = _Client.AccountNumber;
                lblAccountBalance.Text = (_Client.AccountBalance.ToString()+"$");
                lblAccountType.Text = _Client.AccountType;
                return;
            }
            else
                MessageBox.Show($"Client With ClientID {ClientID} Is Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void ctrlClientCard_Load(object sender, EventArgs e)
        {
            
        }

        private void ctrlPerson1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
