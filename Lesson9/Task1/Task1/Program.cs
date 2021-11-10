using System;

namespace Task1
{
    class Program
    {
        static void Main1(string[] args)
        {
            int all = 3;
            Person[] persons = new Person[all];

            for (int i = 0; i < all; i++)
            {
                persons[i] = new Person();
                persons[i].Name = Console.ReadLine();
            }

            for (int i = 0; i < all; i++)
            {
                Console.WriteLine(persons[i].ToString());
            }

        }
        class Person
        {
            public string Name;
            public override string ToString()
            {
                return "Hello! My name is " + Name;

            }
        }
    }
}
