using System;

namespace AbsractionStep124
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee("Sample", "Student");
            emp.SayName();

            Console.Read();
        }
    }
}
