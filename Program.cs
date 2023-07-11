using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace С__Pack
{
    internal class Program
    {
        delegate bool FilterDelegate(int number);

        static void Main(string[] args)
        {
            Console.WriteLine("Choose an exercise (1-4):");
            int exerciseNumber = int.Parse(Console.ReadLine());
            switch (exerciseNumber)
            {
                case 1:
                    Exercise1();
                    break;
                case 2:
                    Exercise2();
                    break;
                case 3:
                    Exercise3();
                    break;
                case 4:
                    Exercise4();
                    break;
            }
        }

        static void Exercise1()
        {
            Console.WriteLine("-----------------------------");
            try
            {
                int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                FilterDelegate filter = IsEven;
                foreach (int number in numbers)
                {
                    Console.Write(number); Console.Write(" ");
                    Console.WriteLine(filter(number));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("-----------------------------");
            try
            {
                int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                FilterDelegate filter = IsntEven;
                foreach (int number in numbers)
                {
                    Console.Write(number); Console.Write(" ");
                    Console.WriteLine(filter(number));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("-----------------------------");
            try
            {
                int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                FilterDelegate filter = IsPrime;
                foreach (int number in numbers)
                {
                    Console.Write(number); Console.Write(" ");
                    Console.WriteLine(filter(number));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("-----------------------------");
            try
            {
                int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                foreach (int number in numbers)
                {
                    Console.Write(number); Console.Write(" ");
                    Console.WriteLine(IsFibonacciNumber(number));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void Exercise2()
        {
            Action displayCurrentTime = () =>
            {
                Console.WriteLine(DateTime.Now.ToLongTimeString());
            };
            Action displayCurrentDate = () =>
            {
                Console.WriteLine(DateTime.Now.ToShortDateString());
            };
            Action displayCurrentDayOfWeek = () =>
            {
                Console.WriteLine(DateTime.Now.DayOfWeek);
            };
            Func<double, double, double, double> calculateTriangleArea = (baseLength, height, sideLength) =>
            {
                return 0.5 * baseLength * height;
            };
            Func<double, double, double> calculateRectangleArea = (length, width) =>
            {
                return length * width;
            };

            displayCurrentTime();
            displayCurrentDate();
            displayCurrentDayOfWeek();

            double triangleArea = calculateTriangleArea(5, 8, 4);
            Console.WriteLine("Triangle area: " + triangleArea);

            double rectangleArea = calculateRectangleArea(10, 6);
            Console.WriteLine("Rectangle area: " + rectangleArea);
        }

        static void Exercise3()
        {
        }

        static void Exercise4()
        {
        }

        static bool IsEven(int number)
        {
            return number % 2 == 0;
        }
        static bool IsntEven(int number)
        {
            return number % 2 == 1;
        }
        static bool IsPrime(int number)
        {
            if (number < 2)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
        static bool IsFibonacciNumber(int number)
        {
            int a = 0;
            int b = 1;

            while (b < number)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }

            return b == number;
        }

        static void PrintNumbers(int[] numbers)
        {
            foreach (int number in numbers)
            {
                Console.WriteLine(number + " ");
            }
        }
    }
}
