/*Arrays Lab 1 for The Tech Academy*/
using System;
using System.Linq;
using System.Collections.Generic;

namespace _1DArrayLab
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Create a one-dimensional Array of strings. Ask the user to 
             * select an index of the Array and then display the string at 
             * that index on the screen.*/
            string[] strings = new string[5];
            strings[0] = "First string.";
            strings[1] = "Second string.";
            strings[2] = "Third string.";
            strings[3] = "Fourth string.";
            strings[4] = "Fifth string.";
            Console.WriteLine("Index: ");
            int index = Convert.ToInt32(Console.ReadLine());
            if (strings.ElementAtOrDefault(index) == null)
                Console.WriteLine("Sorry that index doesn't exist");
            else 
                Console.WriteLine(strings[index]);

            /*Create a one-dimensional Array of integers. Ask the user to 
             * select an index of the Array and then display the integer 
             * at that index on the screen.*/
            int[] ints = new int[5];
            ints[0] = 1;
            ints[1] = 2;
            ints[2] = 3;
            ints[3] = 4;
            ints[4] = 5;

            Console.WriteLine("Index: ");
            index = Convert.ToInt32(Console.ReadLine());
            //Check if the index exists in the array
            if(index > ints.Length - 1 || index < 0)
                Console.WriteLine("Sorry that index doesn't exist");
            else
                Console.WriteLine(ints[index]);


            /*Create a List of strings. Ask the user to select an index of 
             * the List and then display the content at that index on the screen.*/
            List<string> list = new List<string>();
            list.Add("list element one.");
            list.Add("list element two.");
            list.Add("list element three.");
            list.Add("list element four.");
            list.Add("list element five.");

            Console.WriteLine("Index: ");
            index = Convert.ToInt32(Console.ReadLine());
            if (list.ElementAtOrDefault(index) == null)
                Console.WriteLine("Sorry that index doesn't exist");
            else
                Console.WriteLine(list[index]);

            Console.Read();
        }

    }
}
