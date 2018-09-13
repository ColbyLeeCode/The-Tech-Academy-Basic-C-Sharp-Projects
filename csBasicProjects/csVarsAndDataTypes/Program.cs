/* A mock daily report for students of The Tech Academy.
   C# & .Net Step 57                                    */

using System;


namespace VariablesAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");

            Console.Write("\n Which course are you on? : ");
            string course = Console.ReadLine();

            Console.Write("\n Which page are you on(#)? : ");
            int page = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n Do you need help with anything? Please answer “true” or “false”: ");
            bool needHelp = Convert.ToBoolean(Console.ReadLine());

            Console.Write("\n Were there any positive experiences you’d like to share? Please give specifics. : ");
            string experiences = Console.ReadLine();

            Console.Write("\n Is there any other feedback you’d like to provide? Please be specific. : ");
            string feedback = Console.ReadLine();

            Console.Write("\n How many hours did you study today? : ");
            SByte studyHours = Convert.ToSByte(Console.ReadLine());



            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.Read();
        }
    }
}
