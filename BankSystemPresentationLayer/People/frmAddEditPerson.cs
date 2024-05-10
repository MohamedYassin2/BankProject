using Bank_System_Business_Layer;
using BankSystemBusinessLayer;
using BankSystemPresentationLayer.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystemPresentationLayer
{
    public partial class frmAddEditPerson : Form
    {
        // Declare a delegate
        public delegate void DataBackEventHandler(object sender, int PersonID);

        // Declare an event using the delegate
        public event DataBackEventHandler DataBack;

        bool IsPersonSaved = false;

        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;

        int _PersonID;
        clsPerson _Person;
        public frmAddEditPerson(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
            if (_PersonID == -1)
                _Mode = enMode.AddNew;
            else
                _Mode = enMode.Update;
        }
        private void _LoadCountriesInComboBox()
        {
            DataTable dtCountries = clsCountry.GetAllCountries();

            foreach (DataRow row in dtCountries.Rows)
            {

                cbCountries.Items.Add(row["CountryName"]);

            }
        }

        private void _LoadData()
        {
            _LoadCountriesInComboBox();
            cbCountries.SelectedIndex = 50;
            if (_Mode == enMode.AddNew)
            {
                lblMode.Text = "Add New Person";
                _Person = new clsPerson();
                this.Text = "Add New Person";
                return;
            }
            //if we in update mode We Load Info
            _Person = clsPerson.Find(_PersonID);


            if (_Person == null)
            {
                MessageBox.Show("This form will be closed because No Person with ID = " + _PersonID);
                this.Close();

                return;
            }


            this.Text = "Edit Person";
            lblMode.Text = "Edit Person";
            lblPersonID.Text = _PersonID.ToString();
            txtFirstName.Text = _Person.FirstName;
            txtSecondName.Text = _Person.SecondName;
            txtThirdName.Text = _Person.ThirdName;
            txtLastName.Text = _Person.LastName;
            txtNationalNo.Text = _Person.NationalNo;
            dtpDateOfBirth.Value = _Person.DateOfBirth;
            txtPhone.Text = _Person.Phone;
            txtEmail.Text = _Person.Email;
            txtAddress.Text = _Person.Address;

            if (_Person.Gender == 1)
                rbMale.Checked = true;
            else
                rbFemale.Checked = true;

            if (_Person.ImagePath != "")
            {
                if (File.Exists(_Person.ImagePath))
                {
                    pbImage.Load(_Person.ImagePath);
                    llRemoveImage.Visible = true;
                    llSetImage.Visible = false;
                }
            }
            else
            {
                if (rbMale.Checked)
                    pbImage.Image = Resources.person_man;
                else
                    pbImage.Image = Resources.person_woman;
                llSetImage.Visible = true;
                llRemoveImage.Visible = false;
            }
            cbCountries.SelectedIndex = cbCountries.FindString(clsCountry.GetCountryName(_Person.CountryID));

        }
        private void frmAddNewPerson_Load(object sender, EventArgs e)
        {
            _LoadData();

        }

        private void llRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (rbMale.Checked)
                pbImage.Image = Resources.person_man;
            else
                pbImage.Image = Resources.person_woman;
            pbImage.ImageLocation = null;
            llRemoveImage.Visible = false;
            llSetImage.Visible = true;
        }

        private void llSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Process the selected file
                string selectedFilePath = openFileDialog1.FileName;
                //MessageBox.Show("Selected Image is:" + selectedFilePath);
                llRemoveImage.Visible = true;
                llSetImage.Visible = false;

                pbImage.Load(selectedFilePath);

            }
        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            if (llRemoveImage.Visible == true)
                return;

            pbImage.Image = Resources.person_man;
        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (llRemoveImage.Visible == true)
                return;

            pbImage.Image = Resources.person_woman;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
               string.IsNullOrWhiteSpace(txtSecondName.Text) ||
               string.IsNullOrWhiteSpace(txtLastName.Text) ||
               string.IsNullOrWhiteSpace(txtPhone.Text) ||
               string.IsNullOrWhiteSpace(txtAddress.Text) ||
               string.IsNullOrWhiteSpace(txtNationalNo.Text)
               )
            {
                MessageBox.Show("Please Fill All Fileds", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_Mode == enMode.AddNew)
            {
                if (clsPerson.IsPersonExist(txtNationalNo.Text))
                {
                    MessageBox.Show("National No Is Already Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            int CountryID = clsCountry.Find(cbCountries.Text).CountryID;

            _Person.FirstName = txtFirstName.Text;
            _Person.SecondName = txtSecondName.Text;
            _Person.ThirdName = txtThirdName.Text;
            _Person.LastName = txtLastName.Text;
            _Person.NationalNo = txtNationalNo.Text;
            _Person.Phone = txtPhone.Text;
            _Person.Address = txtAddress.Text;
            _Person.Email = txtEmail.Text;
            _Person.CountryID = CountryID;

            if (pbImage.ImageLocation != null)
                _Person.ImagePath = pbImage.ImageLocation;
            else
                _Person.ImagePath = "";

            if (rbFemale.Checked)
                _Person.Gender = 0;
            else
                _Person.Gender = 1;

            if (_Person.Save())
            {
                MessageBox.Show("Data Saved Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _Mode = enMode.Update;
                lblMode.Text = "Edit Person";
                lblPersonID.Text = _Person.PersonID.ToString();
                IsPersonSaved = true;
            }
            else
            {
                MessageBox.Show("Error: Data Is not Saved.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                IsPersonSaved = false;

            }

        }

        private void frmAddEditPerson_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (IsPersonSaved)
            {
                DataBack?.Invoke(this, _Person.PersonID);
                this.Close();

            }
            else
                this.Close();   
        }

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                e.Cancel = true;
                txtFirstName.Focus();
                errorProvider1.SetError(txtFirstName, "First Name Should Have Value!");
                return;
            }
            if (txtFirstName.Text.Length < 3)
            {
                e.Cancel = true;
                txtFirstName.Focus();
                errorProvider1.SetError(txtFirstName, "First Name Must Be More Than 3 Letters!");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtFirstName, "");

            }
        }

        private void txtSecondName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSecondName.Text))
            {
                e.Cancel = true;
                txtSecondName.Focus();
                errorProvider1.SetError(txtSecondName, "Second Name Should Have Value!");
                return;
            }
            if (txtSecondName.Text.Length < 3)
            {
                e.Cancel = true;
                txtSecondName.Focus();
                errorProvider1.SetError(txtSecondName, "Second Name Must Be More Than 3 Letters!");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtSecondName, "");

            }
        }

        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                e.Cancel = true;
                txtLastName.Focus();
                errorProvider1.SetError(txtLastName, "Last Name Should Have Value!");
                return;
            }
            if (txtLastName.Text.Length < 3)
            {
                e.Cancel = true;
                txtLastName.Focus();
                errorProvider1.SetError(txtLastName, "Last Name Must Be More Than 3 Letters!");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtLastName, "");

            }
        }

        private void txtThirdName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtThirdName.Text))
            {
                e.Cancel = true;
                txtThirdName.Focus();
                errorProvider1.SetError(txtThirdName, "Third Name Should Have Value!");
                return;
            }
            if (txtThirdName.Text.Length < 3)
            {
                e.Cancel = true;
                txtThirdName.Focus();
                errorProvider1.SetError(txtThirdName, "Last Name Must Be More Than 3 Letters!");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtThirdName, "");

            }
        }

        private void txtNationalNo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNationalNo.Text))
            {
                e.Cancel = true;
                txtNationalNo.Focus();
                errorProvider1.SetError(txtNationalNo, "National No Should Have Value!");
                return;
            }
            if (txtNationalNo.Text.Length < 10)
            {
                e.Cancel = true;
                txtNationalNo.Focus();
                errorProvider1.SetError(txtNationalNo, "National No Must be 10 Number or more than 10!");
                return;
            }
            if (clsPerson.IsPersonExist(txtNationalNo.Text))
            {
                e.Cancel = true;
                txtNationalNo.Focus();
                errorProvider1.SetError(txtNationalNo, "National Number Is Already Exist");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtNationalNo, "");

            }
        }

        private void dtpDateOfBirth_Validating(object sender, CancelEventArgs e)
        {
            if (dtpDateOfBirth.Value > DateTime.Now)
            {
                e.Cancel = true;
                dtpDateOfBirth.Focus();
                errorProvider1.SetError(dtpDateOfBirth, "Enter Valid Date Of Birth");

            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(dtpDateOfBirth, "");

            }
        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                e.Cancel = true;
                txtPhone.Focus();
                errorProvider1.SetError(txtPhone, "Phone Should Have Value!");
                return;
            }
            if (txtPhone.Text.Length < 11)
            {
                e.Cancel = true;
                txtPhone.Focus();
                errorProvider1.SetError(txtPhone, "Enter Valid Phone Number");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtPhone, "");

            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (txtEmail.Text != string.Empty)
            {
                if (!txtEmail.Text.Contains("@") || !txtEmail.Text.Contains("."))
                {
                    e.Cancel = true;
                    txtEmail.Focus();
                    errorProvider1.SetError(txtEmail, "Enter Valid Email");
                    return;
                }
            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtEmail, "");

            }
        }

        private void txtAddress_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                e.Cancel = true;
                txtAddress.Focus();
                errorProvider1.SetError(txtAddress, "Address Should Have Value!");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtAddress, "");

            }
        }
    }
}
