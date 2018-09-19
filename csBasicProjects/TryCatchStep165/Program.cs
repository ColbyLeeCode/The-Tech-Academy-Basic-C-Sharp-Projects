/*Try Catch step 165*/
using System;


namespace TryCatchStep165
{
    class Program
    {
        static void Main(string[] args)
        {
            Start:
            Console.WriteLine("Please enter your age:");
            int input = 0;
            try
            {
                input = Convert.ToInt32(Console.ReadLine());
                if (input < 1)
                    throw new InvalidOperationException();
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("Please do not enter a value lower than 1");
                goto Start;
            }
            catch (Exception)
            {
                Console.WriteLine("Please only enter digits.");
                goto Start;
            }
            
            Console.WriteLine("User was born in: " + DateTime.Now.AddYears(-input).Year);
            Console.ReadLine();



        }
    }
}
