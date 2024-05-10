using Bank_System_Data_Access_Layer;
using BankSystemDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BankSystemBusinessLayer
{
    public class clsDeposit
    {
        public int DTransactionID { get; set; }
        public int ClientID { get; set; }
        public int Amount { get; set; }
        public DateTime DTransactionDate { get; set; }

        public clsDeposit()
        {
            this.DTransactionID = -1;
            this.ClientID = -1;
            this.Amount = -1;
            this.DTransactionDate = DateTime.Now;

        }
        protected clsDeposit(int DTransactionID, int ClientID, int Amount, DateTime DTransactionDate)
        {
            this.DTransactionID = DTransactionID;
            this.ClientID = ClientID;
            this.Amount = Amount;
            this.DTransactionDate = DTransactionDate;


        }


        private bool _AddNewDeposit()
        {
            this.DTransactionID = clsDepositData.AddNewDeposit(this.ClientID, this.Amount, this.DTransactionDate);

            return (this.DTransactionID != -1);
        }
        public static clsDeposit Find(int DTransactionID)
        {
            int ClientID=-1, Amount = -1;
            DateTime DTransactionDate = DateTime.Now;

            if (clsDepositData.GetDepositInfoByTransactionID(ref DTransactionID, ref ClientID, ref Amount, ref DTransactionDate))
                return new clsDeposit(DTransactionID,  ClientID,  Amount,  DTransactionDate);
            else
                return null;

        }

        public bool Save()
        {
            if(_AddNewDeposit())
            {
                return true;
            }
            return false;
             
        }

        public static DataTable GetAllDeposits()
        {
            return clsDepositData.GetAllDeposits();

        }

        public static bool DeleteDeposit(int DTransactionID)
        {
            return clsDepositData.DeleteDeposit(DTransactionID);
        }

        public static DataTable SearchForDepositByDTransactionID(int DTransactionID)
        {
            return clsDepositData.SearchForDepositByDTransactionID(DTransactionID);

        }
        public static DataTable SearchForDepositByClientID(int ClientID)
        {
            return clsDepositData.SearchForDepositByClientID(ClientID);

        }
        public static DataTable SearchForDepositByAmount(int Amount)
        {
            return clsDepositData.SearchForDepositByAmount(Amount);

        }
        public static DataTable SearchForDepositByClientName(string Name)
        {
            return clsDepositData.SearchForDepositByClientName(Name);

        }
        public static DataTable SearchForDepositByDate(DateTime Date)
        {
            return clsDepositData.SearchForDepositByDate(Date);

        }


    }
}
