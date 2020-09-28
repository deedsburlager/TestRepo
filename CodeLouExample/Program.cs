using System;
using System.Data.SqlClient;

namespace CodeLouExample
{
    class Program
    {
        static void Main(string[] args)
        {
            GetData();
            //InsertData();
        }

        //to do: use a better name
        static string GetData()
        {
            SqlConnection connection = new SqlConnection("Server=DESKTOP-IA957IQ\\SQLEXPRESS;Database=HospitalProject;Trusted_Connection=True;");

            connection.Open();

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "SELECT * FROM Doctor";
            sqlCommand.Connection = connection;

            var reader = sqlCommand.ExecuteReader();

            while(reader.Read())
            {
                string drName = reader.GetString(0);
            }

            return "";
        }

        static void InsertData()
        {
            string drNameFromUser = Console.ReadLine();


            SqlConnection connection = new SqlConnection("Server=DESKTOP-IA957IQ\\SQLEXPRESS;Database=HospitalProject;Trusted_Connection=True;");

            connection.Open();

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "INSERT INTO Doctor VALUES ('" + drNameFromUser + "')";
            sqlCommand.Connection = connection;

            sqlCommand.ExecuteNonQuery();
        }

    }
}
