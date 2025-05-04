using System;
using static DatabaseConnectivity.Connect_And_Retrieve_Data_To_SQL_Server;
using static DatabaseConnectivity.Insert_Add_Data_To_SQL_Server;

namespace DatabaseConnectivity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("#####--Get All Contact--#####");
            PrintAllContact();

            // ------------------------------
            Console.WriteLine("#####--Get Contact with firstName--#####");
            PrintAllContactsWithFirstName("jane");
            Console.WriteLine("#####--Get Contact with firstName and ContactID--#####");
            PrintAllContactsWithFirstNameAndCountry(1, "jane");

            //-------------------------------
            Console.WriteLine("#####--Search Contact Starts with j--#####");
            SearchContactsStartsWith("j");
            Console.WriteLine("#####--Search Contact Ends with ne--#####");
            SearchContactsEndsWith("ne");
            Console.WriteLine("#####--Search Contact Contains ae--#####");
            SearchContactsContains("ae");

            //-------------------------------
            Console.WriteLine("#####--Get FirstName with ContactID--#####");
            Console.WriteLine(GetFirstNameUserScaler(10).ToString());

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
            stContact Contact = new stContact
            {
                FirstName = "Issam",
                LastName = "Bourouail",
                Email = "issambourouail@gmail.com",
                Phone = "0643252636",
                Address = "Bernoussi Casablanca Maroc",
                CountryID = 1
            };
            AddNewContact(Contact);

        }
    }
}
