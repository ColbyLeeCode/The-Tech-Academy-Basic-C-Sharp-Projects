using System;

namespace AbsractionStep124
{
    class Employee : Person
    {
        
        int Id = 0;

        //Calls the base constructor (Person)
        public Employee(string FirstName, string LastName) : base(FirstName, LastName)
        {
            
        }

        //Override the  
        public override void SayName()
        {
            Console.WriteLine("Name: " + "[" + base.FirstName + " " + base.LastName + "]");
        }
    }
}