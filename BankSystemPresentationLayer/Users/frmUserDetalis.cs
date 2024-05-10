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

namespace BankSystemPresentationLayer
{
    public partial class frmUserDetalis : Form
    {
        int _UserID;
        // Declare a delegate
        public delegate void DataBackEventHandler(object sender);

        // Declare an event using the delegate
        public event DataBackEventHandler DataBack;
        public frmUserDetalis(int UserID)
        {
            _UserID = UserID;
            InitializeComponent();
        }

         private void frmUserDetalis_Load(object sender, EventArgs e)
        {
            ctrlUserCard1.LoadUserInfo(_UserID);
        }

        private void ctrlUserCard1_Load(object sender, EventArgs e)
        {

        }

        private void frmUserDetalis_FormClosed(object sender, FormClosedEventArgs e)
        {
            DataBack?.Invoke(this);
        }
    }
}
