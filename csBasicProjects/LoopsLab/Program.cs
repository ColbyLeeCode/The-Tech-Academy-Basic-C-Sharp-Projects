/*Loobs Lab for The Tech Academy*/
using System;


namespace LoopsLab
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            int count = 0;
            Console.WriteLine("Counting with while loop:");
            while (run)
            {
                if (count < 10)
                {
                    Console.WriteLine(count);
                    count++;
                }
                else
                {
                    run = false;
                }
            }


            Console.WriteLine("Counting with do while loop:");
            run = true;
            count = 0;
            do
            {
                if (count < 10)
                {
                    Console.WriteLine(count);
                    count++;
                }
                else
                {
                    run = false;
                }
            } while (run);
            Console.Read();
        }
    }
}
