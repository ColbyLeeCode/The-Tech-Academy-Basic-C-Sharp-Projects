/*Loops and Lists Labs for The Tech Academy*/
using System;
using System.Collections.Generic;


namespace LoopsListsLab
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Create a one-dimensional Array of strings. Ask the user to input some 
             * text. Create a loop that goes through each string in the Array, adding
             * the user’s text to the string. Then create a loop that prints off each 
             * string in the Array on a separate line.*/
            string[] strings = { "one", "two", "three", "four", "five" };

            Console.WriteLine("Input a string to add to all strings in the arry.");
            string input = Console.ReadLine();
            //Add user input to every string
            for (int i = 0; i < strings.Length; i++)
                strings[i] = String.Concat(strings[i], input);
            Console.WriteLine("Array after concatination: ");
            for (int i = 0; i < strings.Length; i++)
                Console.WriteLine("[" + i + "] " + strings[i]);
            

            /* Create an infinite loop.*/
            //for (int i = 1; i > 0; i++)
            //{
            //    Console.WriteLine("This is infinite");
            //}

            /* This is no longer infinite*/
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("This is NOT infinite");
            }

            /*Create a loop where the comparison used to determine whether to continue 
             * iterating the loop is a “<” operator.*/
            for (int i = 0; i < 10; i++)
                Console.WriteLine("["+i+"]" + "This loops compares using the < operator");

            /*Create a loop where the comparison used to determine whether to continue 
             * iterating the loop is a “<=” operator.*/
            for (int i = 0; i <= 9; i++)
                Console.WriteLine("[" + i + "]" + "This loops compares using the <= operator");


            /*Create a List of strings where each item in the list is unique. Ask the user 
             * to select text to search for in the List. Create a loop that iterates through 
             * the loop and then displays the index of the array that contains matching text 
             * on the screen.*/
            string[] moreStrings = { "one", "two", "three", "four", "five" };

            Console.WriteLine("What text should I search for in the string array? ");
            input = Console.ReadLine();


            bool match = false;
            for (int i = 0; i < moreStrings.Length; i++)
                if (moreStrings[i].Equals(input))
                {
                    match = true;
                    Console.WriteLine("Found string at index[" + i + "]:" + moreStrings[i]);
                    //stop executing once a match has been found.
                    break;    
                }
            //tells a user if they put in text that isn’t in the List.
            if (!match)
                Console.WriteLine("Your input wasn't found in the array.");

            /*Create a List of strings that has at least two identical strings in the List. Ask the user to 
             * select text to search for in the List. Create a loop that iterates through the loop and then
             * displays the indices of the array that contain matching text on the screen.*/
            int count = 0;
            match = false;
            List<string> stringList = new List<string>();
            stringList.Add("same string");
            stringList.Add("same string");
            stringList.Add("same string");
            stringList.Add("dif string");
            stringList.Add("dif string");
            stringList.Add("different string");
            stringList.Add("12-0391-2093");

            
            Console.WriteLine("Search List of Strings for what?: ");
            input = Console.ReadLine();
            Console.WriteLine("The following contain: " + input);
            foreach (string str in stringList)
            {
                if (str.Equals(input))
                {
                    match = true;
                    Console.WriteLine(count);
                }
                count++; 
            }
            if (!match)//tells a user if they put in text that isn’t in the List.
                Console.WriteLine("That string was not found in the array");


            /*Create a List of strings that has at least two identical strings in the List. Create a 
             * foreach loop that evaluates each item in the list, and displays a message showing the string
             * and whether or not it has already appeared in the list.*/
            match = false;
            List<string> repeats = new List<string>();
            stringList = new List<string>();
            stringList.Add("same string");
            stringList.Add("same string");
            stringList.Add("same string");
            stringList.Add("dif string");
            stringList.Add("dif string");
            stringList.Add("different string");
            stringList.Add("12-0391-2093");

            Console.WriteLine("String|Repeat?");
            foreach (string str in stringList)
            {
                foreach (string inner in repeats)
                    if (inner.Equals(str))
                        match = true;
                Console.WriteLine(str + " | " + match);
                repeats.Add(str);
                match = false;
            }

            Console.Read();

        }
    }
}
