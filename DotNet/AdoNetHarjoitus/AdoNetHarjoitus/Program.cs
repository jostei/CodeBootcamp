using System;
using System.Data.SqlClient;

namespace AdoNetHarjoitus
{
    class Program
    {
        static void Main(string[] args)
        {
            string myServerAddress = @"localhost\SQLEXPRESS";
            string myDataBase = "Northwind";
            string connectionString = $"Server={myServerAddress};Database={myDataBase};Trusted_Connection=True;";

            // Etsitään Suomalaiset asiakkaat
            string queryString = "SELECT * FROM Customers WHERE Country='Finland'";

            SqlConnection sc = new(connectionString);
            SqlCommand command = new(queryString, sc);

            // Avataan yhteys
            sc.Open();

            Console.WriteLine($"Connected to database {myDataBase}.");
            SqlDataReader reader = command.ExecuteReader();

            // Tulostetaan löydetyt nimet
            Console.WriteLine("Customers from Finland:");
            while (reader.Read())
            {
                string name = reader["CompanyName"].ToString();
                Console.WriteLine(name);
            }

            reader.Close();

            // Aloitetaan uuden entryn lisäys
            Console.WriteLine("Add a row to the Northwind customers database. Fill the following information:");

            string customerID = "";
            string idQueryString = "SELECT CustomerID FROM Customers";
            
            // Kysytään uniikkia IDtä
            bool idInUse = true;
            while (idInUse)
            {
                Console.WriteLine("Customer ID (5 character, only letters and numbers):");
                customerID = Console.ReadLine();
                idInUse = true;

                // Vertaa nykyisten asiakkaiden IDn kanssa, kysy uudestaan jos ID on jo käytössä
                command = new(idQueryString, sc);
                SqlDataReader idReader = command.ExecuteReader();
                while (idReader.Read())
                {
                    string currentIDs = idReader["CustomerID"].ToString();
                    idInUse = false;
                    if(customerID == currentIDs)
                    {
                        idInUse = true;
                        Console.WriteLine("Customer ID already in use! Try again.");
                        break;
                    }
                }
                idReader.Close();
            }

            // Kysytään loput tiedot
            Console.WriteLine("Company name:");
            string companyName = Console.ReadLine();

            Console.WriteLine("Contact name:");
            string contactName = Console.ReadLine();

            Console.WriteLine("Contact title:");
            string contactTitle = Console.ReadLine();

            Console.WriteLine("Address:");
            string address = Console.ReadLine();

            Console.WriteLine("City:");
            string city = Console.ReadLine();

            Console.WriteLine("Region:");
            string region = Console.ReadLine();

            Console.WriteLine("Postal Code:");
            string postalCode = Console.ReadLine();

            Console.WriteLine("Country:");
            string country = Console.ReadLine();

            Console.WriteLine("Phone:");
            string phone = Console.ReadLine();

            Console.WriteLine("Fax:");
            string fax = Console.ReadLine();

            Console.WriteLine($"Adding new row: {customerID}, {companyName}, {contactName}, {contactTitle}, {address}, {city}, {region}, {postalCode}, {country}, {phone}, {fax}");

            // Syötä annetut arvot
            string insertString = $"INSERT INTO Customers (CustomerID,CompanyName,ContactName,ContactTitle,Address,City,Region,PostalCode,Country,Phone,Fax)" +
                $" VALUES ('{customerID}','{companyName}','{contactName}','{contactTitle}','{address}','{city}','{region}','{postalCode}','{country}','{phone}','{fax}')";
            command = new(insertString, sc);
            command.ExecuteNonQuery();

            // Suljetaan yhteys
            sc.Close();
            Console.WriteLine("Connection closed.");
        }
    }
}
