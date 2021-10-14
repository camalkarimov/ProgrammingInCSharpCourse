using System;

namespace FirstLessonProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First Number Please");
            int var1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Second Number Please");

            int var2 = int.Parse(Console.ReadLine());

            int sum = Sum(var1, var2);
            Console.WriteLine( "Sum is:"+sum );
            
        }
        public static int Sum(int var1, int var2)
        {
            return var1 + var2;
        }
    }
}
