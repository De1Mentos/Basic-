namespace С__Pack
{
    public class DailyTemperature
    {
        public DateTime Date { get; set; }
        public double HighestTemperature { get; set; }
        public double LowestTemperature { get; set; }

        public double TemperatureDifference()
        {
            return HighestTemperature - LowestTemperature;
        }
    }
    public static class StringExtensions
    {
        public static int WordCount(this string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return 0;

            string[] words = input.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }
        public static int LengthOfLastWord(this string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return 0;

            string[] words = input.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            if (words.Length > 0)
            {
                string lastWord = words[words.Length - 1];
                return lastWord.Length;
            }

            return 0;
        }
        public static int[] Filter(this int[] array, Func<int, bool> predicate)
        {
            int[] result = new int[array.Length];
            int index = 0;

            foreach (int item in array)
            {
                if (predicate(item))
                {
                    result[index] = item;
                    index++;
                }
            }

            Array.Resize(ref result, index);
            return result;
        }
    }
    public static class IntExtensions
    {
        public static bool IsFibonacciNumber(this int number)
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
    }
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
                case 5:
                    Exercise5();
                    break;
                case 6:
                    Exercise6();
                    break;
                case 7:
                    Exercise7();
                    break;
            }
        }
        static void Exercise1()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            foreach (int number in numbers)
            {
                Console.WriteLine($"{number} - {(number.IsFibonacciNumber() ? "Fibbonaci Number" : "NOT Fibbonaci Number")}");
            }
        }
        static void Exercise2()
        {
            string text = "This is a brick. Oh wow. Brick. Bricky.";

            int wordCount = text.WordCount();
            Console.WriteLine($"Word count: {wordCount}");
        }
        static void Exercise3()
        {
            string text = "This is a sample sentence.";

            int length = text.LengthOfLastWord();
            Console.WriteLine($"Length of last word: {length}");
        }
        static void Exercise4()
        {
        }
        static void Exercise5()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int[] evenNumbers = numbers.Filter(x => x % 2 == 0);
            Console.WriteLine("Even numbers: " + string.Join(", ", evenNumbers));

            int[] oddNumbers = numbers.Filter(x => x % 2 != 0);
            Console.WriteLine("Odd numbers: " + string.Join(", ", oddNumbers));
        }
        static void Exercise6()
        {
            DailyTemperature[] temperatures = new DailyTemperature[]
        {
            new DailyTemperature { Date = new DateTime(2023, 7, 14), HighestTemperature = 30.5, LowestTemperature = 22.1 },
            new DailyTemperature { Date = new DateTime(2023, 7, 15), HighestTemperature = 32.7, LowestTemperature = 24.3 },
            new DailyTemperature { Date = new DateTime(2023, 7, 16), HighestTemperature = 29.8, LowestTemperature = 21.5 },
            new DailyTemperature { Date = new DateTime(2023, 7, 17), HighestTemperature = 31.2, LowestTemperature = 23.9 },
            new DailyTemperature { Date = new DateTime(2023, 7, 18), HighestTemperature = 28.6, LowestTemperature = 20.2 }
        };

            int maxDifferenceIndex = FindMaxTemperatureDifferenceIndex(temperatures);
            if (maxDifferenceIndex != -1)
            {
                DailyTemperature dayWithMaxDifference = temperatures[maxDifferenceIndex];
                Console.WriteLine($"Day with maximum temperature difference: {dayWithMaxDifference.Date.ToShortDateString()} (Difference: {dayWithMaxDifference.TemperatureDifference()}°C)");
            }
            else
            {
                Console.WriteLine("No temperature data available.");
            }

        }
        public static int FindMaxTemperatureDifferenceIndex(DailyTemperature[] temperatures)
        {
            if (temperatures.Length == 0)
                return -1;

            double maxDifference = double.MinValue;
            int maxDifferenceIndex = -1;

            for (int i = 0; i < temperatures.Length; i++)
            {
                double difference = temperatures[i].TemperatureDifference();
                if (difference > maxDifference)
                {
                    maxDifference = difference;
                    maxDifferenceIndex = i;
                }
            }

            return maxDifferenceIndex;
        }
        static void Exercise7()
        {
        }
    }
}