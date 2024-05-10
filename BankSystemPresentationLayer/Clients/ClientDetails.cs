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
    public partial class frmClientDetails : Form
    {
        int _ClientID;
        public frmClientDetails(int clientID)
        {
            InitializeComponent();
            _ClientID = clientID;
        }

        private void frmClientDetails_Load(object sender, EventArgs e)
        {
            ctrlClientCard1.LoadClientInfoByClientID(_ClientID);
        }
    }
}
