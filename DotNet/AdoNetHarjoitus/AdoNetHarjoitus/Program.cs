﻿using System;
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
            Customer c = ReadInfo();
            c.CustomerID = customerID;

            // Parametrisoitu syöte
            string insertString = $"INSERT INTO Customers (CustomerID,CompanyName,ContactName,ContactTitle,Address,City,Region,PostalCode,Country,Phone,Fax)" +
                $" VALUES (@customerID,@companyName,@contactName,@contactTitle,@address,@city,@region,@postalCode,@country,@phone,@fax)";

            command = new(insertString, sc);
            command.Parameters.AddWithValue("@customerID", c.CustomerID);
            command.Parameters.AddWithValue("@companyName", c.CompanyName);
            command.Parameters.AddWithValue("@contactName", c.ContactName);
            command.Parameters.AddWithValue("@contactTitle", c.ContactTitle);
            command.Parameters.AddWithValue("@address", c.Address);
            command.Parameters.AddWithValue("@city", c.City);
            command.Parameters.AddWithValue("@region", c.Region);
            command.Parameters.AddWithValue("@postalCode", c.PostalCode);
            command.Parameters.AddWithValue("@country", c.Country);
            command.Parameters.AddWithValue("@phone", c.Phone);
            command.Parameters.AddWithValue("@fax", c.Fax);

            command.ExecuteNonQuery();

            // Suljetaan yhteys
            sc.Close();
            Console.WriteLine("Connection closed.");
        }

        // Luodaan uusi käyttäjä
        private static Customer ReadInfo()
        {
            Customer customer = new();

            Console.WriteLine("Company name:");
            customer.CompanyName = Console.ReadLine();

            Console.WriteLine("Contact name:");
            customer.ContactName = Console.ReadLine();

            Console.WriteLine("Contact title:");
            customer.ContactTitle = Console.ReadLine();

            Console.WriteLine("Address:");
            customer.Address = Console.ReadLine();

            Console.WriteLine("City:");
            customer.City = Console.ReadLine();

            Console.WriteLine("Region:");
            customer.Region = Console.ReadLine();

            Console.WriteLine("Postal Code:");
            customer.PostalCode = Console.ReadLine();

            Console.WriteLine("Country:");
            customer.Country = Console.ReadLine();

            Console.WriteLine("Phone:");
            customer.Phone = Console.ReadLine();

            Console.WriteLine("Fax:");
            customer.Fax = Console.ReadLine();
            return customer;
        }
    }
}
