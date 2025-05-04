using System;
using System.Data.SqlClient;

namespace DatabaseConnectivity
{
    internal class Insert_Add_Data_To_SQL_Server
    {
        public static void AddNewContact(Connect_And_Retrieve_Data_To_SQL_Server.stContact ContactInfo)
        {
            SqlConnection connection = new SqlConnection(Parameters.StringConnection);
            string query = @"insert into Contacts (FirstName, LastName, Email, Phone, Address, CountryID)
                                Values (@FirstName, @LastName, @Email, @Phone, @Address, @CountryID)";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@FirstName", ContactInfo.FirstName);
            command.Parameters.AddWithValue("@LastName", ContactInfo.LastName);
            command.Parameters.AddWithValue("@Email", ContactInfo.Email);
            command.Parameters.AddWithValue("@Phone", ContactInfo.Phone);
            command.Parameters.AddWithValue("@Address", ContactInfo.Address);
            command.Parameters.AddWithValue("@CountryID", ContactInfo.CountryID);

            try
            {
                connection.Open();
                int RowAffected = command.ExecuteNonQuery();

                if (RowAffected >= 1)
                {
                    Console.WriteLine("Record inserted successfully.");
                }
                else
                {
                    Console.WriteLine("Record inserted Failed.");
                }
                connection.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}