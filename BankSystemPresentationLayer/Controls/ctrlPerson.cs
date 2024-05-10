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
    public partial class ctrlPerson : UserControl
    {
        int _PersonID;
        clsPerson _Person;
        public ctrlPerson()
        {
            InitializeComponent();
        }
        public int PersonID
        {
            get
            {
                if (lblPersonID.Text == "[????]")
                    return -1;

                return Convert.ToInt32(lblPersonID.Text);
            }
        }
        public string lPersonID
        {
            get { return lblPersonID.Text; }
        }

        public void LoadPersonInfoWithID(int PersonID)
        {
            _PersonID = PersonID;
            if (_PersonID <= 0)
                return;

            _Person = clsPerson.Find(_PersonID);

            if (_Person != null)
            {
                lblPersonID.Text = _Person.PersonID.ToString();
                lblFullName.Text = _Person.FullName();
                lblNationalNo.Text = _Person.NationalNo;
                if (_Person.Gender == 0)
                    lblGendor.Text = "Female";
                else
                    lblGendor.Text = "Male";

                lblEmail.Text = _Person.Email;
                lblAddress.Text = _Person.Address;
                lblDateOfBirth.Text = _Person.DateOfBirth.ToString("dd/MM/yyyy");
                lblPhone.Text = _Person.Phone;
                lblCountry.Text = clsCountry.GetCountryName(_Person.CountryID);

                if (_Person.ImagePath == "")
                {
                    if (lblGendor.Text == "Female")
                        pbPersonImage.Image = Resources.person_woman;
                    else
                        pbPersonImage.Image = Resources.person_man;
                }
                else if (File.Exists(_Person.ImagePath))
                {
                    pbPersonImage.Load(_Person.ImagePath);
                }
                else
                    pbPersonImage.Image = Resources.anonymous;


            }
            else
                MessageBox.Show($"Error : Person With ID[{_PersonID}] is not Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
