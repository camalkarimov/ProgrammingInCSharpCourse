using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Student : SchoolPerson
    {
        public void ShowAge()
        {
            Console.WriteLine($"I am {Age} years old");
        }

        public new void GoToClasses()
        {
            Console.WriteLine($"I’m {Name} {Surname}, I am student and I'm going to class.");
        }
    }
}
