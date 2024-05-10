using Bank_System_Business_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystemPresentationLayer
{
    public partial class frmPeople : Form
    {
        // Declare a delegate
        public delegate void DataBackEventHandler(object sender);

        // Declare an event using the delegate
        public event DataBackEventHandler DataBack;
       

        public frmPeople()
        {
            InitializeComponent();
        }
        private void GetAllPeople()
        {
            dgvAllPeople.DataSource = clsPerson.GetAllPeople();

        }
        private void RefreshData()
        {
            dgvAllPeople.DataSource = clsPerson.GetAllPeople();

        }
        private void frmPeople_Load(object sender, EventArgs e)
        {
            GetAllPeople();
            cbPeopleFilter.SelectedIndex = 0;
            lblNumberOfRecords.Text = dgvAllPeople.RowCount.ToString();
        }

        private void frmPeople_FormClosed(object sender, FormClosedEventArgs e)
        {
            DataBack?.Invoke(this);

        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if (dgvAllPeople == null)
                return;
            if (string.IsNullOrEmpty(txtFilter.Text) || string.IsNullOrWhiteSpace(txtFilter.Text))
            {
                GetAllPeople();
                return;
            }
            if (cbPeopleFilter.Text == "PersonID")
            {
               int.TryParse(txtFilter.Text, out int PersonID);
                dgvAllPeople.DataSource = clsPerson.SearchForPersonByPersonID(PersonID);
                return;
            }
            if (cbPeopleFilter.Text == "First Name")
            {
                dgvAllPeople.DataSource = clsPerson.SearchForPersonByFistName(txtFilter.Text);
                return;
            }
            if (cbPeopleFilter.Text == "Second Name")
            {
                dgvAllPeople.DataSource = clsPerson.SearchForPersonBySecondName(txtFilter.Text);
                return;
            }
            if (cbPeopleFilter.Text == "Third Name")
            {
                dgvAllPeople.DataSource = clsPerson.SearchForPersonByThirdName(txtFilter.Text);
                return;
            }
            if (cbPeopleFilter.Text == "Last Name")
            {
                dgvAllPeople.DataSource = clsPerson.SearchForPersonByLastName(txtFilter.Text);
                return;
            }
            if (cbPeopleFilter.Text == "Phone")
            {
                dgvAllPeople.DataSource = clsPerson.SearchForPersonByPhone(txtFilter.Text);
                return;
            }
            if (cbPeopleFilter.Text == "National No")
            {
                dgvAllPeople.DataSource = clsPerson.SearchForPersonByNationalNo(txtFilter.Text);
                return;
            }
           

        }

        private void cbPeopleFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPeopleFilter.Text == "Male")
            {
                dgvAllPeople.DataSource = clsPerson.GetAllMale();
                txtFilter.Visible = false;
                return;
            }
            if (cbPeopleFilter.Text == "Female")
            {
                dgvAllPeople.DataSource = clsPerson.GetAllFemale();
                txtFilter.Visible = false;
                return;
            }
            else
            {
                txtFilter.Visible = true;
                GetAllPeople();
                return;

            }
        }

        private void personDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPersonDetails frm = new frmPersonDetails((int)dgvAllPeople.CurrentRow.Cells[0].Value);
            frm.ShowDialog();

        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            frmAddEditPerson frm = new frmAddEditPerson(-1);
            frm.ShowDialog();
            RefreshData();
        }

        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditPerson frm = new frmAddEditPerson(-1);
            frm.ShowDialog();
            RefreshData();

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditPerson frm = new frmAddEditPerson((int)dgvAllPeople.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            RefreshData();

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dgvAllPeople.CurrentRow.Cells[0].Value;
            if (MessageBox.Show($"Are You Sure You Want To Delete Person With PersonID {PersonID} ?", "Warrning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                if (clsPerson.DeletePerson(PersonID))
                {
                    RefreshData();
                    MessageBox.Show($"Person With PeronID {PersonID} Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show($"Error:Cannot Delete This Person Cause Has Important Information In System", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
        }
    }
}
