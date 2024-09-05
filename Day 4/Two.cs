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


            conn.Open();
            Console.WriteLine("Connected to Database successfully");

            string cmdText = "SELECT * FROM product";

            SqlCommand cmd = new SqlCommand(cmdText, conn);

            SqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read() == true)
            {
                //   Console.WriteLine("{0},{1},{2}", dataReader[0].ToString(), dataReader[1].ToString(), dataReader[2].ToString());

                Console.WriteLine("{0},{1},{2},{3},{4}", dataReader[0].ToString(), dataReader[1].ToString(), dataReader[2].ToString(), dataReader[3].ToString(), dataReader[4].ToString());

            }

            conn.Close();

        }
    }
}
