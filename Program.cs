using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace С__Pack
{
    public delegate double ArithmeticOperation(double a, double b);
    public delegate void MessageDelegate(string message);

    internal class Program
    {

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
            MessageDelegate messageDelegate = DisplayMessage;

            messageDelegate("FIRST MESSAGE");
            messageDelegate("SECOND MESSAGE");

            Console.ReadLine();
        }

        static void DisplayMessage(string message)
        {
            Console.WriteLine("Message: " + message);
        }
        static void Exercise2()
        {
            ArithmeticOperation add = Add;

            ArithmeticOperation subtract = Subtract;

            ArithmeticOperation multiply = Multiply;

            double result = PerformOperation(5, 3, add);
            Console.WriteLine("ADD RESULT: " + result);

            result = PerformOperation(5, 3, subtract);
            Console.WriteLine("SUB RESULT: " + result);

            result = PerformOperation(5, 3, multiply);
            Console.WriteLine("MULT RESULT: " + result);

            Console.ReadLine();
        }
        static void Exercise3()
        {
            int number = 7;

            Predicate<int> isEven = IsEven;
            Predicate<int> isOdd = IsOdd;
            Predicate<int> isPrime = IsPrime;
            Predicate<int> isFibonacci = IsFibonacci;

            Console.WriteLine("NUMBER IS: " + number);
            Console.WriteLine("ISEVEN: " + CheckNumber(number, isEven));
            Console.WriteLine("ISODD: " + CheckNumber(number, isOdd));
            Console.WriteLine("ISPRIME: " + CheckNumber(number, isPrime));
            Console.WriteLine("ISFIBONACCI: " + CheckNumber(number, isFibonacci));

            Console.ReadLine();
        }
        static void Exercise4()
        {
        }       
        static double PerformOperation(double a, double b, ArithmeticOperation operation)
        {
            return operation(a, b);
        }
        static double Add(double a, double b)
        {
            return a + b;
        }
        static double Subtract(double a, double b)
        {
            return a - b;
        }
        static double Multiply(double a, double b)
        {
            return a * b;
        }
        static bool CheckNumber(int number, Predicate<int> condition)
        {
            return condition(number);
        }

        static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        static bool IsOdd(int number)
        {
            return number % 2 != 0;
        }

        static bool IsPrime(int number)
        {
            if (number < 2)
                return false;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }

        static bool IsFibonacci(int number)
        {
            if (number == 0 || number == 1)
                return true;

            int a = 0;
            int b = 1;
            int c = a + b;

            while (c <= number)
            {
                if (c == number)
                    return true;

                a = b;
                b = c;
                c = a + b;
            }

            return false;
        }
    }

}