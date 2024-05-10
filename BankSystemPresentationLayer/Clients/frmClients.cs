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
    public partial class frmClients : Form
    {
        // Declare a delegate
        public delegate void DataBackEventHandler(object sender);

        // Declare an event using the delegate
        public event DataBackEventHandler DataBack;

        
        public frmClients()
        {
            InitializeComponent();
        }

        private void LoadAllClients()
        {
            dgvAllClients.DataSource= clsClient.GetAllClients();
          
                
        }
        private void frmClients_Load(object sender, EventArgs e)
        {
            LoadAllClients();
            cbClientFilter.SelectedIndex = 0;
            lblRecords.Text=dgvAllClients.RowCount.ToString();
        }

        private void frmClients_FormClosed(object sender, FormClosedEventArgs e)
        {
            DataBack?.Invoke(this);
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if (dgvAllClients == null)
                return;
            if (string.IsNullOrEmpty(txtFilter.Text) || string.IsNullOrWhiteSpace(txtFilter.Text))
            {
                LoadAllClients();
                return;
            }
            if (cbClientFilter.Text == "ClientID")
            {
                int.TryParse(txtFilter.Text, out int ClientID);
                dgvAllClients.DataSource = clsClient.SearchForClientByClientID(ClientID);
                return;
            }
            if (cbClientFilter.Text == "PersonID")
            {
                int.TryParse(txtFilter.Text, out int PersonID);
                dgvAllClients.DataSource = clsClient.SearchForClientByPersonID(PersonID);
                return;
            }

            if (cbClientFilter.Text == "Name")
            {
               
                dgvAllClients.DataSource = clsClient.SearchForClientByName(txtFilter.Text);
                return;
            }
            if (cbClientFilter.Text == "Account Number")
            {

                dgvAllClients.DataSource = clsClient.SearchForClientByAccountNumber(txtFilter.Text);
                return;
            }

            if (cbClientFilter.Text == "Account Type")
            {

                dgvAllClients.DataSource = clsClient.SearchForClientByAccountType(txtFilter.Text);
                return;
            }
        }

        private void btnAddNewClient_Click(object sender, EventArgs e)
        {
            frmAddEditClient frm = new frmAddEditClient(-1);
            frm.ShowDialog();
            LoadAllClients();
        }

        private void clientDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientDetails frm = new frmClientDetails((int)dgvAllClients.CurrentRow.Cells[0].Value);
            frm.ShowDialog();

        }

        private void addNewClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditClient frm = new frmAddEditClient(-1);
            frm.ShowDialog();
            LoadAllClients();

        }

        private void deleteClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ClientID = (int)dgvAllClients.CurrentRow.Cells[0].Value;
            if (MessageBox.Show($"Are You Sure You Want To Delete Client With ClientID {ClientID} ?", "Warrning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                if (clsClient.DeleteClient(ClientID))
                {
                    MessageBox.Show($"Client With ClientID {ClientID} Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show($"Error: Client Cannot Delete, Contct Your Admin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            LoadAllClients();
        }

        private void cbClientFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFilter.Text) || string.IsNullOrWhiteSpace(txtFilter.Text))
            {
                LoadAllClients();
                return;
            }
            if (cbClientFilter.Text == "ClientID")
            {
                int.TryParse(txtFilter.Text, out int ClientID);
                dgvAllClients.DataSource = clsClient.SearchForClientByClientID(ClientID);
                return;
            }
            if (cbClientFilter.Text == "PersonID")
            {
                int.TryParse(txtFilter.Text, out int PersonID);
                dgvAllClients.DataSource = clsClient.SearchForClientByPersonID(PersonID);
                return;
            }

            if (cbClientFilter.Text == "Name")
            {

                dgvAllClients.DataSource = clsClient.SearchForClientByName(txtFilter.Text);
                return;
            }
            if (cbClientFilter.Text == "Account Number")
            {

                dgvAllClients.DataSource = clsClient.SearchForClientByAccountNumber(txtFilter.Text);
                return;
            }

            if (cbClientFilter.Text == "Account Type")
            {

                dgvAllClients.DataSource = clsClient.SearchForClientByAccountType(txtFilter.Text);
                return;
            }
        }

        private void editClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditClient frm = new frmAddEditClient((int)dgvAllClients.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            LoadAllClients();
        }
    }
}
