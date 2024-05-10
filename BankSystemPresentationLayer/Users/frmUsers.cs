using Bank_System_Business_Layer;
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
    public partial class frmUsers : Form
    {
        // Declare a delegate
        public delegate void DataBackEventHandler(object sender);

        // Declare an event using the delegate
        public event DataBackEventHandler DataBack;


        public frmUsers()
        {
            InitializeComponent();
        }

        private void Refresh()
        {
            dgvAllUsers.DataSource = clsUser.GetAllUsers();

        }
        private void GetAllUsers ()
        {
            dgvAllUsers.DataSource = clsUser.GetAllUsers();
            dgvAllUsers.Columns[2].Width = 200;
        }

        private void IncreaseFullNameColumn()
        {
            lblRecords.Text = dgvAllUsers.RowCount.ToString();

        }
        private void frmUsers_Load(object sender, EventArgs e)
        {
            GetAllUsers();
            IncreaseFullNameColumn();
            cbUserFilter.SelectedIndex = 0;
        }

        private void frmUsers_FormClosed(object sender, FormClosedEventArgs e)
        {
            DataBack?.Invoke(this);
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if (dgvAllUsers == null)
                return;
            if (string.IsNullOrEmpty(txtFilter.Text) || string.IsNullOrWhiteSpace(txtFilter.Text))
            {
                GetAllUsers();
                return;
            }
            if (cbUserFilter.Text == "UserID")
            {
                int.TryParse(txtFilter.Text, out int UserID);
                dgvAllUsers.DataSource = clsUser.SearchForUserByUserID(UserID);
                return;
            }
            if (cbUserFilter.Text == "PersonID")
            {
                int.TryParse(txtFilter.Text, out int PersonID);
                dgvAllUsers.DataSource = clsUser.SearchForUserByPersonID(PersonID);
                return;
            }
            if (cbUserFilter.Text == "UserName")
            {
              
                dgvAllUsers.DataSource = clsUser.SearchForUserByUserName(txtFilter.Text);
                return;
            }

        }

        private void cbUserFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbUserFilter.Text == "Actived Users")
            {
                dgvAllUsers.DataSource = clsUser.GetActivedUsers();
                return;
            }
            if (cbUserFilter.Text == "DeActived Users")
            {
                dgvAllUsers.DataSource = clsUser.GetDeActivedUsers();
                return;
            }
            Refresh();
        }

        private void userDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserDetalis frm = new frmUserDetalis((int)dgvAllUsers.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            
        }
        
        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            frmAddEditUser frm2 = new frmAddEditUser(-1);
            frm2.ShowDialog();
            Refresh();
            
        }

        private void editUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditUser frm = new frmAddEditUser((int)dgvAllUsers.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            Refresh();
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditUser frm = new frmAddEditUser(-1);
            frm.Show();
            Refresh();
        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = (int)dgvAllUsers.CurrentRow.Cells[0].Value;
            if (MessageBox.Show($"Are You Sure You Want To Delete User With UserID {UserID} ?", "Warrning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                if (clsUser.DeleteUser(UserID))
                {
                    MessageBox.Show($"User With UserID {UserID} Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show($"Error: User Cannot Delete, Contct Your Admin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            Refresh();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
