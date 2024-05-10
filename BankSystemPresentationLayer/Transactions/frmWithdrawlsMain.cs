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
    public partial class frmWithdrawlsMain : Form
    {
        // Declare a delegate
        public delegate void DataBackEventHandler(object sender);

        // Declare an event using the delegate
        public event DataBackEventHandler DataBack;
        public frmWithdrawlsMain()
        {
            InitializeComponent();
        }
        private void _CustomizeDgvStyle()
        {
            if (dgvAllWithdrawls != null && dgvAllWithdrawls.Columns["WTransactionDate"] != null && dgvAllWithdrawls.Columns["FullName"] != null)

            {
                dgvAllWithdrawls.Columns["WTransactionDate"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";
                dgvAllWithdrawls.Columns["FullName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvAllWithdrawls.Columns["FullName"].FillWeight = 2;
                dgvAllWithdrawls.Columns["WTransactionDate"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvAllWithdrawls.Columns["WTransactionDate"].FillWeight = 2;
            }
            else
            {
                return;
            }

        }
            
        private void _LoadAllWithdrawls()
        {
            dgvAllWithdrawls.DataSource = clsWithdrawl.GetAllWithdrawl();
            _CustomizeDgvStyle();
        }

        private DataTable _GetAllWithdrawls()
        {
            dgvAllWithdrawls.DataSource = clsWithdrawl.GetAllWithdrawl();
            DataTable dt = (DataTable)dgvAllWithdrawls.DataSource;
            _CustomizeDgvStyle();
            return dt;

        }
        private void frmWithdrawlsMain_Load(object sender, EventArgs e)
        {
            _LoadAllWithdrawls();
            cbWithdrawlFilter.SelectedIndex = 0;
            dtpDateFilter.Format = DateTimePickerFormat.Custom;
            dtpDateFilter.CustomFormat = "yyyy-MM-dd";
            lblRecords.Text = dgvAllWithdrawls.RowCount.ToString();
        }

        private void frmWithdrawlsMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            DataBack?.Invoke(this);
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if (dgvAllWithdrawls == null)
                return;
            if (string.IsNullOrEmpty(txtFilter.Text) || string.IsNullOrWhiteSpace(txtFilter.Text))
            {
                _LoadAllWithdrawls();
                return;
            }
            if (cbWithdrawlFilter.Text == "WTransactionID")
            {
                DataTable dataTable = _GetAllWithdrawls();
                if (dataTable != null)
                {
                    int.TryParse(txtFilter.Text, out int WTransactionID);
                    // Example query: Get rows where the 'ColumnName' contains 'SearchTerm'
                    DataRow[] rows = dataTable.Select($"WTransactionID = {WTransactionID} ");

                    // Create a new DataTable with the query results
                    DataTable filteredDataTable = dataTable.Clone(); // Clone the structure
                    foreach (DataRow row in rows)
                    {
                        filteredDataTable.ImportRow(row);
                    }

                    // Update the DataGridView with the filtered data
                    dgvAllWithdrawls.DataSource = filteredDataTable;
                    _CustomizeDgvStyle();
                }
                return;

            }
            if (cbWithdrawlFilter.Text == "ClientID")
            {
                DataTable dataTable = _GetAllWithdrawls();
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
                    dgvAllWithdrawls.DataSource = filteredDataTable;
                    _CustomizeDgvStyle();
                }
                return;

            }

            if (cbWithdrawlFilter.Text == "Amount")
            {
                DataTable dataTable = _GetAllWithdrawls();
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
                    dgvAllWithdrawls.DataSource = filteredDataTable;
                    _CustomizeDgvStyle();
                }
                return;
            }
            if (cbWithdrawlFilter.Text == "Name")
            {
                DataTable dataTable = _GetAllWithdrawls();
                if (dataTable != null)
                {
                    int.TryParse(txtFilter.Text, out int Amount);

                    DataRow[] rows = dataTable.Select($"FullName LIKE '{txtFilter.Text}%'");

                    DataTable filteredDataTable = dataTable.Clone();
                    foreach (DataRow row in rows)
                    {
                        filteredDataTable.ImportRow(row);
                    }

                    dgvAllWithdrawls.DataSource = filteredDataTable;
                    _CustomizeDgvStyle();
                }
                return;
            }
        }

        private void cbWithdrawlFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbWithdrawlFilter.Text == "Date")
            {
                txtFilter.Visible = false;
                dtpDateFilter.Visible = true;
                dtpDateFilter_ValueChanged(sender, e);
                return;

            }
            txtFilter.Visible = true;
            dtpDateFilter.Visible = false;
            _LoadAllWithdrawls();
        }

        private void dtpDateFilter_ValueChanged(object sender, EventArgs e)
        {
            if (dgvAllWithdrawls == null)
                return;
            DataTable dataTable = _GetAllWithdrawls();
            if (dataTable != null)
            {
                DateTime filterDate = dtpDateFilter.Value.Date;  // Set your desired date
                var selectedRows = from row in dataTable.AsEnumerable()
                                   where ((DateTime)row["WTransactionDate"]).Date == filterDate.Date
                                   select row;

                DataTable filteredDataTable = dataTable.Clone();
                foreach (DataRow row in selectedRows)
                {
                    filteredDataTable.ImportRow(row);
                }

                dgvAllWithdrawls.DataSource = filteredDataTable;
                _CustomizeDgvStyle();
            }
            return;
        }

        private void btnAddNewWithdrawl_Click(object sender, EventArgs e)
        {
            frmWithdraw frm = new frmWithdraw();
            frm.ShowDialog();
            _LoadAllWithdrawls();
        }

        private void deleteTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int TransactionID = (int)dgvAllWithdrawls.CurrentRow.Cells[0].Value;
            if (MessageBox.Show($"Are You Sure You Want To Delete Transaction With TransactionID {TransactionID} ?", "Warrning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                if (clsWithdrawl.DeleteWithdrawl(TransactionID))
                {
                    MessageBox.Show($"Transaction With TransactionID {TransactionID} Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show($"Error: User Cannot Delete, Contct Your Admin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            _LoadAllWithdrawls();
        }
    }
}
