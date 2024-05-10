using Bank_System_Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemBusinessLayer
{
    public class clsUser
    {
        private enum enMode { AddNew, Update };
        enMode _Mode = enMode.AddNew;


        public int PersonID { get; set; }
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Permission { get; set; }
        public bool IsActive { get; set; }

        public clsUser()
        {
            this.PersonID = -1;
            this.UserID = -1;
            this.UserName = "";
            this.Password = "";
            this.Permission = -1;
            this.IsActive = false;
            _Mode = enMode.AddNew;

        }

        protected clsUser(int PersonID, int UserID, string UserName, string Password
            , int Permission, bool IsActive)
        {
            this.PersonID = PersonID;
            this.UserName = UserName;
            this.Password = Password;
            this.IsActive = IsActive;
            this.Permission = Permission;
            this.UserID = UserID;

            _Mode = enMode.Update;

        }


        private bool _AddNewUser()
        {
            this.UserID = clsUserData.AddNewUser(this.PersonID, this.UserName, this.Password,this.Permission, this.IsActive);

            return (this.UserID != -1);
        }

        private bool _UpdateUser()
        {
            return (clsUserData.UpdateUser(this.UserID, this.PersonID, this.UserName, this.Password, this.Permission, this.IsActive));


        }

        public static clsUser Find(int UserID)
        {
            int PersonID = -1,Permission=-1;
            string UserName = "", Password = "";
            bool isActive = false;

            if (clsUserData.GetUserInfoByID(ref UserID, ref PersonID, ref UserName, ref Password, ref Permission,ref isActive))
                return new clsUser(PersonID, UserID, UserName, Password,Permission ,isActive);
            else
                return null;

        }

        public static clsUser Find(string UserName, string Password)
        {
            int PersonID = -1, UserID = -1,Permission=-1;
            bool isActive = false;

            if (clsUserData.GetUserInfoByUserNameAndPassword(ref UserID, ref PersonID, ref UserName, ref Password,ref Permission,ref isActive))
                return new clsUser(PersonID, UserID, UserName, Password,Permission, isActive);
            else
                return null;

        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewUser())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return _UpdateUser();

            }
            return false;
        }


        public static DataTable GetAllUsers()
        {
            return clsUserData.GetAllUsers();

        }
        public static bool DeleteUser(int UserID)
        {
            return clsUserData.DeleteUser(UserID);
        }

        public static bool IsUserExist(int UserID)
        {
            return clsUserData.IsUserExist(UserID);
        }

        public static bool IsUserExist(string UserName)
        {
            return clsUserData.IsUserExist(UserName);
        }
        public static bool IsUserExistByPersonID(int PersonID)
        {
            return clsUserData.IsUserExistByPersonID(PersonID);
        }
        public static bool IsUserActive(string UserName)
        {
            return clsUserData.IsUserActive(UserName);
        }

        public static DataTable SearchForUserByUserID(int UserID)
        {
            return clsUserData.SearchForUserByUserID(UserID);

        }
        public static DataTable SearchForUserByPersonID(int PersonID)
        {
            return clsUserData.SearchForUserByPersonID(PersonID);

        }

        public static DataTable SearchForUserByUserName(string UserName)
        {
            return clsUserData.SearchForUserByUserName(UserName);

        }

        public static DataTable GetActivedUsers()
        {
            return clsUserData.GetActivedUsers();

        }

        public static DataTable GetDeActivedUsers()
        {
            return clsUserData.GetDeActivedUsers();

        }

    }
}
