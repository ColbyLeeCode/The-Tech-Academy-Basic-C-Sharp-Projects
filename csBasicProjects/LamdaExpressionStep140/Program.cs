/*Lambda Experssions Step 140 for The Tech Academy*/
using System;
using System.Collections.Generic;


namespace LamdaExpressionStep140
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();
            list.Add(new Employee("Joe", "Jones", 0));
            list.Add(new Employee("Joe", "Thomas", 1));
            list.Add(new Employee("Jake", "King", 2));
            list.Add(new Employee("Rhonda", "Holmes", 3));
            list.Add(new Employee("Betty", "Bettis", 4));
            list.Add(new Employee("Alex", "Bettis", 5));
            list.Add(new Employee("Jake", "Bettis", 6));
            list.Add(new Employee("Ron", "Donald", 7));

            List<Employee> joes = new List<Employee>();
            /*Using a foreach loop, create a new list of all employees with the first name "Joe"*/
            foreach (Employee emp in list)
                if (emp.FirstName.Equals("Joe"))
                    joes.Add(emp);

            //Output to verify the list was created correctly
            Console.WriteLine("The Joes List: ");
            foreach (Employee emp in joes)
                emp.SayName();



            /*Using a lambda expression, create a new list of all employees with the first name "Joe"*/
            joes.Clear();
            list.ForEach(i => { if (i.FirstName.Equals("Joe")) joes.Add(i);});

            Console.WriteLine("The Joes List: ");
            foreach (Employee emp in joes)
                emp.SayName();

            //Using a lambda expression, make a list of all employees with an Id number greater than 5.
            List<Employee> greaterId = new List<Employee>();
            list.ForEach(i => { if (i.Id > 5) greaterId.Add(i); });

            Console.WriteLine("The ID greater than 5 List: ");
            foreach (Employee emp in greaterId)
                emp.SayName();

            Console.ReadLine();
        }
    }
}
