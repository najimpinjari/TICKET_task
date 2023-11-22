using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class PlatinumClass : Customers1
    {
        public PlatinumClass() 
        {
            Console.WriteLine("PlatinumClass() Cunstructor Called ");
            TickitAmout = 450;

        }
        public void PrintTicket()
        {
            Console.WriteLine("Platinum Ticket printed ");
        }
    }
}
