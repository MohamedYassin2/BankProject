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
    public partial class frmDepositMain : Form
    {
        // Declare a delegate
        public delegate void DataBackEventHandler(object sender);

        // Declare an event using the delegate
        public event DataBackEventHandler DataBack;
        public frmDepositMain()
        {
            InitializeComponent();
        }

        private void _CustomizeDgvStyle()
        {
            if (dgvAllDeposits != null && dgvAllDeposits.Columns["DTransactionDate"] != null && dgvAllDeposits.Columns["FullName"] != null)
            {
                dgvAllDeposits.Columns["DTransactionDate"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";
                dgvAllDeposits.Columns["FullName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvAllDeposits.Columns["FullName"].FillWeight = 2;
                dgvAllDeposits.Columns["DTransactionDate"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvAllDeposits.Columns["DTransactionDate"].FillWeight = 2;
            }
               
        }
        private void _LoadAllDeposits()
        {
            dgvAllDeposits.DataSource = clsDeposit.GetAllDeposits();
            _CustomizeDgvStyle();
        }

        private DataTable _GetAllDeposits()
        {
            dgvAllDeposits.DataSource = clsDeposit.GetAllDeposits();
            DataTable dt = (DataTable)dgvAllDeposits.DataSource;
            _CustomizeDgvStyle();
            return dt;
            
        }
        private void frmDepositMain_Load(object sender, EventArgs e)
        {
            _LoadAllDeposits();
            cbDepositFilter.SelectedIndex = 0;
            dtpDateFilter.Format = DateTimePickerFormat.Custom;
            dtpDateFilter.CustomFormat = "yyyy-MM-dd";
            lblRecords.Text= dgvAllDeposits.RowCount.ToString();
        }

        private void frmDepositMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            DataBack?.Invoke(this);
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            txtFilter.Clear();
            frmDeposits frm = new frmDeposits();
            frm.ShowDialog();
            _LoadAllDeposits();

        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if (dgvAllDeposits == null)
                return;
            if (string.IsNullOrEmpty(txtFilter.Text) || string.IsNullOrWhiteSpace(txtFilter.Text))
            {
                _LoadAllDeposits();
                return;
            }
            if (cbDepositFilter.Text == "DTransactionID")
            {
                DataTable dataTable = _GetAllDeposits();
                if (dataTable != null)
                {
                    int.TryParse(txtFilter.Text, out int DTID);
                    // Example query: Get rows where the 'ColumnName' contains 'SearchTerm'
                    DataRow[] rows = dataTable.Select($"DTransactionID = {DTID} ");

                    // Create a new DataTable with the query results
                    DataTable filteredDataTable = dataTable.Clone(); // Clone the structure
                    foreach (DataRow row in rows)
                    {
                        filteredDataTable.ImportRow(row);
                    }

                    // Update the DataGridView with the filtered data
                    dgvAllDeposits.DataSource = filteredDataTable;
                    _CustomizeDgvStyle();
                }
                return;

            }
            if (cbDepositFilter.Text == "ClientID")
            {
                DataTable dataTable = _GetAllDeposits();
                if (dataTable != null)
                {
                    int.TryParse(txtFilter.Text, out int ClientID);

                    DataRow[] rows = dataTable.Select($"ClientID ={ClientID}");

                    // Create a new DataTable with the query results
                    DataTable filteredDataTable = dataTable.Clone(); // Clone the structure
                    foreach (DataRow row in rows)
                    {
                        filteredDataTable.ImportRow(row);
                    }

                    // Update the DataGridView with the filtered data
                    dgvAllDeposits.DataSource = filteredDataTable;
                    _CustomizeDgvStyle();
                }
                return;

            }

            if (cbDepositFilter.Text == "Amount")
            {
                DataTable dataTable = _GetAllDeposits();
                if (dataTable != null)
                {
                    int.TryParse(txtFilter.Text, out int Amount);

                    DataRow[] rows = dataTable.Select($"Amount ={Amount}");

                    // Create a new DataTable with the query results
                    DataTable filteredDataTable = dataTable.Clone(); // Clone the structure
                    foreach (DataRow row in rows)
                    {
                        filteredDataTable.ImportRow(row);
                    }

                    // Update the DataGridView with the filtered data
                    dgvAllDeposits.DataSource = filteredDataTable;
                    _CustomizeDgvStyle();
                }
                return;
            }
            if (cbDepositFilter.Text == "Name")
            {
                DataTable dataTable = _GetAllDeposits();
                if (dataTable != null)
                {
                    int.TryParse(txtFilter.Text, out int Amount);

                    DataRow[] rows = dataTable.Select($"FullName LIKE '{txtFilter.Text}%'");

                    DataTable filteredDataTable = dataTable.Clone(); 
                    foreach (DataRow row in rows)
                    {
                        filteredDataTable.ImportRow(row);
                    }

                    dgvAllDeposits.DataSource = filteredDataTable;
                    _CustomizeDgvStyle();
                }
                return;
            }
           
        }

        private void cbDepositFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDepositFilter.Text == "Date")
            {
                txtFilter.Visible = false;
                dtpDateFilter.Visible = true;
                dtpDateFilter_ValueChanged(sender, e);
                return;

            }
            txtFilter.Visible = true;
            dtpDateFilter.Visible = false;
            _LoadAllDeposits();
        }

        private void dtpDateFilter_ValueChanged(object sender, EventArgs e)
        {
            if (dgvAllDeposits == null)
                return;
            DataTable dataTable = _GetAllDeposits();
            if (dataTable != null)
            {
                DateTime filterDate = dtpDateFilter.Value.Date;  // Set your desired date
                var selectedRows = from row in dataTable.AsEnumerable()
                                   where ((DateTime)row["DTransactionDate"]).Date == filterDate.Date
                                   select row;

                DataTable filteredDataTable = dataTable.Clone();
                foreach (DataRow row in selectedRows)
                {
                    filteredDataTable.ImportRow(row);
                }

                dgvAllDeposits.DataSource = filteredDataTable;
                _CustomizeDgvStyle();
            }
            return;

        }

        private void makeDepositToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDeposits frm = new frmDeposits();
            frm.ShowDialog();
            _LoadAllDeposits();

        }

        private void deleteTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int TransactionID = (int)dgvAllDeposits.CurrentRow.Cells[0].Value;
            if (MessageBox.Show($"Are You Sure You Want To Delete Transaction With TransactionID {TransactionID} ?", "Warrning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                if (clsDeposit.DeleteDeposit(TransactionID))
                {
                    MessageBox.Show($"Transaction With TransactionID {TransactionID} Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show($"Error: User Cannot Delete, Contct Your Admin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            _LoadAllDeposits();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
