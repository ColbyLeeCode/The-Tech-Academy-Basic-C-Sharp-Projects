/*Branching Lab for The Tech Academy*/

using System;


namespace BranchingLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Package weight:");
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Package width:");
            double width = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Package height:");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Package length:");
            double length = Convert.ToDouble(Console.ReadLine());

            double total = (width + height + length) * weight / 100;
            if (total > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express");
                Console.Read();
                return;
            }
            else
            {
                Console.WriteLine("Your estimated total for shipping this package is: $" + string.Format("{0:#.00}", Convert.ToDecimal(total)));
                Console.WriteLine("Thank you.");
                Console.Read();
            }
        }
    }
}
