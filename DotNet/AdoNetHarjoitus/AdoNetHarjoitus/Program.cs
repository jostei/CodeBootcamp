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
                string companyName = reader["CompanyName"].ToString();
                Console.WriteLine(companyName);
            }

            // Closing connection
            sc.Close();
            Console.WriteLine("Connection closed.");
        }
    }
}
