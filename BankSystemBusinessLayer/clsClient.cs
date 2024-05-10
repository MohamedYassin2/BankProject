using Bank_System_Data_Access_Layer;
using BankSystemDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemBusinessLayer
{
    public class clsClient
    {
        private enum enMode { AddNew, Update };
        enMode _Mode = enMode.AddNew;

        public int PersonID { get; set; }
        public int ClientID { get; set; }
        public string AccountNumber { get; set; }
        public string PIN { get; set; }
        public int AccountBalance { get; set; }
        public string AccountType { get; set; }

        public clsClient()
        {
            this.PersonID = -1;
            this.ClientID = -1;
            this.AccountNumber = "";
            this.PIN = "";
            this.AccountBalance = -1;
            this.AccountType = "";
            _Mode = enMode.AddNew;

        }

        protected clsClient(int ClientID, int PersonID, string AccountNumber, string PIN
           , int AccountBalance, string AccountType)
        {
            this.ClientID = ClientID;
            this.PersonID = PersonID;
            this.AccountNumber = AccountNumber;
            this.PIN = PIN;
            this.AccountBalance = AccountBalance;
            this.AccountType = AccountType;

            _Mode = enMode.Update;

        }

        public static clsClient Find(int ClientID)
        {
            int PersonID = -1, AccountBalance=-1;
            string PIN = "", AccountNumber ="", AccountType = "";


            if (clsClientData.GetClientInfoByID(ref ClientID, ref PersonID, ref AccountNumber, ref PIN, ref AccountBalance, ref AccountType))
                return new clsClient(ClientID, PersonID, AccountNumber, PIN,AccountBalance, AccountType);
            else
                return null;

        }

        public static clsClient Find(string AccountNumber)
        {
            int PersonID = -1, AccountBalance = -1,ClientID=-1;
            string PIN = "", AccountType = "";


            if (clsClientData.GetClientInfoByAccountNumber(ref ClientID, ref PersonID, ref AccountNumber, ref PIN, ref AccountBalance, ref AccountType))
                return new clsClient(ClientID, PersonID, AccountNumber, PIN, AccountBalance, AccountType);
            else
                return null;

        }

        public static clsClient FindByPersonID(int PersonID)
        {
            int AccountBalance = -1, ClientID = -1;
            string PIN = "", AccountType = "",AccountNumber="";


            if (clsClientData.GetClientInfoByPersonID(ref ClientID, ref PersonID, ref AccountNumber, ref PIN, ref AccountBalance, ref AccountType))
                return new clsClient(ClientID, PersonID, AccountNumber, PIN, AccountBalance, AccountType);
            else
                return null;

        }

        private bool _AddNewClient()
        {
            this.ClientID = clsClientData.AddNewClient(this.PersonID, this.AccountNumber, this.PIN, this.AccountBalance, this.AccountType);

            return (this.ClientID != -1);
        }

        private bool _UpdateClient()
        {
            return (clsClientData.UpdateClient(this.ClientID, this.PersonID, this.AccountNumber, this.PIN, this.AccountBalance, this.AccountType));


        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewClient())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return _UpdateClient();

            }
            return false;
        }

        public static DataTable GetAllClients()
        {
            return clsClientData.GetAllClients();

        }

        public static bool DeleteClient(int ClientID)
        {
            return clsClientData.DeleteClient(ClientID);
        }

        public static bool IsClientExist(int ClientID)
        {
            return clsClientData.IsClientExist(ClientID);
        }
        public static bool IsClientExistByPersonID(int PersonID)
        {
            return clsClientData.IsClientExistByPersonID(PersonID);
        }

        public static bool IsAccountNumberExist(string AccountNumber)
        {
            return clsClientData.IsClientExist(AccountNumber);
        }

        public static DataTable SearchForClientByClientID(int ClientID)
        {
            return clsClientData.SearchForClientByClientID(ClientID);

        }

        public static DataTable SearchForClientByPersonID(int PersonID)
        {
            return clsClientData.SearchForClientByPersonID(PersonID);

        }

        public static DataTable SearchForClientByName(string Name)
        {
            return clsClientData.SearchForClientByName(Name);

        }

        public static DataTable SearchForClientByAccountNumber(string AccountNumber)
        {
            return clsClientData.SearchForClientByAccountNumber(AccountNumber);

        }

        public static DataTable SearchForClientByAccountType(string AccountType)
        {
            return clsClientData.SearchForClientByAccountType(AccountType);

        }

        public bool Deposit(int Amount)
        {
            if (Amount <= 0)
                return false;


            this.AccountBalance = this.AccountBalance + Amount;
            return true;
        }

        public bool Withdrawl(int Amount)
        {
            if (Amount <= 0)
                return false;
            if (this.AccountBalance < Amount)
                return false;

            this.AccountBalance = this.AccountBalance - Amount;
            return true;
        }

        public bool Transfer(clsClient ReciverClient,int Amount)
        {
            return (this.Withdrawl(Amount) && ReciverClient.Deposit(Amount));
        }


    }
}
