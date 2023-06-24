using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
namespace С__Pack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose an exercise (1-7):");
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
                default:
                    Console.WriteLine("Invalid exercise number.");
                    break;
            }
        }
        static void Exercise1()
        {
                int[] A = new int[5];
                double[,] B = new double[3, 4];

                Console.WriteLine("Set elements of А:");
                for (int i = 0; i < A.Length; i++)
                {
                    Console.Write($"A[{i}]: ");
                    A[i] = int.Parse(Console.ReadLine());
                }

                Random random = new Random();
                for (int i = 0; i < B.GetLength(0); i++)
                {
                    for (int j = 0; j < B.GetLength(1); j++)
                    {
                        B[i, j] = random.NextDouble();
                    }
                }

                Console.WriteLine("Masive А:");
                foreach (int element in A)
                {
                    Console.Write(element + " ");
                }
                Console.WriteLine();

                Console.WriteLine("Masive В:");
                for (int i = 0; i < B.GetLength(0); i++)
                {
                    for (int j = 0; j < B.GetLength(1); j++)
                    {
                        Console.Write(B[i, j] + " ");
                    }
                    Console.WriteLine();
                }

                double maxElement = double.MinValue;
                foreach (double element in A)
                {
                    if (element > maxElement)
                        maxElement = element;
                }
                for (int i = 0; i < B.GetLength(0); i++)
                {
                    for (int j = 0; j < B.GetLength(1); j++)
                    {
                        if (B[i, j] > maxElement)
                            maxElement = B[i, j];
                    }
                }

                double minElement = double.MaxValue;
                foreach (double element in A)
                {
                    if (element < minElement)
                        minElement = element;
                }
                for (int i = 0; i < B.GetLength(0); i++)
                {
                    for (int j = 0; j < B.GetLength(1); j++)
                    {
                        if (B[i, j] < minElement)
                            minElement = B[i, j];
                    }
                }

                double sum = 0;
                foreach (double element in A)
                {
                    sum += element;
                }
                for (int i = 0; i < B.GetLength(0); i++)
                {
                    for (int j = 0; j < B.GetLength(1); j++)
                    {
                        sum += B[i, j];
                    }
                }

                double product = 1;
                foreach (double element in A)
                {
                    product *= element;
                }
                for (int i = 0; i < B.GetLength(0); i++)
                {
                    for (int j = 0; j < B.GetLength(1); j++)
                    {
                        product *= B[i, j];
                    }
                }

                int evenSum = 0;
                foreach (int element in A)
                {
                    if (element % 2 == 0)
                        evenSum += element;
                }

                double oddColumnsSum = 0;
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    if (j % 2 != 0)
                    {
                        for (int i = 0; i < B.GetLength(0); i++)
                        {
                            oddColumnsSum += B[i, j];
                        }
                    }
                }

                Console.WriteLine("Max: " + maxElement);
                Console.WriteLine("Min: " + minElement);
                Console.WriteLine("Sum: " + sum);
                Console.WriteLine("Product: " + product);
                Console.WriteLine("EvenSum: " + evenSum);
                Console.WriteLine("OddColumsSum: " + oddColumnsSum);

                Console.ReadLine();           
        }
        static void Exercise2()
        {
            Console.WriteLine("FILLER");
        }
        static void Exercise3()
        {
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();

            Console.WriteLine("Enter the shift value:");
            int shift = int.Parse(Console.ReadLine());

            string encryptedString = EncryptString(input, shift);

            Console.WriteLine("Encrypted string:");
            Console.WriteLine(encryptedString);
        }
        static void Exercise4()
        {
            Console.WriteLine("FILLER");
        }
        static void Exercise5()
        {
            Console.WriteLine("Enter arithmetic variable (+ to -):");
            string expression = Console.ReadLine();

            double result = EvaluateExpression(expression);
            Console.WriteLine("Result: " + result);

            Console.ReadLine();
        }
        static void Exercise6()
        {
            Console.WriteLine("Enter a text:");
            string text = Console.ReadLine();

            string[] sentences = text.Split(new char[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < sentences.Length; i++)
            {
                string sentence = sentences[i].Trim();

                if (!string.IsNullOrEmpty(sentence))
                {
                    string modifiedSentence = ModifyFirstLetterCase(sentence);

                    sentences[i] = modifiedSentence;
                }
            }

            string modifiedText = string.Join(" ", sentences);
            Console.WriteLine("Modified text:");
            Console.WriteLine(modifiedText);
        }
        static void Exercise7()
        {
            Console.WriteLine("Enter the text:");
            string text = Console.ReadLine();

            Console.WriteLine("Enter the forbidden words (separated by commas):");
            string forbiddenWordsInput = Console.ReadLine();

            string[] forbiddenWords = forbiddenWordsInput.Split(',');

            int replacementCount = 0;

            string modifiedText = ReplaceForbiddenWords(text, forbiddenWords, out replacementCount);

            Console.WriteLine("Modified text:");
            Console.WriteLine(modifiedText);

            Console.WriteLine("Statistics:");
            Console.WriteLine("Replaced {0} forbidden words.", replacementCount);
        }

        static string ReplaceForbiddenWords(string text, string[] forbiddenWords, out int replacementCount)
        {
            replacementCount = 0;
            List<string> modifiedWords = new List<string>();

            string[] words = text.Split(new[] { ' ', ',', '.', ':', ';', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string word in words)
            {
                string modifiedWord = word;
                if (forbiddenWords.Contains(word.ToLower()))
                {
                    modifiedWord = new string('*', word.Length);
                    replacementCount++;
                }
                modifiedWords.Add(modifiedWord);
            }

            return string.Join(" ", modifiedWords);
        }

        static string ModifyFirstLetterCase(string sentence)
        {
            if (string.IsNullOrEmpty(sentence))
                return sentence;

            char firstChar = char.ToUpper(sentence[0]);
            string modifiedSentence = firstChar + sentence.Substring(1);

            return modifiedSentence;
        }
        static string EncryptString(string input, int shift)
        {
            string encryptedString = "";

            foreach (char c in input)
            {
                if (char.IsLetter(c))
                {
                    char encryptedChar = EncryptChar(c, shift);
                    encryptedString += encryptedChar;
                }
                else
                {
                    encryptedString += c;
                }
            }

            return encryptedString;
        }

        static double EvaluateExpression(string expression)
        {
            expression = expression.Replace(" ", "");

            string[] operands = expression.Split(new char[] { '+', '-' }, StringSplitOptions.RemoveEmptyEntries);
            string[] operators = GetOperators(expression);

            double[] numbers = new double[operands.Length];
            for (int i = 0; i < operands.Length; i++)
            {
                numbers[i] = double.Parse(operands[i]);
            }

            double result = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (operators[i - 1] == "+")
                    result += numbers[i];
                else if (operators[i - 1] == "-")
                    result -= numbers[i];
            }

            return result;
        }


        static string[] GetOperators(string expression)
        {
            string[] operators = new string[expression.Length];
            int index = 0;
            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '+' || expression[i] == '-')
                {
                    operators[index] = expression[i].ToString();
                    index++;
                }
            }
            Array.Resize(ref operators, index);

            return operators;
        }


        static char EncryptChar(char c, int shift)
        {
            char encryptedChar = c;

            if (char.IsLower(c))
            {
                encryptedChar = (char)(((c - 'a' + shift) % 26) + 'a');
            }
            else if (char.IsUpper(c))
            {
                encryptedChar = (char)(((c - 'A' + shift) % 26) + 'A');
            }

            return encryptedChar;
        }
    }
}