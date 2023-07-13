using System.Drawing;
using System;
namespace С__Pack
{
    internal class Program
    {
      
        static void Main(string[] args)
        {
            Console.WriteLine("Choose an exercise (1-6):");
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
            }
            static void Exercise1()
            {
                string rainbowColor = "orange";
                Func<string, (int, int, int)> getRGBValue = delegate (string color)
                {
                    switch (color.ToLower())
                    {
                        case "red":
                            return (255, 0, 0);
                        case "orange":
                            return (255, 165, 0);
                        case "yellow":
                            return (255, 255, 0);
                        case "green":
                            return (0, 128, 0);
                        case "blue":
                            return (0, 0, 255);
                        case "indigo":
                            return (75, 0, 130);
                        case "violet":
                            return (238, 130, 238);
                        default:
                            throw new ArgumentException("UNKNOWN CODE: " + color);
                    }
                };

                var rgbValue = getRGBValue(rainbowColor);
                Console.WriteLine($"RGB FOR {rainbowColor} - R:{rgbValue.Item1} G:{rgbValue.Item2} B:{rgbValue.Item3}");
            }
            static void Exercise2()
            {

            }
            static void Exercise3()
            {
                int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                int count = numbers.Count(x => x % 7 == 0);
                Console.WriteLine(count);
            }
            static void Exercise4()
            {
                int[] numbers = { 5, -2, 10, -8, 3, 0, -1, 7 };
                Func<int[], int> countPositiveNumbers = nums => nums.Count(n => n > 0);

                int positiveCount = countPositiveNumbers(numbers);
                Console.WriteLine($"POSITIVE NUMBERS COUNT: {positiveCount}");
            }
            static void Exercise5()
            {
                int[] numbers = { 5, -2, -10, -8, 3, 0, -1, 7, -10, -1 };
                Action<int[]> displayUniqueNegativeNumbers = nums =>
                {
                    var uniqueNegativeNumbers = nums.Where(n => n < 0).Distinct();
                    foreach (var number in uniqueNegativeNumbers)
                    {
                        Console.WriteLine(number);
                    }
                };

                displayUniqueNegativeNumbers(numbers);
            }
            static void Exercise6()
            {
                string text = "EXAMPLE OF TEXT";
                string wordToCheck = "TEXT";
                Func<string, string, bool> checkWordInText = (inputText, word) =>
                {
                    return inputText.ToLower().Contains(word.ToLower());
                };

                bool wordExists = checkWordInText(text, wordToCheck);
                Console.WriteLine($"WORD \"{wordToCheck}\" {(wordExists ? "FOUND" : "NOT FOUNT")} IN TEXT" +
                    $".");

            }
        }
    }
}