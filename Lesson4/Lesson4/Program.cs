using System;

namespace Lesson4
{
    class Program
    {
        static void Main1(string[] args)
        {
            //Task1

            DateTime date1 = new DateTime(2001, 10, 23);
            Console.WriteLine(date1.DayOfWeek);
            //Task2

            DateTime date2 = DateTime.Now;
            var date3 = DateTime.Parse("10.23.2001");
            TimeSpan timeRange = date2 - date3;

            Console.WriteLine(timeRange.Days);
            //Task3

            DateTime date4 = DateTime.Now;
            DateTime date5 = date4.AddDays(40);

            Console.WriteLine("{0:dddd}", date5);
        }
        static void Main2(string[] args)
        {
            //Task4

            int day, month, year;

            Console.Write(" Check whether the given year, month and day is the current or not :\n");

            Console.Write(" Input the Day : ");
            day = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Input the Month : ");
            month = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Input the Year : ");
            year = Convert.ToInt32(Console.ReadLine());
            DateTime value = new DateTime(year, month, day);

            Console.WriteLine(" The formatted Date is : {0}", value.ToString("dd/MM/yyyy"));
            Console.WriteLine(" The current date status : {0}", value == DateTime.Today);
        }
        static void Main3(string[] args)
        {
            //Task5
            int dt, mn, yr;

            Console.Write("Input the Day :");
            dt = int.Parse(Console.ReadLine());

            Console.Write("Input the Month : ");
            mn = int.Parse(Console.ReadLine());

            Console.Write("Input the Year : ");
            yr = int.Parse(Console.ReadLine());

            DateTime date1 = new DateTime(yr, mn, dt);
            string date2 = date1.ToString("dd/MM/yyyy");

            Console.WriteLine("The formatted Date is :" + date2);
            Console.WriteLine("The Last day of the year is:" + "31/12/" + yr);
        }
        static void Main4(string[] args)
        {
            //Task7

            Console.WriteLine("Input the 1st number : ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the 2nd number : ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the 3rd number : ");
            int num3 = int.Parse(Console.ReadLine());

            if (num1 >= num2 && num1 >= num3)
            {
                Console.WriteLine("The 1st number is the greatest among three");
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                Console.WriteLine("The 2nd Number is the greatest among three");
            }
            else
            {
                Console.WriteLine("The 3rd number is the greatest among three");
            }
        }
        static void Main5(string[] args)
        {
            //Task8

            Console.WriteLine("Input Day No : ");
            int day = Convert.ToInt32(Console.ReadLine());
            
            switch ( day )
            {
                
                case 1:
                    Console.WriteLine("Monday");
                break; 

                case 2:
                    Console.WriteLine("Tuesday");
                break;

                case 3:
                    Console.WriteLine("Wednesday");
                break;

                case 4:
                    Console.WriteLine("Thursday");
                break;

                case 5:
                    Console.WriteLine("Friday");
                break;

                case 6:
                    Console.WriteLine("Saturday");
                break;

                case 7:
                    Console.WriteLine("Sunday");
                break;

                default:
                    Console.WriteLine("Invalid day number.");
                break;
            }
        }
        static void Main6(string[] args)
        {
            //Task 9
            Console.WriteLine("Enter the first Integer :");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second Integer :");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Here are the options :");
            Console.WriteLine("1-Addition");
            Console.WriteLine("2-Substraction");
            Console.WriteLine("3-Multiplication");
            Console.WriteLine("4-Division");
            Console.WriteLine("5-Exit");
            int var = Convert.ToInt32(Console.ReadLine());

            switch (var)
            {
                case 1:
            Console.WriteLine("Addition {0} and {1} is:{2}", num1, num2, num1 + num2);
                break;
                case 2:
            Console.WriteLine("Substraction {0} and {1} is: {2}", num1, num2, num1 - num2);
                break;
                case 3:
            Console.WriteLine("Multiplication {0} and {1} is:{2}", num1,num2,num1*num2);
                    break;
                case 4:
                    if (num2 == 0)
                    {
                        Console.WriteLine("Second integer is zero. Devide zero.");
                    }
                    else
                    {
                        Console.Write("Division {0}  and {1} is : {2}", num1, num2, num1 / num2);
                    }
                    break;
                case 5:
                    break;

                default:
                    Console.Write("Input correct option\n");
                    break;
            }

        }
    } 
}
