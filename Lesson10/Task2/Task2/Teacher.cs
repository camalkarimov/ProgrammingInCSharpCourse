using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Teacher : SchoolPerson
    {
        private string subject = "Encapsulation";

        public void Explain()
        {
            Console.WriteLine($"Explanation begin on subject {subject}");
        }

        public void GoToClasses()
        {
            Console.WriteLine($"I’m {Name} {Surname}, I am a teacher.");
        }
    }
}
