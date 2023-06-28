using System;
using GeometryShapes.Triangle;
using GeometryShapes.Rectangle;
using GeometryShapes.Square;
using NumberSpaces;
using GuessingGame;

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
                default:
                    Console.WriteLine("Invalid exercise number.");
                    break;
            }
        }

        static void Exercise1()
        {
            int number = 13;

            Console.WriteLine($"Number {number} is even: {EvenNumbers.IsEven(number)}");
            Console.WriteLine($"Number {number} is odd: {OddNumbers.IsOdd(number)}");
            Console.WriteLine($"Number {number} is prime: {PrimeNumbers.IsPrime(number)}");
            Console.WriteLine($"Number {number} is Fibonacci: {FibonacciNumbers.IsFibonacci(number)}");

            Console.ReadLine();
        }

        static void Exercise2()
        {
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;

            Triangle triangle = new Triangle(sideA, sideB, sideC);
            double triangleArea = triangle.CalculateArea();
            Console.WriteLine($"Triangle area: {triangleArea}");

            double length = 6;
            double width = 8;

            Rectangle rectangle = new Rectangle(length, width);
            double rectangleArea = rectangle.CalculateArea();
            Console.WriteLine($"Rectangle area: {rectangleArea}");

            double side = 5;

            Square square = new Square(side);
            double squareArea = square.CalculateArea();
            Console.WriteLine($"Square area: {squareArea}");

            Console.ReadLine();
        }

        static void Exercise3()
        {
            int minNumber = 1;
            int maxNumber = 100;

            Game game = new Game(minNumber, maxNumber);
            game.Start();
        }

        static void Exercise4()
        {
        }
    }
}
namespace GuessingGame
{
    public class Game
    {
        private int minValue;
        private int maxValue;
        private int guessCount;
        private int guessedNumber;
        private bool isGameOver;

        public Game(int min, int max)
        {
            minValue = min;
            maxValue = max;
            guessCount = 0;
            isGameOver = false;
        }

        public void Start()
        {
            Console.WriteLine($"Welcome to the Guessing Game! Think of a number between {minValue} and {maxValue}.");
            Console.WriteLine("Press any key when you are ready.");
            Console.ReadKey();
            Console.WriteLine("Let's begin!");

            guessedNumber = GenerateRandomNumber(minValue, maxValue);

            while (!isGameOver)
            {
                int guess = GetPlayerGuess();

                if (guess == guessedNumber)
                {
                    Console.WriteLine("Congratulations! You guessed the correct number.");
                    isGameOver = true;
                }
                else if (guess < guessedNumber)
                {
                    Console.WriteLine("Too low! Try again.");
                }
                else
                {
                    Console.WriteLine("Too high! Try again.");
                }

                guessCount++;
            }

            Console.WriteLine($"You made {guessCount} guesses. Thanks for playing!");
            Console.ReadLine();
        }

        private int GenerateRandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max + 1);
        }

        private int GetPlayerGuess()
        {
            int guess;

            while (true)
            {
                Console.Write("Enter your guess: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out guess) && guess >= minValue && guess <= maxValue)
                {
                    return guess;
                }

                Console.WriteLine($"Invalid guess! Please enter a number between {minValue} and {maxValue}.");
            }
        }
    }
}
    namespace GeometryShapes
    {
        namespace Triangle
        {
            public class Triangle
            {
                private double sideA;
                private double sideB;
                private double sideC;

                public Triangle(double a, double b, double c)
                {
                    sideA = a;
                    sideB = b;
                    sideC = c;
                }

                public double CalculateArea()
                {
                    double s = (sideA + sideB + sideC) / 2;
                    double area = Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));
                    return area;
                }
            }
        }

        namespace Rectangle
        {
            public class Rectangle
            {
                private double length;
                private double width;

                public Rectangle(double l, double w)
                {
                    length = l;
                    width = w;
                }

                public double CalculateArea()
                {
                    double area = length * width;
                    return area;
                }
            }
        }

        namespace Square
        {
            public class Square
            {
                private double side;

                public Square(double s)
                {
                    side = s;
                }

                public double CalculateArea()
                {
                    double area = side * side;
                    return area;
                }
            }
    }

}
namespace NumberSpaces
{
    public class EvenNumbers
    {
        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }
    }

    public class OddNumbers
    {
        public static bool IsOdd(int number)
        {
            return number % 2 != 0;
        }
    }

    public class PrimeNumbers
    {
        public static bool IsPrime(int number)
        {
            if (number <= 1)
                return false;

            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }
    }

    public class FibonacciNumbers
    {
        public static bool IsFibonacci(int number)
        {
            if (number == 0)
                return true;

            int a = 0;
            int b = 1;

            while (b <= number)
            {
                if (b == number)
                    return true;

                int temp = a;
                a = b;
                b = temp + b;
            }

            return false;
        }
    }
}