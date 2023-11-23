using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_Ex_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FulltimeEmployee FTE = new FulltimeEmployee();
            FTE.Firstname = "Abhishek";
            FTE.Lastname = "sutar";
            FTE.yearlysalay = 100000;
            FTE.PrintFullname();

            ParttimeEmployee PTE = new ParttimeEmployee();
            PTE.Firstname = "rupesh";
            PTE.Lastname = "raut";
            PTE.hourlysalry = 40000;
            PTE.PrintFullname();



            Console.ReadLine();

        }
    }
}
