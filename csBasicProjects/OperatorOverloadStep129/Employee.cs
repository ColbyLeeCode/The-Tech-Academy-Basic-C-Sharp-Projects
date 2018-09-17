using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloadStep129
{
    class Employee : Person
    {

        public int Id = 0;

        //Calls the base constructor (Person)
        public Employee(string FirstName, string LastName) : base(FirstName, LastName)
        {

        }

        public static bool operator== (Employee a, Employee b)
        {
            return a.Id == b.Id;
        }

        public static bool operator!= (Employee a, Employee b)
        {
            return a.Id != b.Id;
        }

        public void Quit()
        {
            Console.WriteLine("Press Enter to Exit... BYE!");
            Console.Read();
            Environment.Exit(0);
        }

        //Override base method 
        public override void SayName()
        {
            Console.WriteLine("Name: " + "[" + base.FirstName + " " + base.LastName + "]");
        }
    }
}
