using System;

namespace helloWorld
{
    public class Person
    {
        public string firstName;
        public string lastName;

        public void introduce()
        {
            Console.WriteLine("My full name is {0} {1}", firstName, lastName);
        }
    }
}
