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
            int deptNumber;

            System.Console.WriteLine("Enter Dept Number : ");
            deptNumber = int.Parse(Console.ReadLine());

            switch (deptNumber)
            {
                case 10:
                    Console.WriteLine("You are belongs to ACCOUNTS Dept located in Hyderabad");
                    break;

                case 20:
                    Console.WriteLine("You are belongs to SALES Dept located in Mumbai");
                    break;

                case 30:
                    Console.WriteLine("You are belongs to MARKETING Dept located in Chennai");
                    break;

                default:
                    Console.WriteLine("Invalid Dept Number");
                    break;
            }

        }
    }
}
