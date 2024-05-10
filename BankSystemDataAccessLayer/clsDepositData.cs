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
    public class clsDepositData
    {
        public static bool GetDepositInfoByTransactionID(ref int DTransactionID, ref int ClientID, ref int Amount, ref DateTime DTransactionDate)

        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionstring);

            string Query = @"SELECT * FROM Deposits Where DTransactionID=@DTransactionID";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@DTransactionID", DTransactionID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;
                    DTransactionID = (int)reader["DTransactionID"];
                    ClientID = (int)reader["ClientID"];
                    Amount = (int)reader["Amount"];
                    DTransactionDate = (DateTime)reader["DTransactionDate"];

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

        public static int AddNewDeposit(  int ClientID,  int Amount,  DateTime DTransactionDate)
        {
            int DTransactionID = -1;
            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionstring);

            string Query = @"INSERT INTO Deposits (ClientID,Amount,DTransactionDate)
                             VALUES(@ClientID,@Amount,@DTransactionDate)
                          SELECT SCOPE_IDENTITY()";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ClientID", ClientID);
            command.Parameters.AddWithValue("@Amount", Amount);
            command.Parameters.AddWithValue("@DTransactionDate", DTransactionDate);

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

        public static DataTable GetAllDeposits()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionstring);

            string query = "select * from DepositsDetails";

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

        public static bool DeleteDeposit(int DTransactionID)
        {
            bool IsDeleted = false;
            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionstring);

            string Query = @"Delete from Deposits 
                                where DTransactionID=@DTransactionID";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@DTransactionID", DTransactionID);

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

        public static DataTable SearchForDepositByDTransactionID(int DTransactionID)
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionstring);

            string query = @"SELECT * from DepositsDetails
                             where DTransactionID = @DTransactionID ";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("DTransactionID", DTransactionID);
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

        public static DataTable SearchForDepositByClientID(int ClientID)
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionstring);

            string query = @"SELECT * from DepositsDetails
                             where ClientID = @ClientID ";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("ClientID", ClientID);
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

        public static DataTable SearchForDepositByAmount(int Amount)
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionstring);

            string query = @"SELECT * from DepositsDetails
                             where Amount = @Amount ";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("Amount", Amount);
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

        public static DataTable SearchForDepositByClientName(string Name)
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionstring);

            string query = @"SELECT * from DepositsDetails
                             where FullName LIKE '' + @Name +'%'";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("Name", Name);
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
        public static DataTable SearchForDepositByDate(DateTime Date)
        {
            DateTime ComparedDate=Date.Date;
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionstring);

            string query = @"SELECT *
                                FROM DepositsDetails
                                WHERE CONVERT(DATE, DTransactionDate)= @ComparedDate";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ComparedDate", ComparedDate);
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
    }
}
