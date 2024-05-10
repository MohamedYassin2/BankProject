using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System_Data_Access_Layer
{
    public class clsPersonData
    {
        public static bool GetPersonInfoByID(ref int PersonID, ref int CountryID, ref string FirstName, ref string SecondName
            , ref string ThirdName, ref string LastName, ref string Phone, ref string Email, ref DateTime DateOfBirth
            , ref string ImagePath, ref string Address, ref string NationalNo
            , ref byte Gender)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionstring);

            string Query = @"SELECT * FROM People Where PersonID=@PersonID";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;
                    PersonID = (int)reader["PersonID"];
                    CountryID = (int)reader["CountryID"];
                    NationalNo = (string)reader["NationalNo"];
                    FirstName = (string)reader["FirstName"];
                    ThirdName = (string)reader["ThirdName"];
                    SecondName = (string)reader["SecondName"];
                    LastName = (string)reader["LastName"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    Gender = (byte)reader["Gender"];
                    Address = (string)reader["Address"];
                    Phone = (string)reader["Phone"];
                   

                    if (reader["Email"] == DBNull.Value)
                        Email = "";
                    else
                        Email = (string)reader["Email"];

                    if (reader["ImagePath"] == DBNull.Value)
                        ImagePath = "";
                    else
                        ImagePath = (string)reader["ImagePath"];

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


        public static bool GetPersonInfoByNationalNo(ref int PersonID, ref int CountryID, ref string FirstName, ref string SecondName
            , ref string ThirdName, ref string LastName, ref string Phone, ref string Email, ref DateTime DateOfBirth
            , ref string ImagePath, ref string Address, ref string NationalNo
            , ref byte Gender)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionstring);

            string Query = @"SELECT * FROM People Where NationalNo=@NationalNo";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;
                    PersonID = (int)reader["PersonID"];
                    CountryID = (int)reader["CountryID"];
                    NationalNo = (string)reader["NationalNo"];
                    FirstName = (string)reader["FirstName"];
                    ThirdName = (string)reader["ThirdName"];
                    SecondName = (string)reader["SecondName"];
                    LastName = (string)reader["LastName"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    Gender = (byte)reader["Gender"];
                    Address = (string)reader["Address"];
                    Phone = (string)reader["Phone"];


                    if (reader["Email"] == DBNull.Value)
                        Email = "";
                    else
                        Email = (string)reader["Email"];

                    if (reader["ImagePath"] == DBNull.Value)
                        ImagePath = "";
                    else
                        ImagePath = (string)reader["ImagePath"];

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


        public static int AddNewPerson(  int CountryID,  string FirstName, string SecondName
            , string ThirdName, string LastName, string Phone, string Email,  DateTime DateOfBirth
            , string ImagePath, string Address, string NationalNo
            , byte Gender)
        {
            int PersonID = -1;
            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionstring);

            string Query = @"INSERT INTO People (CountryID,FirstName,SecondName,ThirdName,LastName,Phone,
                              Email,DateOfBirth,ImagePath,Address,NationalNo,Gender)
                             VALUES(@CountryID,@FirstName,@SecondName,@ThirdName,@LastName,@Phone,
                              @Email,@DateOfBirth,@ImagePath,@Address,@NationalNo,@Gender)
                          SELECT SCOPE_IDENTITY()";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@CountryID", CountryID);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);
            command.Parameters.AddWithValue("@ThirdName", ThirdName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Phone", Phone);

            if (Email != "")
                command.Parameters.AddWithValue("@Email", Email);
            else
                command.Parameters.AddWithValue("@Email", DBNull.Value);

            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);

            if (ImagePath != "")
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            else
                command.Parameters.AddWithValue("@ImagePath", DBNull.Value);

            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            command.Parameters.AddWithValue("@Gender", Gender);



            try
            {
                connection.Open();
                object Result = command.ExecuteScalar();
                if (Result != null)
                {
                    PersonID = Convert.ToInt32(Result);
                }
                else
                {
                    PersonID = -1;
                }

            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex.Message);
                PersonID = -1;
            }
            finally
            {
                connection.Close();
            }
            return PersonID;
        }

        public static bool UpdatePerson(int PersonID, int CountryID, string FirstName,  string SecondName
            , string ThirdName, string LastName, string Phone,  string Email,  DateTime DateOfBirth
            , string ImagePath, string Address, string NationalNo
            , byte Gender)
        {
            bool IsUpdated = false;
            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionstring);

            string Query = @"Update People 
                             SET NationalNo = @NationalNo
                                ,CountryID= @CountryID
                                ,FirstName = @FirstName
                                ,SecondName = @SecondName
                                ,ThirdName = @ThirdName
                                ,LastName = @LastName
                                ,Gender = @Gender
                                ,Address = @Address
                                ,ImagePath = @ImagePath
                                ,DateOfBirth = @DateOfBirth
                                ,Phone = @Phone
                                ,Email = @Email
                                where PersonID=@PersonID";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            command.Parameters.AddWithValue("@CountryID", CountryID);

            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Gender", Gender);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@PersonID", PersonID);

            
           command.Parameters.AddWithValue("@ThirdName", ThirdName);
          

            if (Email != "")
                command.Parameters.AddWithValue("@Email", Email);
            else
                command.Parameters.AddWithValue("@Email", System.DBNull.Value);

            if (ImagePath != "")
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            else
                command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);




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

        public static DataTable GetAllPeople()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionstring);

            string query = @"SELECT * from PeopleDetailsView";

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

        public static bool DeletePerson(int PersonID)
        {
            bool IsDeleted = false;
            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionstring);

            string Query = @"Delete from People 
                                where PersonID=@PersonID";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);

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

        public static bool IsPersonExist(int PersonID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionstring);

            string query = "SELECT Found=1 FROM People WHERE PersonID = @PersonID";

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

        public static bool IsPersonExist(string NationalNo)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionstring);

            string query = "SELECT Found=1 FROM People WHERE NationalNo = @NationalNo";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@NationalNo", NationalNo);

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

        public static DataTable SearchForPersonByFistName(string FirstName)
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionstring);

            string query = @"SELECT * from PeopleDetailsView
                             where FirstName LIKE '' + @FirstName +'%'";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("FirstName", FirstName);
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

        public static DataTable SearchForPersonBySecondName(string SecondName)
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionstring);

            string query = @"SELECT * from PeopleDetailsView
                             where SecondName LIKE '' + @SecondName +'%'";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("SecondName", SecondName);
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

        public static DataTable SearchForPersonByThirdName(string ThirdName)
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionstring);

            string query = @"SELECT * from PeopleDetailsView
                             where ThirdName LIKE '' + @ThirdName +'%'";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("ThirdName", ThirdName);
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

        public static DataTable SearchForPersonByLastName(string LastName)
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionstring);

            string query = @"SELECT * from PeopleDetailsView
                             where LastName LIKE '' + @LastName +'%'";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("LastName", LastName);
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

        public static DataTable SearchForPersonByNationalNo(string NationalNo)
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionstring);

            string query = @"SELECT * from PeopleDetailsView
                             where NationalNo LIKE '' + @NationalNo +'%'";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("NationalNo", NationalNo);
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
        public static DataTable SearchForPersonByPhone(string Phone)
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionstring);

            string query = @"SELECT * from PeopleDetailsView
                             where Phone LIKE '' + @Phone +'%'";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("Phone", Phone);
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
        public static DataTable SearchForPersonByPersonID(int PersonID)
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionstring);

            string query = @"SELECT * from PeopleDetailsView
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
        public static DataTable GetAllMale()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionstring);

            string query = @"SELECT * from PeopleDetailsView
                            where Gender = 'M'";

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

        public static DataTable GetAllFemale()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionstring);

            string query = @"SELECT * from PeopleDetailsView
                            where Gender = 'F'";

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