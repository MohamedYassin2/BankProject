using Bank_System_Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemDataAccessLayer
{
    public class clsTransferData
    {
        public static bool GetTransferInfoByTransactionID(ref int TTransactionID, ref int SenderClientID, ref int ReciverClientID, ref int Amount, ref DateTime TTransactionDate)

        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionstring);

            string Query = @"SELECT * FROM Transfers Where TTransactionID=@TTransactionID";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@TTransactionID", TTransactionID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;
                    TTransactionID = (int)reader["TTransactionID"];
                    SenderClientID = (int)reader["SenderClientID"];
                    ReciverClientID = (int)reader["ReciverClientID"];
                    Amount = (int)reader["Amount"];

                    TTransactionDate = (DateTime)reader["TTransactionDate"];

                }
                else
                {
                    IsFound = false;
                }
                reader.Close();

            }
            catch (Exception ex)
            {

                IsFound = false;
            }
            finally
            {
                connection.Close();
            }
            return IsFound;
        }

        public static int AddNewTransfer( int SenderClientID,  int ReciverClientID,  int Amount,  DateTime TTransactionDate)
        {
            int DTransactionID = -1;
            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionstring);

            string Query = @"INSERT INTO Transfers (SenderClientID,ReciverClientID,Amount,TTransactionDate)
                             VALUES(@SenderClientID,@ReciverClientID,@Amount,@TTransactionDate)
                          SELECT SCOPE_IDENTITY()";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@SenderClientID", SenderClientID);
            command.Parameters.AddWithValue("@ReciverClientID", ReciverClientID);

            command.Parameters.AddWithValue("@Amount", Amount);
            command.Parameters.AddWithValue("@TTransactionDate", TTransactionDate);

            try
            {
                connection.Open();
                object Result = command.ExecuteScalar();
                if (Result != null)
                {
                    DTransactionID = Convert.ToInt32(Result);
                }
                else
                {
                    DTransactionID = -1;
                }

            }
            catch (Exception ex)
            {

                DTransactionID = -1;
            }
            finally
            {
                connection.Close();
            }
            return DTransactionID;
        }

        public static DataTable GetAllTransfers()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionstring);

            string query = "select * from TransfersDETAILS";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)

                {
                    dt.Load(reader);
                }

                reader.Close();


            }

            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return dt;

        }

        public static bool DeleteTransfer(int TTransactionID)
        {
            bool IsDeleted = false;
            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionstring);

            string Query = @"Delete from Transfers 
                                where TTransactionID=@TTransactionID";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@TTransactionID", TTransactionID);

            try
            {
                connection.Open();
                int RowsAffected = command.ExecuteNonQuery();
                if (RowsAffected > 0)
                {
                    IsDeleted = true;
                }
                else
                {
                    IsDeleted = false;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                IsDeleted = false;
            }
            finally
            {
                connection.Close();
            }
            return IsDeleted;

        }


    }
}
