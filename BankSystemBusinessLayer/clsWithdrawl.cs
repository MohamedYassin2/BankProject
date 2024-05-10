using BankSystemDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemBusinessLayer
{
    public class clsWithdrawl
    {
        public int WTransactionID { get; set; }
        public int ClientID { get; set; }
        public int Amount { get; set; }
        public DateTime WTransactionDate { get; set; }

        public clsWithdrawl()
        {
            this.WTransactionID = -1;
            this.ClientID = -1;
            this.Amount = -1;
            this.WTransactionDate = DateTime.Now;

        }
        protected clsWithdrawl(int WTransactionID, int ClientID, int Amount, DateTime WTransactionDate)
        {
            this.WTransactionID = WTransactionID;
            this.ClientID = ClientID;
            this.Amount = Amount;
            this.WTransactionDate = WTransactionDate;


        }
        private bool _AddNewWithdrawl()
        {
            this.WTransactionID = clsWithdrawlData.AddNewWithDrawl(this.ClientID, this.Amount, this.WTransactionDate);

            return (this.WTransactionID != -1);
        }

        public static clsWithdrawl Find(int WTransactionID)
        {
            int ClientID = -1, Amount = -1;
            DateTime WTransactionDate = DateTime.Now;

            if (clsWithdrawlData.GetWithdrawlInfoByTransactionID(ref WTransactionID, ref ClientID, ref Amount, ref WTransactionDate))
                return new clsWithdrawl(WTransactionID, ClientID, Amount, WTransactionDate);
            else
                return null;

        }

        public bool Save()
        {
            if (_AddNewWithdrawl())
            {
                return true;
            }
            return false;

        }
        public static DataTable GetAllWithdrawl()
        {
            return clsWithdrawlData.GetAllWithdrawls();

        }

        public static bool DeleteWithdrawl(int WTransactionID)
        {
            return clsWithdrawlData.DeleteWithDrawl(WTransactionID);
        }

    }
}
