using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLab111
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What number would you like to perfrom calculations on? ");
            int input = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(myClass.addTwo(input));
            Console.WriteLine(myClass.subTwo(input));
            Console.WriteLine(myClass.divTwo(input));

            Console.Read();
        }
    }
}
