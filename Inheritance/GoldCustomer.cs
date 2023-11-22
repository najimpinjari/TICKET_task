using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class GoldCustomer : Customers1
    {
       // public int TicketAmount;

        public GoldCustomer()
        {
            Console.WriteLine("GoldCustomer() Cunstructor Called ");
            TickitAmout = 220;  
        }


        /*  public void ShowTimings()
          {
              Console.WriteLine(" $$ -- All Todays Shwos $$");

          }

          public void GetTickitAmount()
          {
              Console.WriteLine($"Ticket Amount is  ; {TicketAmount}");
          }*/


        public void Printticket()
        {
            Console.WriteLine("Gold ticket printed");   
        }
    }
}
