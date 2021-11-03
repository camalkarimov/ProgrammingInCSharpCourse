using System;

namespace Lesson5
{
    class Program
    {
        static void Main1(string[] args)
        {
            //Task1
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }
        static void Main2(string[] args)
        {

            //Task2
            int i, n, sum = 0;
            Console.WriteLine ("Input number of terms : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Odd natural numbers:");
            for (i = 1; i <= n; i++)
            {
                Console.Write("{0} ", 2 * i - 1);
                sum += 2 * i - 1;
            }
            Console.WriteLine("Sum is: {0}", sum);
        }
        static void Main3(string[] args)
        {
            //Task3

            int i, n, sum = 0;
            double avg;

            Console.WriteLine("Input the 5 numbers :");
            for (i = 1; i <= 5; i++)
            {
                Console.WriteLine("Number-{0} :", i);

                n = Convert.ToInt32(Console.ReadLine());
                sum += n;
            }
            avg = sum / 5.0;
            Console.WriteLine("The sum of 5 no is : {0}", sum);
            Console.WriteLine("The Average is : {0}", avg);
        }
        static void Main4(string[] args)
        {
            //Task4

            int j, i, n;
            
            Console.Write("Input upto the table number starting from 1 : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Multiplication table from 1 to {0} \n", n);
            for (i = 1; i <= 10; i++)
            {
                for (j = 1; j <= n; j++)
                {
                    if (j <= n - 1)
                        Console.WriteLine("{0}x{1} = {2}, ", j, i, i * j);
                    else
                        Console.WriteLine("{0}x{1} = {2}", j, i, i * j);

                }
                
            }
        }
        static void Main5(string[] args)
        {
            //Task5

            int i, j, rows;


            Console.Write("Input number of rows : ");
            rows = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= rows; i++)
            {
                for (j = 1; j <= i; j++)
                    Console.Write("*");
                Console.Write("\n");
            }
        }
        static void Main6(string[] args)
        {
            //Task6
            int i, j, rows, a=1;


            Console.Write("Input number of rows : ");
            rows = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= rows; i++)
            {
                for (j = 1; j <= i; j++)
                    Console.Write("{0}",a++);
                Console.Write("\n");
               
            }
        }
        static void Main7(string[] args)
        {
            //Task7
            int n, i, a = 9;
            int sum = 0;

            Console.WriteLine("Display the sum of the series [ 9 + 99 + 999 + 9999 ...]:");

            Console.WriteLine("Input the number or terms :");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                sum += a;
                Console.WriteLine("{0}   ", a);
                a = a * 10 + 9;
            }
            Console.WriteLine("The sum of the saries = {0} ", sum);
        }
        static void Main8(string[] args)
        {
            //Task8 

            int number, i, j;

            Console.Write("Please enter any number for find prime numbers of this number : ");
            number = int.Parse(Console.ReadLine());

            bool Prime = true;

            Console.Write("These are prime numbers : ");

            for ( i = 2; i <= number; i++)
            {
                for ( j = 2; j <= number; j++)
                {
                    if ((i != j) && (i % j == 0))
                    {
                        Prime = false;
                        break;
                    }
                }

                if (Prime)
                {
                    Console.Write("{0} ", i);
                }

                Prime = true;
            }
        }
        static void Main(string[] args)
        {
            //Task9 

            int n, i, prm1 = 1, prm2 = 1, prm3 = 0, j;

            Console.Write("Input a positive integer: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i <= n / 2; i++)
            {
                prm1 = 1;
                prm2 = 1;
                for (j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    { prm1 = 0; j = i; }
                }
                for (j = 2; j < n - i; j++)
                {
                    if ((n - i) % j == 0)
                    { prm2 = 0; j = n - i; }
                }
                if (prm1 == 1 && prm2 == 1)
                {
                    Console.Write("{0} =  {1} + {2}  \n", n, i, n - i);
                    prm3 = 1;
                }
            }
            if (prm3 == 0)
            {   
                Console.Write("This number is prime", n);
            }
        }
        static void Main10(string[] args)
        {
            //Task10

            int num, var1, sum = 0, var2;
   
            Console.WriteLine("To Find a Number is Palindrome or not");
            Console.Write("Enter a number: ");
            num = Convert.ToInt32(Console.ReadLine());
            var2 = num;
            while (num > 0)
            {
                var1 = num % 10; 
                num = num / 10;   
                sum = sum * 10 + var1;
            }
            
            if (var2 == sum) 
            {
                Console.WriteLine("Number is Palindrome");
            }
            else
            {
                Console.WriteLine("Number is not a palindrome");
            }

        }
    }
}
