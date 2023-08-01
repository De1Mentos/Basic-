using System.Text.RegularExpressions;

namespace С__Pack
{

    internal class Program
    {
        static bool IsPrime(int number)
        {
            if (number <= 1)
            {
                return false;
            }

            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
        static string ReverseFileContent(string filePath)
        {
            string content = File.ReadAllText(filePath);
            char[] charArray = content.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        static int ReplaceOccurrences(ref string input, string searchWord, string replacementWord)
        {
            int occurrences = 0;
            int index = input.IndexOf(searchWord, StringComparison.InvariantCultureIgnoreCase);

            while (index != -1)
            {
                input = input.Remove(index, searchWord.Length).Insert(index, replacementWord);
                occurrences++;
                index = input.IndexOf(searchWord, index + replacementWord.Length, StringComparison.InvariantCultureIgnoreCase);
            }

            return occurrences;
        }
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
                    Exercise6();
                    break;
            }
            static void Exercise1()
            {
                List<int> numbers = new List<int>(100);
                for (int i = 0; i < 100; i++)
                {
                    numbers.Add(i);
                }
                List<int> primeNumbers = new List<int>();
                foreach (int number in numbers)
                {
                    if (IsPrime(number))
                    {
                        primeNumbers.Add(number);
                    }
                }

                using (StreamWriter writer = new StreamWriter("prime_numbers.txt"))
                {
                    foreach (int number in primeNumbers)
                    {
                        writer.WriteLine(number);
                    }
                }

                List<int> fibonacciNumbers = new List<int>();
                fibonacciNumbers.Add(0);
                fibonacciNumbers.Add(1);
                for (int i = 2; i < 100; i++)
                {
                    fibonacciNumbers.Add(fibonacciNumbers[i - 1] + fibonacciNumbers[i - 2]);
                }

                using (StreamWriter writer = new StreamWriter("fibonacci_numbers.txt"))
                {
                    foreach (int number in fibonacciNumbers)
                    {
                        writer.WriteLine(number);
                    }
                }

                Console.WriteLine("Prime Numbers: {0}", primeNumbers.Count);
                Console.WriteLine("Fibonacci Numbers: {0}", fibonacciNumbers.Count);
            }
            static void Exercise2()
            {
                Console.WriteLine("Write a path to file:");
                string filePath = Console.ReadLine();

                Console.WriteLine("Write a word to find:");
                string searchWord = Console.ReadLine();

                Console.WriteLine("Write a word to replace:");
                string replacementWord = Console.ReadLine();

                string fileContent = File.ReadAllText(filePath);
                int occurrences = ReplaceOccurrences(ref fileContent, searchWord, replacementWord);

                Console.WriteLine($"Amount of changes: {occurrences}");
                Console.WriteLine("Text after changes:");
                Console.WriteLine(fileContent);

                string replacedTextFilePath = Path.Combine(Path.GetDirectoryName(filePath), "replaced_text.txt");
                File.WriteAllText(replacedTextFilePath, fileContent);

                Console.WriteLine($"Text with changes was putted it: {replacedTextFilePath}");
            }
            static void Exercise3()
            {
                Console.WriteLine("Write the path to file with text:");
                string textFilePath = Console.ReadLine();

                Console.WriteLine("Write the path to file with moderated words:");
                string bannedWordsFilePath = Console.ReadLine();

                string[] bannedWords = File.ReadAllLines(bannedWordsFilePath);
                string textContent = File.ReadAllText(textFilePath);

                foreach (string word in bannedWords)
                {
                    string pattern = "\\b" + Regex.Escape(word) + "\\b";
                    textContent = Regex.Replace(textContent, pattern, new string('*', word.Length));
                }

                Console.WriteLine("Text after moderating it:");
                Console.WriteLine(textContent);

                string moderatedTextFilePath = Path.Combine(Path.GetDirectoryName(textFilePath), "moderated_text.txt");
                File.WriteAllText(moderatedTextFilePath, textContent);

                Console.WriteLine($"Moderated file was send in: {moderatedTextFilePath}");
            }
            static void Exercise4()
            {
                Console.WriteLine("Write a path to file:");
                string filePath = Console.ReadLine();

                string reversedContent = ReverseFileContent(filePath);

                string reversedFilePath = Path.Combine(Path.GetDirectoryName(filePath), "reversed_file.txt");
                File.WriteAllText(reversedFilePath, reversedContent);

                Console.WriteLine($"Reverersed file was created at: {reversedFilePath}");
            }
            static void Exercise5()
            {
            }
        }
    }
    }