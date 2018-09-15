/*Exceptions Lab for The Tech Academy*/
using System;
using System.Collections.Generic;


namespace ExceptionsLab
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Create a list of integers. Ask the user for a number to divide each number 
             * in the list by. Write a loop that takes each integer in the list, divides 
             * it by the number the user entered, and displays the result to the screen.*/
            Console.WriteLine("Select a number to divide by: ");
            int input = Convert.ToInt32(Console.ReadLine());
            List<int> ints = new List<int>();
            ints.Add(1);
            ints.Add(2);
            ints.Add(3);
            ints.Add(4);
            ints.Add(5);
            ints.Add(6);

            foreach (double i in ints)
                Console.WriteLine(i / input);
       

            /* Now put the loop in a try/catch block. Below and outside of the try/catch block, 
             * make the program display a message to the display to let you know the program 
             * has emerged from the try/catch block and continued on with program execution. 
             * In the catch block, display the error message to the screen. Then try various 
             * combinations of user input: valid numbers, zero and a string. Ensure the proper 
             * error messages display on the screen, and that the code after the try/catch 
             * block gets executed.*/
            try
            {
                Console.WriteLine("Select a number to divide by: ");
                input = Convert.ToInt32(Console.ReadLine());
                foreach (int i in ints)
                {
                    int total = i / input;
                    Console.WriteLine(total);
                }
            }
            catch (FormatException e) { Console.WriteLine("Please input only numbers."); }
            catch (DivideByZeroException e) { Console.WriteLine("Please don't divide by zero."); }
            catch (Exception e) { Console.WriteLine(e.GetType()); }

            finally
            {
                Console.WriteLine("Try/Catch completed.");
            }

            Console.ReadLine();


        }
    }
}
