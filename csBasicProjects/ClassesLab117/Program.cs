using System;


namespace ClassesLab117
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Enter a number. Call the method using that number as input. Display the entered number, divided by two.*/
            Console.WriteLine("Input number to be divided by 2 and then passed out via a parameter: ");
            int input = Convert.ToInt32(Console.ReadLine());
            int one, two, output;
            
            
            MyClass myClass = new MyClass();
            myClass.outInt(out output, input);
            Console.WriteLine("Number after dividing: " + output);
            Console.WriteLine("Please enter two int values on the next two lines: ");
            myClass.assignValues(out one, out two);
            Console.WriteLine("Assigned values plus addition: " + one + ", " + two);

            Console.WriteLine(MyStaticClass.check());
            Console.Read();
        }
    }
}
