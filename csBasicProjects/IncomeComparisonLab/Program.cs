/*Anonymous Salary Comparison Lab for The Tech Academy*/

using System;


namespace IncomeComparisonLab
{
    class Program
    {
        static void Main(string[] args)
        {
            double p1Rate, p1Hours, p1Sal, p2Rate, p2Hours, p2Sal;
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1: ");

            Console.Write("Hourly Rate: ");
            p1Rate = getInput();

            Console.Write("Hours worked per week: ");
            p1Hours = getInput();

            //Calculate Weekly salary
            p1Sal = p1Rate * p1Hours;

   

            Console.WriteLine("Person 2: ");

            Console.Write("Hourly Rate: ");
            p2Rate = getInput();

            Console.Write("Hours worked per week: ");
            p2Hours = getInput();

            //Calculate Weekly salary
            p2Sal = p2Rate * p2Hours;

            Console.WriteLine("Weekly salary of Person 1:\n" + p1Sal);
            Console.WriteLine("Weekly salary of Person 2:\n" + p2Sal);
            Console.WriteLine("Does Person 1 make more money than Person 2?\n" + (p1Sal > p2Sal));
            Console.Read();
        }

        static double getInput()
        {
            double input = Convert.ToDouble(Console.ReadLine());
            return input;
        }
    }
}
