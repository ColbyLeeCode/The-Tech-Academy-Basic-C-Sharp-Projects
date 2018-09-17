

namespace InheritenceStep120
{
    class Employee : Person
    {
        //ID number would need to be set after object creation
        int Id = 0;

        //Calls the base constructor (Person)
        public Employee(string FirstName, string LastName) : base(FirstName, LastName)
        {
            //blank
        }

 
    }
}