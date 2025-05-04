using System;
using static DatabaseConnectivity.Connect_And_Retrieve_Data_To_SQL_Server;

namespace DatabaseConnectivity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("#####--Get All Contact--#####");
            Connect_And_Retrieve_Data_To_SQL_Server.PrintAllContact();

            // ------------------------------
            Console.WriteLine("#####--Get Contact with firstName--#####");
            Connect_And_Retrieve_Data_To_SQL_Server.PrintAllContactsWithFirstName("jane");
            Console.WriteLine("#####--Get Contact with firstName and ContactID--#####");
            Connect_And_Retrieve_Data_To_SQL_Server.PrintAllContactsWithFirstNameAndCountry(1, "jane");

            //-------------------------------
            Console.WriteLine("#####--Search Contact Starts with j--#####");
            Connect_And_Retrieve_Data_To_SQL_Server.SearchContactsStartsWith("j");
            Console.WriteLine("#####--Search Contact Ends with ne--#####");
            Connect_And_Retrieve_Data_To_SQL_Server.SearchContactsEndsWith("ne");
            Console.WriteLine("#####--Search Contact Contains ae--#####");
            Connect_And_Retrieve_Data_To_SQL_Server.SearchContactsContains("ae");

            //-------------------------------
            Console.WriteLine("#####--Get FirstName with ContactID--#####");
            Console.WriteLine(Connect_And_Retrieve_Data_To_SQL_Server.GetFirstNameUserScaler(10).ToString());

            //-------------------------------
            stContact ContactInfo = new stContact();
            if (FindContactByID(1, ref ContactInfo))
            {
                Console.WriteLine("#####--Find Contact with ContactID--#####");
                Console.WriteLine($"ContactID : {ContactInfo.ContactID}");
                Console.WriteLine($"Name : {ContactInfo.FirstName} {ContactInfo.LastName}");
                Console.WriteLine($"Email : {ContactInfo.Email}");
                Console.WriteLine($"Phone : {ContactInfo.Phone}");
                Console.WriteLine($"Address : {ContactInfo.Address}");
                Console.WriteLine($"CountryID : {ContactInfo.CountryID}");
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("");
            }

            //-------------------------------

        }
    }
}
