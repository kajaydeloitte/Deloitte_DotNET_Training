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

            string cmdText = "SELECT * FROM product";

            SqlDataAdapter adapter = new SqlDataAdapter(cmdText, connStr);
            DataSet ds = new DataSet();

            adapter.Fill(ds);

            foreach (DataRow dataReader in ds.Tables[0].Rows)
            {
                Console.WriteLine("{0},{1},{2},{3},{4}", dataReader[0].ToString(), dataReader[1].ToString(), dataReader[2].ToString(), dataReader[3].ToString(), dataReader[4].ToString());
            }

        }
    }
}
