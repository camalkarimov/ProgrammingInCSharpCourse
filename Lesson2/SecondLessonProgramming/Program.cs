using System;

namespace SecondLessonProgramming
{
    class Program
    {
        static void Main(string[] args)
        {

            //Task1
            char letter, letter1, letter2;

            Console.Write("Input letter: ");
            letter = Convert.ToChar(Console.ReadLine());

            Console.Write("Input letter: ");
            letter1 = Convert.ToChar(Console.ReadLine());

            Console.Write("Input letter: ");
            letter2 = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("{0} {1} {2}", letter2, letter1, letter);

            Console.WriteLine("==============================");

            //Task2
            Console.WriteLine("Name");
            var name = Console.ReadLine();
            Console.WriteLine("Surname");
            var surname = Console.ReadLine ();
            string str = name.ToUpper() + " " + surname.ToUpper(); 
            Console.WriteLine(str);

            Console.WriteLine("==============================");
            //Task3
            double r, perimeter, area;
            Console.WriteLine("Enter radius of circle");
            r = Convert.ToDouble(Console.ReadLine());
            perimeter = 2 * 3.14 * r;
            area = 3.14 * Math.Pow(r, 2);
            Console.WriteLine();
            Console.WriteLine("Perimeter of circle" + perimeter);
            Console.WriteLine();
            Console.WriteLine("Area of circle" + area);


        }
    }
}

