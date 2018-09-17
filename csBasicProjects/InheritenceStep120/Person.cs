using System;

namespace InheritenceStep120
{
    class Person
    {
        string FirstName;
        string LastName;

        public Person(string FirstName, string LastName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
        }

        public void SayName()
        {
            Console.WriteLine("Name: " + "[" + FirstName + " " + LastName + "]");
        }
    }
}