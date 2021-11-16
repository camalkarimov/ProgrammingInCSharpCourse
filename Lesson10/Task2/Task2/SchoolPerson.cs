using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
     public class SchoolPerson
    {
        public string SchoolName { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int CurrentClass { get; set; }

        private int _age;
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if ((value > 6) && (value < 50))
                {
                    _age = value;
                }
                else
                {
                    throw new Exception(" Wrong Number ");
                }
            }
        }
        public void Greet()
        {
            Console.WriteLine($"Hello {Name} {Surname}");
        }

        public void GoToClasses()
        {
            Console.WriteLine("Inside Base GoToClasses method");
        }
    }
}
