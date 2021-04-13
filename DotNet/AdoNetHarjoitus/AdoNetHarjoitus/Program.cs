// Connects to a local database and executes and prints a query

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
            string queryString = "SELECT * FROM Customers WHERE Country='Finland'";

            SqlConnection sc = new(connectionString);
            SqlCommand command = new(queryString, sc);

            // Opening connection
            sc.Open();

            Console.WriteLine($"Connected to database {myDataBase}.");
            SqlDataReader reader = command.ExecuteReader();

            // Print all found company names
            while (reader.Read())
            {
                string name = reader["CompanyName"].ToString();
                Console.WriteLine(name);
            }

            reader.Close();

            // Add new customer ot database
            Console.WriteLine("Add a row to the Northwind customers database. Fill the following information:");

            string customerID = "";

            /*
            string idQueryString = "SELECT CustomerID FROM Customers";
            SqlCommand idQuery = new(idQueryString, sc);
            string currentIDs = reader["CustomerID"].ToString();
            */

            bool idInUse = true;
            while (idInUse)
            {
                Console.WriteLine("Customer ID:");
                customerID = Console.ReadLine();
                idInUse = false;

                /*
                SqlDataReader idReader = idQuery.ExecuteReader();
                while (idReader.Read())
                {
                    
                    idInUse = false;
                    if(customerID == currentIDs)
                    {
                        idInUse = true;
                        Console.WriteLine("Customer ID already in use! Try again.");
                    }
                }
                idReader.Close();
                */
            }

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

            Console.WriteLine($"Adding new entry: {customerID},{companyName},{contactName},{contactTitle},{address},{city},{region},{postalCode},{country},{phone},{fax}");

            string insertString = $"INSERT INTO Customers (CustomerID,CompanyName,ContactName,ContactTitle,Address,City,Region,PostalCode,Country,Phone,Fax)" +
                $" VALUES ('{customerID}','{companyName}','{contactName}','{contactTitle}','{address}','{city}','{region}','{postalCode}','{country}','{phone}','{fax}')";
            command = new(insertString, sc);
            command.ExecuteNonQuery();

            // Closing connection
            sc.Close();
            Console.WriteLine("Connection closed.");
        }
    }
}
