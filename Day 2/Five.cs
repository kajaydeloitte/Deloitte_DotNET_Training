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
            Console.WriteLine("Working with TypeCasting in C#");

            // Implicit TypeCasting
            short x = 200;
            int y = x;  //  short to int 

            System.Object obj;
            obj = y;   //  int  to  Object  ,  Boxing





            //------------------------------------------------------
            // Explicit TypeCasting

            //1. Using Parse Method --  string to other types
            int age = int.Parse("25");


            // 2. Convert Class Methods
            // Appicable to all types
            int sid = Convert.ToInt32("4565");
            string str = Convert.ToString(123);

            //  3. Boxing and Unboxing
            int z = (int)obj;   // unboxing

            Console.WriteLine("The value of x (short) : " + x);
            Console.WriteLine("The value of y : " + y);
            Console.WriteLine("The value of age : " + age);
            Console.WriteLine("The value of sid : " + sid);
            Console.WriteLine("The value of str : " + str);
            Console.WriteLine("The value of z : " + z);


        }
    }
}
