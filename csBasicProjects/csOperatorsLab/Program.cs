/*Drill for the C# and .NET course at the tech academy*/
using System;


namespace csOperatorsLab
{
    class Program
    {
        static void Main(string[] args)
        {
          
            /*Takes an input from the user, multiplies it by 50, and prints the result to the console. (Note: make sure your code can take inputs larger than 10, 000, 000).*/
            Console.WriteLine(getInput() * 50);
            /*Takes an input from the user, adds 25 to it, and prints the result to the console.*/
            Console.WriteLine(getInput() + 25);
            /*Takes an input from the user, divides it by 12.5, and prints the result to the console.*/
            Console.WriteLine(getInput() / 12.5);
            /*Takes an input from the user, checks if it is greater than 50, and prints the true / false result to the console.*/
            Console.WriteLine(getInput() > 50);
            /*Takes an input from the user, divides it by 7, and prints the remainder to the console(tip: think % operator).*/
            Console.WriteLine(getInput() % 7);
            Console.Read();
        }

        static double getInput()
        {
            Console.Write("Input Value: ");
            double input = Convert.ToDouble(Console.ReadLine());
            return input;
        }
    }
}
