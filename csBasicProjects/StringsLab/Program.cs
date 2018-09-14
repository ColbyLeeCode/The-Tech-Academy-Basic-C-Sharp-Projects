/*Strings lab for The Tech Academy*/

using System;
using System.Text;


namespace StringsLab
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "My name is ", s2 = "Bob ", s3 = "LeFour";
            string total = s1 + s2 + s3;

            Console.WriteLine(total);

            Console.WriteLine(total.ToUpper());

            int count = 0;
            StringBuilder paragraph = new StringBuilder();
            while (count < 5)
            {
                Console.WriteLine("Next sentence please: ");
                paragraph.Append(Console.ReadLine() + " ");
                count++;
            }

            Console.WriteLine(paragraph);
            Console.Read();
        }
    }
}
