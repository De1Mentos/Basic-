using System;
using System.Linq;

class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
}

static class PersonExtensions
{
    public static Person FindPersonWithMinAge(this Person[] people)
    {
        if (people.Length == 0)
            return null;

        return people.OrderBy(p => p.Age).FirstOrDefault();
    }

    public static Person FindPersonWithMaxAge(this Person[] people)
    {
        if (people.Length == 0)
            return null;

        return people.OrderByDescending(p => p.Age).FirstOrDefault();
    }

    public static double CalculateAverageAge(this Person[] people)
    {
        if (people.Length == 0)
            return 0;

        return people.Average(p => p.Age);
    }
}

namespace С__Pack
{
    public static class StringExtensions
    {
        public static int CountVowels(this string str)
        {
            int count = 0;
            string vowels = "aeiouAEIOU";

            foreach (char c in str)
            {
                if (vowels.Contains(c))
                    count++;
            }

            return count;
        }
        public static int CountConsonants(this string str)
        {
            int count = 0;
            string consonants = "bcdfghjklmnpqrstvwxyzBCDFGHJKLMNPQRSTVWXYZ";

            foreach (char c in str)
            {
                if (consonants.Contains(c))
                    count++;
            }

            return count;
        }
        public static int CountSentences(this string str)
        {
            int count = 0;
            string[] delimiters = { ".", "!", "?" };

            count = str.Split(delimiters, StringSplitOptions.RemoveEmptyEntries).Length;

            return count;
        }
    }
    public static class IntExtensions
    {
        public static bool IsOdd(this int number)
        {
            return number % 2 != 0;
        }
        public static bool IsPrime(this int number)
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
    }

    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Choose an exercise (1-9):");
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
                case 7:
                    Exercise7();
                    break;
                case 8:
                    Exercise8();
                    break;
                case 9:
                    Exercise9();
                    break;
            }
        }
        static void Exercise1()
        {
            int number = 7;

            if (number.IsOdd())
            {
                Console.WriteLine("ODD.");
            }
            else
            {
                Console.WriteLine("NOT ODD.");
            }
        }
        static void Exercise2()
        {
            int number = 7;

            if (number.IsOdd())
            {
                Console.WriteLine("ODD.");
            }
            else
            {
                Console.WriteLine("NOT ODD.");
            }
        }
        static void Exercise3()
        {
            int number = 17;

            if (number.IsPrime())
            {
                Console.WriteLine("Число є простим.");
            }
            else
            {
                Console.WriteLine("Число не є простим.");
            }
        }
        static void Exercise4()
        {
            string text = "Hello, world!";

            int vowelCount = text.CountVowels();

            Console.WriteLine($"THERES: {vowelCount} VOWELS");
        }
        static void Exercise5()
        {
            string text = "Hello, world!";

            int consonantCount = text.CountConsonants();

            Console.WriteLine($"THERE'S: {consonantCount} CONSONANTS");
        }
        static void Exercise6()
        {
            string text = "Joe Biden! Chocolate Chip? Nope.";

            int sentenceCount = text.CountSentences();

            Console.WriteLine($"THERE'S: {sentenceCount} SENTENCE");
        }
        static void Exercise7()
        {
            Person[] people = new Person[]
            {
            new Person { FirstName = "Joe", LastName = "Biden", Age = 112 },
            new Person { FirstName = "Trump", LastName = "Trumpovich", Age = 40 },
            new Person { FirstName = "Human", LastName = "", Age = 21042 },
            new Person { FirstName = "Margaret", LastName = "Thetcher", Age = 12 }
            };

            Person personWithMinAge = people.FindPersonWithMinAge();
            Person personWithMaxAge = people.FindPersonWithMaxAge();
            double averageAge = people.CalculateAverageAge();

            Console.WriteLine("Minimal age:");
            Console.WriteLine($"{personWithMinAge.FirstName} {personWithMinAge.LastName}, {personWithMinAge.Age} years");

            Console.WriteLine("Maximum age:");
            Console.WriteLine($"{personWithMaxAge.FirstName} {personWithMaxAge.LastName}, {personWithMaxAge.Age} years");

            Console.WriteLine("Average age of everyone:");
            Console.WriteLine($"{averageAge} years");
        }
        static void Exercise8()
        {
        }
        static void Exercise9()
        {
        }
    }
}
        