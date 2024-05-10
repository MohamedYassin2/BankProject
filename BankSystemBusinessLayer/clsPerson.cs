using Bank_System_Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Bank_System_Business_Layer
{
    public class clsPerson
    {
        private enum enMode { AddNew, Update };
        enMode _Mode = enMode.AddNew;
        public int PersonID { get; set; }
        public int CountryID { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public string FullName()
        {
            return FirstName + " " + SecondName + " " + ThirdName + " " + LastName;
        }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string ImagePath { get; set; }
        public string Address { get; set; }
        public string NationalNo { get; set; }
        public byte Gender { get; set; }

        public clsPerson()
        {

            this.PersonID = -1;
            this.FirstName = "";
            this.SecondName = "";
            this.ThirdName = "";
            this.LastName = "";
            this.DateOfBirth = DateTime.Now;
            this.Gender = 1;
            this.Address = "";
            this.Phone = "";
            this.Email = "";
            this.ImagePath = "";
            this.CountryID = -1;
            this.NationalNo = "";
            _Mode = enMode.AddNew;
        }

        protected clsPerson(int personID, string nationalNo, string firstName,
           string secondName, string thirdName, string lastName, DateTime dateOfBirth,
           byte gender, string address, string phone, string email, string imagePath,
           int CountryID)
        {

            this.PersonID = personID;
            this.NationalNo = nationalNo;
            this.FirstName = firstName;
            this.SecondName = secondName;
            this.ThirdName = thirdName;
            this.LastName = lastName;
            this.DateOfBirth = dateOfBirth;
            this.Gender = gender;
            this.Address = address;
            this.Phone = phone;
            this.Email = email;
            this.CountryID = CountryID;
            this.ImagePath = imagePath;
            _Mode = enMode.Update;

        }



        public static clsPerson Find(int PersonID)
        {
            string NationalNo = "", FirstName = "", secondName = "", thirdName = "", lastName = "",
                address = "", phone = "", email = "", imagePath = "";
            DateTime dateOfBirth = DateTime.Now;
            byte gender = 1; int CountryID = 0;

            if (clsPersonData.GetPersonInfoByID(ref PersonID, ref CountryID, ref  FirstName, ref secondName
            , ref  thirdName, ref  lastName, ref  phone, ref  email, ref  dateOfBirth
            , ref  imagePath, ref  address, ref  NationalNo
            , ref  gender))
            {
                return new clsPerson(PersonID, NationalNo, FirstName,
                secondName, thirdName, lastName, dateOfBirth,
                gender, address, phone, email, imagePath,
                CountryID);
            }
               
            else
                return null;

        }

        public static clsPerson Find(string NationalNo)
        {
            int PersonID = -1;
           string FirstName = "", secondName = "", thirdName = "", lastName = "",
                address = "", phone = "", email = "", imagePath = "";
            DateTime dateOfBirth = DateTime.Now;
            byte gender = 1; int CountryID = 0;

            if (clsPersonData.GetPersonInfoByNationalNo(ref PersonID, ref  CountryID, ref  FirstName, ref  secondName
            , ref  thirdName, ref  lastName, ref  phone, ref  email, ref  dateOfBirth
            , ref  imagePath, ref  address, ref  NationalNo
            , ref  gender))
            {
                return new clsPerson(PersonID, NationalNo, FirstName,
                secondName, thirdName, lastName, dateOfBirth,
                gender, address, phone, email, imagePath,
                CountryID);
            }


            else
                return null;

        }

        private bool _AddNewPerson()
        {
            this.PersonID = clsPersonData.AddNewPerson(this.CountryID, this.FirstName, this.SecondName
            , this.ThirdName, this.LastName, this.Phone, this.Email, this.DateOfBirth
            , this.ImagePath, this.Address, this.NationalNo
            , this.Gender);

            return (this.PersonID != -1);
        }

        private bool _UpdatePerson()
        {
            return
                (clsPersonData.UpdatePerson(this.PersonID,this.CountryID, this.FirstName, this.SecondName
            , this.ThirdName, this.LastName, this.Phone, this.Email, this.DateOfBirth
            , this.ImagePath, this.Address, this.NationalNo
            , this.Gender));

        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPerson())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return _UpdatePerson();

            }
            return false;
        }

        public static DataTable GetAllPeople()
        {
            return clsPersonData.GetAllPeople();

        }

        public static bool DeletePerson(int PersonID)
        {
            return clsPersonData.DeletePerson(PersonID);
        }
        public static bool IsPersonExist(int PersonID)
        {
            return clsPersonData.IsPersonExist(PersonID);
        }

        public static bool IsPersonExist(string NationalNo)
        {
            return clsPersonData.IsPersonExist(NationalNo);
        }

        public static DataTable SearchForPersonByFistName(string FirstName)
        {
            return clsPersonData.SearchForPersonByFistName(FirstName);

        }

        public static DataTable SearchForPersonBySecondName(string SecondName)
        {
            return clsPersonData.SearchForPersonBySecondName(SecondName);

        }

        public static DataTable SearchForPersonByThirdName(string ThirdName)
        {
            return clsPersonData.SearchForPersonByThirdName(ThirdName);

        }
        public static DataTable SearchForPersonByLastName(string LastName)
        {
            return clsPersonData.SearchForPersonByLastName(LastName);

        }

        public static DataTable SearchForPersonByNationalNo(string NationalNo)
        {
            return clsPersonData.SearchForPersonByNationalNo(NationalNo);

        }

        public static DataTable SearchForPersonByPhone(string Phone)
        {
            return clsPersonData.SearchForPersonByPhone(Phone);

        }

        public static DataTable SearchForPersonByPersonID(int PersonID)
        {
            return clsPersonData.SearchForPersonByPersonID(PersonID);

        }


        public static DataTable GetAllMale()
        {
            return clsPersonData.GetAllMale();

        }

        public static DataTable GetAllFemale()
        {
            return clsPersonData.GetAllFemale();

        }


    }
}