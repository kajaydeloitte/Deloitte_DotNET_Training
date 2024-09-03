using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter User Id : ");
            string uid = Console.ReadLine();

            Console.WriteLine("Enter Password : ");
            string pwd = Console.ReadLine();


            if (uid == "admin" && pwd == "admin123")
            {
                Console.WriteLine("Welcome to Admin");
            }
            else
            {
                Console.WriteLine("Invalid User Id or Password");
            }

        }
    }
}
