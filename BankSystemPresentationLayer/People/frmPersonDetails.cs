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
    public partial class frmPersonDetails : Form
    {
        int _PersonID;
        public frmPersonDetails(int PersonID)
        {
            _PersonID = PersonID;
            InitializeComponent();
        }

        private void frmPersonDetails_Load(object sender, EventArgs e)
        {
            ctrlPerson1.LoadPersonInfoWithID(_PersonID);
        }
    }
}
