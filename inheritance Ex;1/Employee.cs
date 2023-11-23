using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_Ex_1
{
    public class Employee  //base class // Parent class 
    {
        public string Firstname;   //
        public string Lastname;   //        this all are coman Property of base cla
        public string Email;        //
        public float hourlysalry;       //
        public float yearlysalay;   //      
        //we using public keyword thats way we use the all propery all places if use privet 
        //that time we cant able to use this propery other place 

        public void PrintFullname()
        {
            Console.WriteLine($"{Firstname}  {Lastname} {yearlysalay}{hourlysalry} ");
        }

    }
}
