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
            string name, id ;
            int quantity, price, amount, damount, famount;
            id = Console.ReadLine();
            name = Console.ReadLine();
            price = int.Parse(Console.ReadLine());
            quantity = int.Parse(Console.ReadLine());
            amount = price* quantity;

            if(quantity>10 && quantity < 21)
            {
                damount=amount-((amount*10)/100);
            }
            else if(quantity>20 && quantity < 31)
            {
                damount = amount - ((amount * 20 )/100);
            }
            else if(quantity>30 && quantity < 41)
            {
                damount = amount - ((amount * 30) / 100);
            }
            else
            {
                damount = 0;
            }

            Console.WriteLine("Total Amount : {2}, Discount Amount : {0}, Final Amount : {1}", damount, amount - damount, amount);

      
        }
    }
}
