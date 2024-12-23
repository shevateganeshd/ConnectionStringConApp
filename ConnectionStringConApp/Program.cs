using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace ConnectionStringConApp
{
    internal class DatabaseConnection
    {
        readonly string connectionString = "Data Source=DESKTOP-S87FPOF\\SQLEXPRESS;" +
            "Initial Catalog=CRM;" +
            "UID=sa;" +
            "Password=ABC@;" +
            "Integrated Security=True;" +
            "Trusted_Connection=True;" +
            "Connection Timeout=30;" +
            "Encrypt = True;" +
            "TrustServerCertificate=True;" +
            "Persist Security Info = True;" +
            "Application Name=MyApplication;" +
            "MultipleActiveResultSets=True;" +
            "Pooling = True;" +
            "Max Pool Size=100;" +
            "Min Pool Size=10;";
            //    +
            //"Provider = System.Data.SqlClient;" +
            //"Charset = utf8;" +
            //"SSL Mode = Require;";

        internal void GetConnection()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                Console.WriteLine("Connection State : "+con.State);
                string query = "SELECT * FROM Employee";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine($"ID: {reader["Id"]}, Name: {reader["Name"]}, Address: {reader["Address"]}, Phone: {reader["PhoneNo"]}, BirthDate: {reader["BirthDate"]}, IsActive: {reader["IsActive"]}");
                    }
                }
                con.Close();
                Console.WriteLine("Connection State : " + con.State);                
            }
        }
    }
    internal class Program
    {   
        static void Main(string[] args)
        {
            Console.WriteLine("CONNECTION STRING PARAMETERS AND ITS USE");
            Console.WriteLine("1. Data Source/Server=DESKTOP-S87FPOF\\SQLEXPRESS,1433; | MSSQL/MySQL/PostreSQL Server Name,PortNo");
            Console.WriteLine();
            Console.WriteLine("2. Initial Catalog=CRM; | Database Name");
            Console.WriteLine();
            Console.WriteLine("3. UID=sa; | Username OR UserId");
            Console.WriteLine();
            Console.WriteLine("4. Password=ABC@; | Password");
            Console.WriteLine();
            Console.WriteLine("5. Integrated Security=True; | True if using Windows Authentication (no User Id or Password required). Set to False if using SQL Authentication");
            Console.WriteLine();
            Console.WriteLine("6. Trusted_Connection=True; | Enabling Windows Authentication");
            Console.WriteLine();
            Console.WriteLine("7. Connection Timeout=30; | Seconds application will wait to establish a connection before throwing an error");
            Console.WriteLine();
            Console.WriteLine("8. Encrypt = True; | Secure the connection with encryption");
            Console.WriteLine();
            Console.WriteLine("9. TrustServerCertificate=True; | When connecting via SSL but the server's certificate can't be validated");
            Console.WriteLine();
            Console.WriteLine("10. Persist Security Info = True; | Want to retain sensitive connection details (e.g. password) after the connection is opened. Typically set to False for security");
            Console.WriteLine();
            Console.WriteLine("11. Application Name=MyApplication; | Identify the application in database logs for tracking and monitoring");
            Console.WriteLine();
            Console.WriteLine("12. MultipleActiveResultSets=True; | When needed multiple queries to execute on the same connection simultaneously (e.g. fetching and updating data in parallel)");
            Console.WriteLine();
            Console.WriteLine("13. Pooling = True; | Enable connection pooling, which improves performance by reusing existing connections");
            Console.WriteLine();
            Console.WriteLine("14. Max Pool Size=100; | Maximum number of connections allowed in the connection pool");
            Console.WriteLine();
            Console.WriteLine("15. Min Pool Size=10; | Minimum number of connections allowed in the connection pool");
            Console.WriteLine();
            Console.WriteLine("16. Provider = System.Data.SqlClient; | Specify the database provider (e.g. System.Data.SqlClient for SQL Server)");
            Console.WriteLine();
            Console.WriteLine("17. Charset = utf8; | Specifies character encoding (e.g. utf8)");
            Console.WriteLine();
            Console.WriteLine("18. SSL Mode = Require; | Defines SSL behavior (e.g. Require)");            
            Console.WriteLine();
            DatabaseConnection dataConnection = new DatabaseConnection();
            dataConnection.GetConnection();
            Console.ReadKey();
        }
    }
}
