/*File IO step 154 for The Tech Academy*/

using System;
using System.IO;


namespace FileIOStep154
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a number here: ");
            string input = Console.ReadLine();

            using (StreamWriter file = new StreamWriter(@"sample.txt", true))
            {
                //write the line to the text file
                file.Write(input);
            }

            using (StreamReader file = new StreamReader("sample.txt"))
            {
                //read the text file back to the user
                Console.WriteLine("File Contents: ");
                Console.WriteLine(file.ReadToEnd());
            }

            Console.Read();

        }
    }
}
