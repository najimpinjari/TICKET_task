using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Customers1 // parent class  /base class in opps language 
    {
             public int TickitAmout;         //field
        public string name = "Customer sham";

        public Customers1()
        {
            Console.WriteLine("Customer() Cunstructor Called ");
        }
        public void ShowTimings()
        {
            Console.WriteLine("**All Todyas Shows ");
        }

        public void GetTickitAmount()
        {
            Console.WriteLine($"Silver Tickit Amount is ; {TickitAmout}");
        }   




    }
}
