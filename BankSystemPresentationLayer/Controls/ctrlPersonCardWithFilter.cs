using Bank_System_Business_Layer;
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
    public partial class ctrlPersonCardWithFilter : UserControl
    {
        clsPerson _Person;
        public ctrlPersonCardWithFilter()
        {
            InitializeComponent();
        }
        public int PersonID
        {
            get { return ctrlPerson1.PersonID; }
        }

        private void ctrlPersonCardWithFilter_Load(object sender, EventArgs e)
        {
            cbFilter.SelectedIndex = 0;
            btnAddPerson.Visible = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtFilter.Text == string.Empty)
                return;
            if (cbFilter.SelectedIndex == 0)
            {
                int.TryParse(txtFilter.Text, out int PersonID);
                ctrlPerson1.LoadPersonInfoWithID(PersonID);
                return;
            }
            else
            {
                _Person = clsPerson.Find(txtFilter.Text);
                if (_Person != null)
                {
                    ctrlPerson1.LoadPersonInfoWithID(_Person.PersonID);
                }
                else
                    MessageBox.Show($"Error : Person With National No[{txtFilter.Text}] is not Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }
        private void LoadPersonInfo(object sender, int PersonID)
        {
            //when close Form AddEditPerson Recive PersonID
            ctrlPerson1.LoadPersonInfoWithID(PersonID);
            txtFilter.Text = PersonID.ToString();
            cbFilter.SelectedIndex = 0;


        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            frmAddEditPerson frm = new frmAddEditPerson(-1);
            frm.DataBack += LoadPersonInfo;
            frm.ShowDialog();
        }

        private void btnSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(sender, e);
            }
            
        }

        private void txtFilter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(sender, e);
                txtFilter.Clear();
            }
            
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }
    }
}
