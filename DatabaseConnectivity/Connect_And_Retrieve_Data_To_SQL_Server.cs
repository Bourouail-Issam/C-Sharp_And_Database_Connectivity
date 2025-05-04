using System;
using System.Data.SqlClient;


namespace DatabaseConnectivity
{
    internal class Connect_And_Retrieve_Data_To_SQL_Server
    {
        //------ ------
        public static void PrintAllContact()
        {
            SqlConnection connection = new SqlConnection(Parameters.StringConnection);
            string query = "select * from Contacts";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int contactID = (int)reader["ContactID"];
                    string firstName = (string)reader["FirstName"];
                    string lastName = (string)reader["LastName"];
                    string email = (string)reader["Email"];
                    string address = (string)reader["Address"];
                    int countryID = (int)reader["CountryID"];

                    Console.WriteLine("-------------------------------");
                    Console.WriteLine($"Contact ID :  {contactID}");
                    Console.WriteLine($"Name : {firstName} {lastName}");
                    Console.WriteLine($"Email : {email}");
                    Console.WriteLine($"Address : {address}");
                    Console.WriteLine($"countryID : {countryID}");
                    Console.WriteLine();
                }
                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //------ ------
        public static void PrintAllContactsWithFirstName(string Firstname)
        {
            SqlConnection connection = new SqlConnection(Parameters.StringConnection);
            string query = "select * from Contacts where  FirstName = @Firstname";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Firstname", Firstname);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int contactID = (int)reader["ContactID"];
                    string firstname = (string)reader["FirstName"];
                    string lastname = (string)reader["LastName"];
                    string email = (string)reader["Email"];
                    string phone = (string)reader["Phone"];
                    string address = (string)reader["Address"];
                    int countryID = (int)reader["CountryID"];

                    Console.WriteLine("________________________________");
                    Console.WriteLine($"ContactID : {contactID}");
                    Console.WriteLine($"Name : {firstname} {lastname}");
                    Console.WriteLine($"Email : {email}");
                    Console.WriteLine($"Phone : {phone}");
                    Console.WriteLine($"Address : {address}");
                    Console.WriteLine($"CountryID : {countryID}");
                    Console.WriteLine("");
                }
                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public static void PrintAllContactsWithFirstNameAndCountry(int Countryid, string Firstname)
        {
            SqlConnection connection = new SqlConnection(Parameters.StringConnection);
            string query = "select * from Contacts where CountryID=@Countryid and FirstName = @Firstname";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Countryid", Countryid);
            command.Parameters.AddWithValue("@Firstname", Firstname);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int contactID = (int)reader["ContactID"];
                    string firstname = (string)reader["FirstName"];
                    string lastname = (string)reader["LastName"];
                    string email = (string)reader["Email"];
                    string phone = (string)reader["Phone"];
                    string address = (string)reader["Address"];
                    int countryID = (int)reader["CountryID"];

                    Console.WriteLine("________________________________");
                    Console.WriteLine($"ContactID : {contactID}");
                    Console.WriteLine($"Name : {firstname} {lastname}");
                    Console.WriteLine($"Email : {email}");
                    Console.WriteLine($"Phone : {phone}");
                    Console.WriteLine($"Address : {address}");
                    Console.WriteLine($"CountryID : {countryID}");
                    Console.WriteLine("");
                }
                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //------ ------
        public static void SearchContactsStartsWith(string StartsWith)
        {
            SqlConnection connection = new SqlConnection(Parameters.StringConnection);
            string query = "select * from Contacts where FirstName like '' + @StartsWith + '%'";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@StartsWith", StartsWith);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int contactID = (int)reader["ContactID"];
                    string firstname = (string)reader["FirstName"];
                    string lastname = (string)reader["LastName"];
                    string email = (string)reader["Email"];
                    string phone = (string)reader["Phone"];
                    string address = (string)reader["Address"];
                    int countryID = (int)reader["CountryID"];

                    Console.WriteLine("________________________________");
                    Console.WriteLine($"ContactID : {contactID}");
                    Console.WriteLine($"Name : {firstname} {lastname}");
                    Console.WriteLine($"Email : {email}");
                    Console.WriteLine($"Phone : {phone}");
                    Console.WriteLine($"Address : {address}");
                    Console.WriteLine($"CountryID : {countryID}");
                    Console.WriteLine("");
                }
                connection.Close();
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void SearchContactsEndsWith(string EndsWith)
        {
            SqlConnection connection = new SqlConnection(Parameters.StringConnection);
            string query = "select * from Contacts where FirstName like @EndsWith";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@EndsWith", "%" + EndsWith);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int contactID = (int)reader["ContactID"];
                    string firstname = (string)reader["FirstName"];
                    string lastname = (string)reader["LastName"];
                    string email = (string)reader["Email"];
                    string phone = (string)reader["Phone"];
                    string address = (string)reader["Address"];
                    int countryID = (int)reader["CountryID"];

                    Console.WriteLine("________________________________");
                    Console.WriteLine($"ContactID : {contactID}");
                    Console.WriteLine($"Name : {firstname} {lastname}");
                    Console.WriteLine($"Email : {email}");
                    Console.WriteLine($"Phone : {phone}");
                    Console.WriteLine($"Address : {address}");
                    Console.WriteLine($"CountryID : {countryID}");
                    Console.WriteLine("");
                }
                connection.Close();
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void SearchContactsContains(string Contains)
        {
            SqlConnection connection = new SqlConnection(Parameters.StringConnection);
            string query = "select * from Contacts where FirstName like '%' + @Contains + '%'";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Contains", Contains);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int contactID = (int)reader["ContactID"];
                    string firstname = (string)reader["FirstName"];
                    string lastname = (string)reader["LastName"];
                    string email = (string)reader["Email"];
                    string phone = (string)reader["Phone"];
                    string address = (string)reader["Address"];
                    int countryID = (int)reader["CountryID"];

                    Console.WriteLine("________________________________");
                    Console.WriteLine($"ContactID : {contactID}");
                    Console.WriteLine($"Name : {firstname} {lastname}");
                    Console.WriteLine($"Email : {email}");
                    Console.WriteLine($"Phone : {phone}");
                    Console.WriteLine($"Address : {address}");
                    Console.WriteLine($"CountryID : {countryID}");
                    Console.WriteLine("");
                }
                connection.Close();
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //------ ------
        public static string GetFirstNameUserScaler(int ContactID)
        {
            string FirstName = "Nothing";
            SqlConnection connection = new SqlConnection(Parameters.StringConnection);
            string query = "select FirstName from Contacts where ContactID=@ContactID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ContactID", ContactID);

            try
            {
                connection.Open();
                object reader = command.ExecuteScalar();

                if (reader != null)
                {
                    FirstName = reader.ToString();
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return FirstName;
        }

        //------ ------
        public struct stContact
        {
            public int ContactID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Phone { get; set; }
            public string Email { get; set; }
            public string Address { get; set; }
            public int CountryID { get; set; }
        }
        public static bool FindContactByID(int Contact, ref stContact ContactInfo)
        {
            bool found = false;

            SqlConnection connection = new SqlConnection(Parameters.StringConnection);
            string query = "select * from Contacts where ContactID=@Contact";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Contact", Contact);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    found = true;
                    ContactInfo.ContactID = (int)reader["ContactID"];
                    ContactInfo.FirstName = (string)reader["FirstName"];
                    ContactInfo.LastName = (string)reader["LastName"];
                    ContactInfo.Email = (string)reader["Email"];
                    ContactInfo.Phone = (string)reader["Phone"];
                    ContactInfo.Address = (string)reader["Address"];
                    ContactInfo.CountryID = (int)reader["CountryID"];
                }
                connection.Close();
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return found;
        }

    }
}
