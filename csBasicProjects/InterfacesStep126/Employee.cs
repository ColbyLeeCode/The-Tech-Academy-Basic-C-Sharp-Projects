using System;

namespace InterfacesStep126
{
 
        class Employee : Person, IQuittable
        {

            int Id = 0;

            //Calls the base constructor (Person)
            public Employee(string FirstName, string LastName) : base(FirstName, LastName)
            {

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
