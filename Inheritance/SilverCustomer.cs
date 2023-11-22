using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{

    // Child class  / derived class 
    public class SilverCustomer : Customers1
    {
        //public int TickitAmout;         //field
        public string name = "silver customer";

        public SilverCustomer()         //Const ructor 
        {
            Console.WriteLine("SilverCustomer() Cunstructor Called ");
            Console.WriteLine($"Name from currant class  ; {this.name}");
            Console.WriteLine($"Name from base class  ; {base.name}");

            TickitAmout = 150;
        }
        /*  public void ShowTimings()
          {
            Console.WriteLine("**All Todyas Shows ");
          }*/
        
       /* public void GetTickitAmount()
        {
            Console.WriteLine($"Silver Tickit Amount is ; {TickitAmout}");
        }*/

        public void PrintTickit()
        {
            Console.WriteLine("Silver Tickit Printed ");    
        }

    }
}
