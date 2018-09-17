/*Enums step 134 for The Tech Academy*/

using System;
using System.Linq;

namespace EnumsStep134
{
    class Program
    {
        static void Main(string[] args)
        {
            DaysOfWeek day = getInput();

            Console.WriteLine("Day of week: " + day);
            Console.ReadLine();
        }

        public static DaysOfWeek getInput()
        {
            DaysOfWeek input;

            Start:
            try
            {

                Console.WriteLine("Please select a day of the week: ");
                string rawInput = Console.ReadLine();
                if (rawInput.All(char.IsDigit))
                    throw new Exception();
                input = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), rawInput);


            }
            catch (Exception e)
            {
                Console.WriteLine("Please enter an actual day of the week.");
                goto Start;
            }

            return input;
        }
    }

    enum DaysOfWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
}
