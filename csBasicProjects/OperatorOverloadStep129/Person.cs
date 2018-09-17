﻿namespace OperatorOverloadStep129
{
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person(string FirstName, string LastName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
        }

        public abstract void SayName();
    }
}