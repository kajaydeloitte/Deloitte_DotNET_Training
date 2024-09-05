using System.Data.SqlClient;
using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connStr = "Server=USHYDKAJAY6; Database=ajay; Integrated Security=true";

            SqlConnection conn = new SqlConnection(connStr);
            // conn.ConnectionString = connStr;

            string cmdText = "Create Table product(productid int,name varchar(18),price int, quantity int, category varchar(18))";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = cmdText;

            conn.Open();
            Console.WriteLine("Connected to Database successfully");

            int n = cmd.ExecuteNonQuery();  // For DML:  Insert, update, delete

            Console.WriteLine("No. of rows affected :" + n);

            cmd.CommandText = "insert into product values(1,'a',10,5,'z'),(2,'b',20,6,'y'),(3,'c',30,7,'x'),(4,'d',40,8,'z'),(5,'e',50,9,'y'),(6,'f',60,10,'x')";

            int n1 = cmd.ExecuteNonQuery();

            Console.WriteLine("No. of rows affected :" + n);

            conn.Close();

            Console.ReadLine();
        }
    }
}
