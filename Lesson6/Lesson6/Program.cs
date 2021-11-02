using System;

namespace Lesson6
{
    class Program
    {
        static void Main123(string[] args)
        {  
            //Task1,2,3

            Random num1 = new Random();
            Console.WriteLine("Enter random numbers 10 to 100: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("================");
            Console.WriteLine("Arrays");

            int[] randomNum = new int[num];

            for (int i = 0; i < num; i++)
            {
                randomNum[i] = num1.Next(0, 100);
            }


            for (int i = 0; i < randomNum.Length; i++)
            {
                Console.WriteLine(randomNum[i]);
            }
            Console.WriteLine("================");
            Console.WriteLine("Ascending Arrays");
            bool type = false;

            
            do
            {
                type = false; 

                for (int i = 0; i < randomNum.Length - 1; i++)
                {
                    if (randomNum[i]>randomNum[i+1])  
                    {
                        int num2 = randomNum[i+1]; 
                        randomNum[i + 1] = randomNum[i];  
                        randomNum[i] = num2;  
                        type = true; 
                        
                    }
                }

            } while (type); 

            for (int i = 0; i < randomNum.Length; i++)
            {
                Console.WriteLine(randomNum[i]);
            }
            Console.WriteLine("================");
            Console.WriteLine("Descending Arrays");
            do
            {
                type = false;
                for (int i = 0; i < randomNum.Length-1; i++)
                {
                    if (randomNum[i] < randomNum[i + 1])
                    {
                        int num2 = randomNum[i + 1];
                        randomNum[i + 1] = randomNum[i];
                        randomNum[i] = num2;
                        type = true;

                    }
                }


            } while (type);
            

            for (int i = 0; i < randomNum.Length; i++)
            {
                Console.WriteLine(randomNum[i]);
            }
            Console.WriteLine("================");
            Console.WriteLine("3rd max number: " + randomNum[2]);
            Console.WriteLine("================");
            Console.WriteLine("Max 4 elements : ");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(randomNum[i]);
                
            }
        }
        static void Main4(string[] args)
        {
            //Task4

            Console.WriteLine("Enter a number: ");
            int num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter another number: ");
            int num2 = Int32.Parse(Console.ReadLine());
            num1 = num1 * num2;   
            num2 = num1 / num2;
            num1 = num1 / num2;  
            Console.WriteLine("Now the 1st number is: " + num1 + " and the 2nd number is : "+num2);
        }
        static void Main5(string[] args)
        {
            //Task5

            int n1 = 0, n2 = 1, n3, i, number;
            Console.WriteLine("Input number of Fibonacci Series : ");
            number = int.Parse(Console.ReadLine());
            Console.WriteLine("The Fibonacci series of " + number + " numbers is : \n" + n1,n2);
            for (i = 1; i < number; ++i) 
            {
                n3 = n1 + n2;
                Console.WriteLine(n3 + " ");
                n1 = n2;
                n2 = n3;
            }
        }
        static void Main6(string[] args)
        {
            //Task6 

            int a , sum;
            Console.WriteLine("Enter a number: ");
            a = int.Parse(Console.ReadLine());
            sum = 0;
            while (a != 0)
            {
                sum = sum+ a % 10;
                a = a/ 10;
            }
            Console.WriteLine("The sum of the digits of the number is : " + sum);
        }
        static void Main7(string[] args)
        {
            //Task7 

            string a;
            Console.WriteLine("Please input a string :");
            a = Console.ReadLine();
            int space = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i]== ' ')
                {
                    space++;
                }
            }
            Console.WriteLine(space);
        }
    }
}
