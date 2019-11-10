using System;

namespace Person
{
    public class Person
    {
        public string FirstName; //Fileds
        public string LastName;

        public void Introduce()
        {
            Console.WriteLine($"Hello, my name is {FirstName} {LastName}.");
        }


    }
}
