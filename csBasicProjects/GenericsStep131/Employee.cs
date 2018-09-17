using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsStep131
{
    class Employee<T> : Person
    {

        public int Id = 0;
        public List<T> Things = new List<T>();

        //Calls the base constructor (Person)
        public Employee()
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
