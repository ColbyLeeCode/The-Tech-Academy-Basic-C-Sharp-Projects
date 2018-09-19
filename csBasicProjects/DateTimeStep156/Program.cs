/*Date Time step 156 for The Tech Academy*/
using System;

namespace DateTimeStep156
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("Please input a number: ");
            int input = Convert.ToInt32(Console.ReadLine());

            DateTime now = DateTime.Now;
            DateTime later = now.AddHours(input);
            Console.WriteLine("Time in {0} hours: {1}", input, later.TimeOfDay);
            Console.Read();
        }
    }
}
