using System;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            
            Console.Write("First number: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Second number: ");
            n2 = Convert.ToInt32(Console.ReadLine());


            bool b = (n1 % 2 == 0 && n2 % 2 == 0) || (n1 % 2 != 0 && n2 % 2 != 0) ? true:false;

            Console.WriteLine(b);
            
            

            
        }
        static void Main1(string[] args)
            {
            //Task2
            Console.Write("Enter the first word: ");
            string var1 = Console.ReadLine();
            Console.Write("Enter the second word: ");
            string var2 = Console.ReadLine();

            bool a = var1.Contains(var2);
            Console.WriteLine(a);
        }
        static void Main2(string[] args)
        {
            //Task3
            Console.WriteLine("Enter first number");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Sum is:" + a / b);
        }
    }
}
