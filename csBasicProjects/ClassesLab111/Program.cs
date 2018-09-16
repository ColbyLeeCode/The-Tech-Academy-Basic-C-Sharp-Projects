/*Step 111 C# & .Net for The Tech Academy*/

using System;


namespace ClassesLab111
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ask the user what number they want to do the math operations on.*/
            Console.WriteLine("What number would you like to perfrom calculations on? ");
            int input = Convert.ToInt32(Console.ReadLine());

            /*Display the returned integer to the screen.*/
            Console.WriteLine(MyClass.addTwo(input));
            Console.WriteLine(MyClass.subTwo(input));
            Console.WriteLine(MyClass.divTwo(input));

            Console.Read();
        }
    }
}
