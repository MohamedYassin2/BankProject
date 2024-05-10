using Bank_System_Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemDataAccessLayer
{
    public class clsWithdrawlData
    {
        public static bool GetWithdrawlInfoByTransactionID(ref int WTransactionID, ref int ClientID, ref int Amount, ref DateTime WTransactionDate)

        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionstring);

            string Query = @"SELECT * FROM Withdrawls Where WTransactionID=@WTransactionID";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@WTransactionID", WTransactionID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;
                    WTransactionID = (int)reader["WTransactionID"];
                    ClientID = (int)reader["ClientID"];
                    Amount = (int)reader["Amount"];
                    WTransactionDate = (DateTime)reader["WTransactionDate"];

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

        public static int AddNewWithDrawl(int ClientID, int Amount, DateTime WTransactionDate)
        {
            int DTransactionID = -1;
            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionstring);

            string Query = @"INSERT INTO Withdrawls (ClientID,Amount,WTransactionDate)
                             VALUES(@ClientID,@Amount,@WTransactionDate)
                          SELECT SCOPE_IDENTITY()";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ClientID", ClientID);
            command.Parameters.AddWithValue("@Amount", Amount);
            command.Parameters.AddWithValue("@WTransactionDate", WTransactionDate);

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

        public static DataTable GetAllWithdrawls()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionstring);

            string query = "select * from WithdrawlsDetails";

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

        public static bool DeleteWithDrawl(int WTransactionID)
        {
            bool IsDeleted = false;
            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionstring);

            string Query = @"Delete from WithDrawls 
                                where WTransactionID=@WTransactionID";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@WTransactionID", WTransactionID);

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
