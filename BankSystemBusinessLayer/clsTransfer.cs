using BankSystemDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemBusinessLayer
{
    public class clsTransfer
    {
        public int TTransactionID { get; set; }
        public int SenderClientID { get; set; }
        public int ReciverClientID { get; set; }

        public int Amount { get; set; }
        public DateTime TTransactionDate { get; set; }


        public clsTransfer()
        {
            this.TTransactionID = -1;
            this.ReciverClientID = -1;
            this.SenderClientID = -1;

            this.Amount = -1;
            this.TTransactionDate = DateTime.Now;

        }

        protected clsTransfer(int TTransactionID, int SenderClientID,int ReciverClientID ,int Amount, DateTime TTransactionDate)
        {
            this.TTransactionID = TTransactionID;
            this.SenderClientID = SenderClientID;
            this.ReciverClientID = ReciverClientID;

            this.Amount = Amount;
            this.TTransactionDate = TTransactionDate;


        }





        private bool _AddNewTransfer()
        {
            this.TTransactionID = clsTransferData.AddNewTransfer(this.SenderClientID, this.ReciverClientID, this.Amount,this.TTransactionDate);

            return (this.TTransactionID != -1);
        }

        public static clsTransfer Find(int TTransactionID)
        {
            int SClientID = -1,RClientID = -1, Amount = -1;
            DateTime TTransactionDate = DateTime.Now;

            if (clsTransferData.GetTransferInfoByTransactionID(ref TTransactionID, ref SClientID, ref RClientID,ref Amount, ref TTransactionDate))
                return new clsTransfer(TTransactionID, SClientID, RClientID, Amount,TTransactionDate);
            else
                return null;

        }


        public bool Save()
        {
            if (_AddNewTransfer())
            {
                return true;
            }
            return false;

        }

        public static DataTable GetAllTransfers()
        {
            return clsTransferData.GetAllTransfers();

        }

        public static bool DeleteTransfer(int TTransactionID)
        {
            return clsTransferData.DeleteTransfer(TTransactionID);
        }







    }
}
