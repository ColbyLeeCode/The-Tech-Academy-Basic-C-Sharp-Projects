using System;

namespace ClassesLab113
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();

            //Call the method in the class, passing in two numbers.
            myClass.myMethod(1, 2);

            //Call the method in the class, specifying the parameters by name.
            myClass.myMethod(y: 1, x: 30);

            Console.ReadLine();
        }
    }
}
