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
    public partial class frmTransfersMain : Form
    {
        // Declare a delegate
        public delegate void DataBackEventHandler(object sender);

        // Declare an event using the delegate
        public event DataBackEventHandler DataBack;
        public frmTransfersMain()
        {
            InitializeComponent();
        }
        private void _CustomizeDgvStyle()
        {
            if (dgvAllTransfers != null && dgvAllTransfers.Columns["TTransactionDate"] != null && dgvAllTransfers.Columns["SenderFullName"] != null
                && dgvAllTransfers.Columns["ReceiverFullName"] != null)
            {
                dgvAllTransfers.Columns["TTransactionDate"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";
                dgvAllTransfers.Columns["SenderFullName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvAllTransfers.Columns["SenderFullName"].FillWeight = 2;
                dgvAllTransfers.Columns["ReceiverFullName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvAllTransfers.Columns["ReceiverFullName"].FillWeight = 2;
                dgvAllTransfers.Columns["TTransactionDate"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvAllTransfers.Columns["TTransactionDate"].FillWeight = 2;
            }

        }

        private void _LoadAllTransfers()
        {
            dgvAllTransfers.DataSource = clsTransfer.GetAllTransfers();
            _CustomizeDgvStyle();
        }

        private DataTable _GetAllTransfers()
        {
            dgvAllTransfers.DataSource = clsTransfer.GetAllTransfers();
            DataTable dt = (DataTable)dgvAllTransfers.DataSource;
            _CustomizeDgvStyle();
            return dt;

        }

        private void frmTransfers_Load(object sender, EventArgs e)
        {
            _LoadAllTransfers();
            cbTransferFilter.SelectedIndex = 0;
            dtpDateFilter.Format = DateTimePickerFormat.Custom;
            dtpDateFilter.CustomFormat = "yyyy-MM-dd";
            lblRecords.Text = dgvAllTransfers.RowCount.ToString();
        }

        private void frmTransfers_FormClosed(object sender, FormClosedEventArgs e)
        {
            DataBack?.Invoke(this);
        }

        private void btnAddNewTransfer_Click(object sender, EventArgs e)
        {
            txtFilter.Clear();
            frmTransfer frm = new frmTransfer();
            frm.ShowDialog();
            _LoadAllTransfers();
        }

        private void SearchForintThingInDGV(TextBox txtSearch,string SearchForWhat)
        {
            DataTable dataTable = _GetAllTransfers();
            if (dataTable != null)
            {
                int.TryParse(txtSearch.Text, out int DesiredValueForSearch);

                DataRow[] rows = dataTable.Select($"{SearchForWhat} ={DesiredValueForSearch}");

                // Create a new DataTable with the query results
                DataTable filteredDataTable = dataTable.Clone(); // Clone the structure
                foreach (DataRow row in rows)
                {
                    filteredDataTable.ImportRow(row);
                }

                // Update the DataGridView with the filtered data
                dgvAllTransfers.DataSource = filteredDataTable;
                _CustomizeDgvStyle();
            }
            return;
        }

        private void SearchForStringThingInDGV(TextBox txtSearch, string SearchForWhat)
        {
            DataTable dataTable = _GetAllTransfers();
            if (dataTable != null)
            {


                DataRow[] rows = dataTable.Select($"{SearchForWhat} LIKE '{txtSearch.Text}%'");

                DataTable filteredDataTable = dataTable.Clone();
                foreach (DataRow row in rows)
                {
                    filteredDataTable.ImportRow(row);
                }

                dgvAllTransfers.DataSource = filteredDataTable;
                _CustomizeDgvStyle();
            }
            return;
        }
        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFilter.Text) || string.IsNullOrWhiteSpace(txtFilter.Text))
            {
                _LoadAllTransfers();
                return;
            }
            if (dgvAllTransfers == null)
                return;
            if (cbTransferFilter.Text == "TTransactionID")
            {
                SearchForintThingInDGV(txtFilter, "TTransactionID");

            }
            if (cbTransferFilter.Text == "Sender ClientID")
            {
                SearchForintThingInDGV(txtFilter, "SenderClientID");


            }

            if (cbTransferFilter.Text == "Reciver ClientID")
            {
                SearchForintThingInDGV(txtFilter, "ReciverClientID");

            }
            if (cbTransferFilter.Text == "Sender Name")
            {
                SearchForStringThingInDGV(txtFilter, "SenderFullName");
            }
            if (cbTransferFilter.Text == "Reciver Name")
            {
                SearchForStringThingInDGV(txtFilter, "ReceiverFullName");

            }

            if (cbTransferFilter.Text == "Amount")
            {
                SearchForintThingInDGV(txtFilter, "Amount");
            }


        }

        private void cbTransferFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTransferFilter.Text == "Date")
            {
                txtFilter.Visible = false;
                dtpDateFilter.Visible = true;
                dtpDateFilter_ValueChanged(sender, e);
                return;

            }
            txtFilter.Visible = true;
            dtpDateFilter.Visible = false;
            _LoadAllTransfers();
        }

        private void dtpDateFilter_ValueChanged(object sender, EventArgs e)
        {
            if (dgvAllTransfers == null)
                return;
            DataTable dataTable = _GetAllTransfers();
            if (dataTable != null)
            {
                DateTime filterDate = dtpDateFilter.Value.Date;  // Set your desired date
                var selectedRows = from row in dataTable.AsEnumerable()
                                   where ((DateTime)row["TTransactionDate"]).Date == filterDate.Date
                                   select row;

                DataTable filteredDataTable = dataTable.Clone();
                foreach (DataRow row in selectedRows)
                {
                    filteredDataTable.ImportRow(row);
                }

                dgvAllTransfers.DataSource = filteredDataTable;
                _CustomizeDgvStyle();
            }
            return;
        }

        private void deleteTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int TransactionID = (int)dgvAllTransfers.CurrentRow.Cells[0].Value;
            if (MessageBox.Show($"Are You Sure You Want To Delete Transaction With TransactionID {TransactionID} ?", "Warrning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                if (clsTransfer.DeleteTransfer(TransactionID))
                {
                    MessageBox.Show($"Transaction With TransactionID {TransactionID} Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show($"Error: User Cannot Delete, Contct Your Admin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            _LoadAllTransfers();
        }
    }
}
