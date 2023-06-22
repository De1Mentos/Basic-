namespace С__Pack
{
    using System;
    using System.Linq;
    using static System.Runtime.InteropServices.JavaScript.JSType;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercise ------- 1");
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 5, 4, 3, 2, 1 };

            int evenCount = numbers.Count(n => n % 2 == 0);

            int oddCount = numbers.Count(n => n % 2 != 0);

            int uniqueCount = numbers.Distinct().Count();

            Console.WriteLine("Even elements: " + evenCount);
            Console.WriteLine("Odd elements: " + oddCount);
            Console.WriteLine("Unique elements: " + uniqueCount);

            Console.WriteLine("Exercise ------- 2");
            int[] numbers2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 5, 4, 3, 2, 1 };

            Console.WriteLine("Set the number");
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < numbers2.Length; i++)
            {
                if (numbers2[i] > number)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("Exercise ------- 3");

            Console.WriteLine("Exercise ------- 4");
            int[] array1 = { 1, 2, 3, 4, 5 };
            int[] array2 = { 4, 5, 6, 7, 8 };

            var uniqueElements = array1.Except(array2).Concat(array2.Except(array1));

            foreach (var element in uniqueElements)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("Exercise ------- 5");
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

            Console.WriteLine("Exercise ------- 6");

            Console.WriteLine("Type Sentance:");

            string sentence = Console.ReadLine();

            string[] words = sentence.Split(' ');

            int wordCount = words.Length;

            Console.WriteLine("Amount of words: " + wordCount);

            Console.WriteLine("Exercise ------- 8");
         
            Console.WriteLine("Type Sentance:");
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