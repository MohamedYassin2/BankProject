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
    public class clsClientData
    {
        public static bool GetClientInfoByID(ref int ClientID, ref int PersonID, ref string AccountNumber, ref string PIN, ref int AccountBalance, ref string AccountType)

        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionstring);

            string Query = @"SELECT * FROM Clients Where ClientID=@ClientID";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ClientID", ClientID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;
                    ClientID = (int)reader["ClientID"];
                    PersonID = (int)reader["PersonID"];
                    AccountNumber = (string)reader["AccountNumber"];
                    PIN = (string)reader["PIN"];
                    AccountBalance = (int)reader["AccountBalance"];
                    AccountType = (string)reader["AccountType"];

                }
                else
                {
                    IsFound = false;
                }
                reader.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                IsFound = false;
            }
            finally
            {
                connection.Close();
            }
            return IsFound;
        }

        public static bool GetClientInfoByAccountNumber(ref int ClientID, ref int PersonID, ref string AccountNumber, ref string PIN, ref int AccountBalance, ref string AccountType)

        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionstring);

            string Query = @"SELECT * FROM Clients Where AccountNumber=@AccountNumber";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);


            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;
                    ClientID = (int)reader["ClientID"];
                    PersonID = (int)reader["PersonID"];
                    AccountNumber = (string)reader["AccountNumber"];
                    PIN = (string)reader["PIN"];
                    AccountBalance = (int)reader["AccountBalance"];
                    AccountType = (string)reader["AccountType"];

                }
                else
                {
                    IsFound = false;
                }
                reader.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                IsFound = false;
            }
            finally
            {
                connection.Close();
            }
            return IsFound;
        }

        public static bool GetClientInfoByPersonID(ref int ClientID, ref int PersonID, ref string AccountNumber, ref string PIN, ref int AccountBalance, ref string AccountType)

        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionstring);

            string Query = @"SELECT * FROM Clients Where PersonID=@PersonID";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;
                    ClientID = (int)reader["ClientID"];
                    PersonID = (int)reader["PersonID"];
                    AccountNumber = (string)reader["AccountNumber"];
                    PIN = (string)reader["PIN"];
                    AccountBalance = (int)reader["AccountBalance"];
                    AccountType = (string)reader["AccountType"];

                }
                else
                {
                    IsFound = false;
                }
                reader.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                IsFound = false;
            }
            finally
            {
                connection.Close();
            }
            return IsFound;
        }

        public static int AddNewClient(int PersonID, string AccountNumber, string PIN,int AccountBalance,string AccountType)
        {
            int ClientID = -1;
            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionstring);

            string Query = @"INSERT INTO Clients (PersonID,AccountNumber,PIN,AccountBalance,AccountType)
                             VALUES(@PersonID,@AccountNumber,@PIN,@AccountBalance,@AccountType)
                          SELECT SCOPE_IDENTITY()";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            command.Parameters.AddWithValue("@PIN", PIN);
            command.Parameters.AddWithValue("@AccountBalance", AccountBalance);
            command.Parameters.AddWithValue("@AccountType", AccountType);

            try
            {
                connection.Open();
                object Result = command.ExecuteScalar();
                if (Result != null)
                {
                    ClientID = Convert.ToInt32(Result);
                }
                else
                {
                    ClientID = -1;
                }

            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex.Message);
                ClientID = -1;
            }
            finally
            {
                connection.Close();
            }
            return ClientID;
        }
        public static bool UpdateClient( int ClientID,  int PersonID,  string AccountNumber,  string PIN,  int AccountBalance, string AccountType)
        {
            bool IsUpdated = false;
            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionstring);

            string Query = @"Update Clients 
                             SET PersonID = @PersonID
                                ,AccountNumber = @AccountNumber
                                ,PIN = @PIN
                                ,AccountBalance = @AccountBalance
                                ,AccountType = @AccountType
                                where ClientID=@ClientID";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            command.Parameters.AddWithValue("@PIN", PIN);
            command.Parameters.AddWithValue("@AccountBalance", AccountBalance);

            command.Parameters.AddWithValue("@AccountType", AccountType);
            command.Parameters.AddWithValue("@ClientID", ClientID);

            try
            {
                connection.Open();
                int RowsAffected = command.ExecuteNonQuery();
                if (RowsAffected > 0)
                {
                    IsUpdated = true;
                }
                else
                {
                    IsUpdated = false;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                IsUpdated = false;
            }
            finally
            {
                connection.Close();
            }
            return IsUpdated;

        }

        public static DataTable GetAllClients()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionstring);

            string query = "select * from ClientsDetails";

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

        public static bool DeleteClient(int ClientID)
        {
            bool IsDeleted = false;
            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionstring);

            string Query = @"Delete from Clients 
                                where ClientID=@ClientID";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ClientID", ClientID);

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

        public static bool IsClientExist(int ClientID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionstring);

            string query = "SELECT Found=1 FROM Clients WHERE ClientID = @ClientID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ClientID", ClientID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;

                reader.Close();
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }


        public static bool IsClientExistByPersonID(int PersonID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionstring);

            string query = "SELECT Found=1 FROM Clients WHERE PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;

                reader.Close();
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static bool IsClientExist(string AccountNumber)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionstring);

            string query = "SELECT Found=1 FROM Clients WHERE AccountNumber = @AccountNumber";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;

                reader.Close();
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static DataTable SearchForClientByClientID(int ClientID)
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionstring);

            string query = @"select * from ClientsDetails
                               Where ClientID = @ClientID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ClientID", ClientID);
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

        public static DataTable SearchForClientByPersonID(int PersonID)
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionstring);

            string query = @"select * from ClientsDetails
                               Where PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
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

        public static DataTable SearchForClientByName(string Name)
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionstring);

            string query = @"select * from ClientsDetails
                               Where FullName LIKE '' + @Name + '%'";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Name", Name);
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

        public static DataTable SearchForClientByAccountNumber(string AccountNumber)
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionstring);

            string query = @"select * from ClientsDetails
                               Where AccountNumber LIKE '' + @AccountNumber + '%'";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
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


        public static DataTable SearchForClientByAccountType(string AccountType)
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionstring);

            string query = @"select * from ClientsDetails
                               Where AccountType LIKE '' + @AccountType + '%'";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AccountType", AccountType);
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
