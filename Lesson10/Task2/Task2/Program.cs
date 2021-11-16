using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            SchoolPerson schoolPerson = new SchoolPerson();
            schoolPerson.Greet();
            Console.WriteLine("----------");

            Student student = new Student();
            student.Age = 21;
            student.Greet();
            student.ShowAge();
            student.GoToClasses();
            Console.WriteLine("-----------");

            Teacher teacher = new Teacher();
            teacher.Age = 30;
            teacher.Greet();
            teacher.GoToClasses();
            teacher.Explain();
        }
    }
}
