using System;
using System.Net.NetworkInformation;

namespace С__Pack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EX 1");
            Console.WriteLine("It's easy to win forgiveness for being wrong;");
            Console.WriteLine("being right is what gets you into real trouble.");
            Console.WriteLine("Bjarne Stroustrup");
            Console.WriteLine("EX 2");
            int[] numbers = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Write number {0}: ", i + 1);
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            int max = numbers[0];
            int min = numbers[0];
            foreach (int num in numbers)
            {
                if (num > max)
                {
                    max = num;
                }
                if (num < min)
                {
                    min = num;
                }
            }
            int product = 1;
            foreach (int num in numbers)
            {
                product *= num;
            }
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Max: " + max);
            Console.WriteLine("Min: " + min);
            Console.WriteLine("Product: " + product);

            Console.WriteLine("Ex 4");
            Console.Write("Write 6 numbers: ");
            string input = Console.ReadLine();

            if (input.Length != 6)
            {
                Console.WriteLine("Write 6 numbers: ");
                return;
            }

            char[] digits = input.ToCharArray();
            Array.Reverse(digits);
            string reversedNumber = new string(digits);

            Console.WriteLine("Resultate: " + reversedNumber);

            Console.WriteLine("EX 5");
            int a = 0;
            int b = 0;
            Console.Write("Write a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Write b: ");
            b = int.Parse(Console.ReadLine());
            if (a < b)
            {
                for (int i = a; i < b; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write(i);
                    }
                    Console.WriteLine("");
                }
            }
            else
            {
                for (int i = b; i < a; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write(i);
                    }
                    Console.WriteLine("");
                }
            }

            Console.WriteLine("EX 6");
            int? lenght = null;
            string? sumbol = null;
            bool? isHorisontal = null;
            Console.Write("Write lenght: ");
            lenght = int.Parse(Console.ReadLine());
            Console.Write("Write sumbol: ");
            sumbol = Console.ReadLine();
            Console.Write("Write isHorisonatal: ");
            isHorisontal = bool.Parse(Console.ReadLine());
            if (isHorisontal == true)
            {
                for (int i = 0; i < lenght; i++)
                {
                    Console.Write(sumbol);
                }
            }
            else
            {
                for(int i = 0; i < lenght; i++)
                {
                    Console.WriteLine(sumbol);
                }
            }
        }
    }
}