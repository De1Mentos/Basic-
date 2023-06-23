namespace С__Pack
{
    using System;
    using System.Linq;
    using static System.Runtime.InteropServices.JavaScript.JSType;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose an exercise (1-8):");
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
                case 5:
                    Exercise5();
                    break;
                case 6:
                    Exercise6();
                    break;
                case 8:
                    Exercise8();
                    break;
                default:
                    Console.WriteLine("Invalid exercise number.");
                    break;
            }
        }

        static void Exercise1()
        {
            Console.WriteLine("Exercise 1");
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 5, 4, 3, 2, 1 };

            int evenCount = numbers.Count(n => n % 2 == 0);
            int oddCount = numbers.Count(n => n % 2 != 0);
            int uniqueCount = numbers.Distinct().Count();

            Console.WriteLine("Even elements: " + evenCount);
            Console.WriteLine("Odd elements: " + oddCount);
            Console.WriteLine("Unique elements: " + uniqueCount);
        }

        static void Exercise2()
        {
            Console.WriteLine("Exercise 2");
            int[] numbers2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 5, 4, 3, 2, 1 };

            Console.WriteLine("Enter a number:");
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < numbers2.Length; i++)
            {
                if (numbers2[i] > number)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static void Exercise3()
        {
            Console.WriteLine("Exercise 3");
            // Add your code for Exercise 3 here
        }

        static void Exercise4()
        {
            Console.WriteLine("Exercise 4");
            int[] array1 = { 1, 2, 3, 4, 5 };
            int[] array2 = { 4, 5, 6, 7, 8 };

            var uniqueElements = array1.Except(array2).Concat(array2.Except(array1));

            foreach (var element in uniqueElements)
            {
                Console.WriteLine(element);
            }
        }

        static void Exercise5()
        {
            Console.WriteLine("Exercise 5");
            int[,] array = {
        { 1, 2, 3 },
        { 4, 5, 6 },
        { 7, 8, 9 }
    };

            int rows = array.GetLength(0);
            int columns = array.GetLength(1);

            int minValue = int.MaxValue;
            int maxValue = int.MinValue;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (array[i, j] < minValue)
                        minValue = array[i, j];

                    if (array[i, j] > maxValue)
                        maxValue = array[i, j];
                }
            }

            Console.WriteLine("Min: " + minValue);
            Console.WriteLine("Max: " + maxValue);
        }

        static void Exercise6()
        {
            Console.WriteLine("Exercise 6");
            // Add your code for Exercise 6 here
        }

        static void Exercise8()
        {
            Console.WriteLine("Exercise 8");
            Console.WriteLine("Enter a sentence:");
            string sentence1 = Console.ReadLine();

            int vowelCount = CountVowels(sentence1);

            Console.WriteLine("Amount of vowels: " + vowelCount);
        }

        static int CountVowels(string sentence1)
        {
            int count = 0;
            string vowels = "aeiouAEIOU";

            foreach (char letter in sentence1)
            {
                if (vowels.Contains(letter))
                    count++;
            }

            return count;
        }
    }
}