using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System_Data_Access_Layer
{
    public class clsUserData
    {
        public static bool GetUserInfoByID(ref int UserID, ref int PersonID, ref string UserName, ref string Password,ref int Permission ,ref bool IsActive)

        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionstring);

            string Query = @"SELECT * FROM Users Where UserID=@UserID";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;
                    UserID = (int)reader["UserID"];
                    PersonID = (int)reader["PersonID"];
                    UserName = (string)reader["UserName"];
                    Password = (string)reader["Password"];
                    Permission = (int)reader["Permission"];
                    IsActive = (bool)reader["IsActive"];

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

        public static bool GetUserInfoByUserNameAndPassword(ref int UserID, ref int PersonID, ref string UserName, ref string Password, ref int Permission ,ref bool IsActive)

        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionstring);

            string Query = @"SELECT * FROM Users Where UserName=@UserName and Password=@Password";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);


            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;
                    UserID = (int)reader["UserID"];
                    PersonID = (int)reader["PersonID"];
                    UserName = (string)reader["UserName"];
                    Password = (string)reader["Password"];
                    Permission = (int)reader["Permission"];
                    IsActive = (bool)reader["IsActive"];

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

        public static bool GetUserInfoByUserName(ref int UserID, ref int PersonID, ref string UserName, ref string Password, ref int Permission, ref bool IsActive)

        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionstring);

            string Query = @"SELECT * FROM Users Where UserName=@UserName";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@UserName", UserName);


            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;
                    UserID = (int)reader["UserID"];
                    PersonID = (int)reader["PersonID"];
                    UserName = (string)reader["UserName"];
                    Password = (string)reader["Password"];
                    IsActive = (bool)reader["IsActive"];
                    Permission = (int)reader["Permission"];

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

        public static int AddNewUser(int PersonID, string UserName, string Password,  int Permission,bool IsActive)
        {
            int UserID = -1;
            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionstring);

            string Query = @"INSERT INTO Users (PersonID,UserName,Password,Permission,IsActive)
                             VALUES(@PersonID,@UserName,@Password,@Permission,@IsActive)
                          SELECT SCOPE_IDENTITY()";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@Permission", Permission);

            try
            {
                connection.Open();
                object Result = command.ExecuteScalar();
                if (Result != null)
                {
                    UserID = Convert.ToInt32(Result);
                }
                else
                {
                    UserID = -1;
                }

            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex.Message);
                UserID = -1;
            }
            finally
            {
                connection.Close();
            }
            return UserID;
        }

        public static bool UpdateUser(int UserID, int PersonID, string UserName, string Password,  int Permission, bool IsActive)
        {
            bool IsUpdated = false;
            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionstring);

            string Query = @"Update Users 
                             SET PersonID = @PersonID
                                ,UserName = @UserName
                                ,Password = @Password
                                ,Permission = @Permission
                                ,IsActive = @IsActive
                                where UserID=@UserID";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@Permission", Permission);

            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@UserID", UserID);

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

        public static DataTable GetAllUsers()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionstring);

            string query = "select * from UsersDetails";

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

        public static bool DeleteUser(int UserID)
        {
            bool IsDeleted = false;
            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionstring);

            string Query = @"Delete from Users 
                                where UserID=@UserID";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);

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

        public static bool IsUserExist(int UserID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionstring);

            string query = "SELECT Found=1 FROM Users WHERE UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);

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

        public static bool IsUserExistByPersonID(int PersonID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionstring);

            string query = "SELECT Found=1 FROM Users WHERE PersonID = @PersonID";

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

        public static bool IsUserExist(string UserName)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionstring);

            string query = "SELECT Found=1 FROM Users WHERE UserName = @UserName";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserName", UserName);

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

        public static bool IsUserActive(string UserName)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionstring);

            string query = "SELECT Found=1 FROM Users WHERE UserName = @UserName And IsActive = 1";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserName", UserName);

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

        public static DataTable SearchForUserByUserID(int UserID)
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionstring);

            string query = @"SELECT * from UsersDetails
                             where UserID = @UserID ";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("UserID", UserID);
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

        public static DataTable SearchForUserByPersonID(int PersonID)
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionstring);

            string query = @"SELECT * from UsersDetails
                             where PersonID = @PersonID ";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("PersonID", PersonID);
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

        public static DataTable SearchForUserByUserName(string UserName)
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionstring);

            string query = @"SELECT * from UsersDetails
                             where UserName LIKE '' + @UserName +'%'";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("UserName", UserName);
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

        public static DataTable GetActivedUsers()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionstring);

            string query = @"select * from UsersDetails
                            where IsActive = 1";

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

        public static DataTable GetDeActivedUsers()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionstring);

            string query = @"select * from UsersDetails
                            where IsActive = 0";

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

    }
}
