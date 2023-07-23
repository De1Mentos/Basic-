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
            }
            static void Exercise3()
            {
            }
        }
    }
}