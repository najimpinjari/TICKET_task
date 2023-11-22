using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /* SilverCustomer Sc1 = new SilverCustomer();
            Sc1.ShowTimings();
            Sc1.GetTickitAmount();
            Sc1.PrintTickit();

            GoldCustomer gc1 = new GoldCustomer();
            gc1.ShowTimings();
            gc1.GetTickitAmount();
            gc1.Printticket();
             
            PlatinumClass pc1 = new PlatinumClass();
            pc1.ShowTimings();
            pc1.GetTickitAmount();
            pc1.PrintTicket();
            */
          //  Customers1 c1 = new Customers1(); 

            Customers1 c2 = new SilverCustomer(); 
           

            Console.ReadLine();
        }
    }
}
