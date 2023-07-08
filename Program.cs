namespace С__Pack
{
    struct Fraction
    {
        public int Numerator;
        public int Denominator;

        public Fraction(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        public Fraction Add(Fraction other)
        {
            int resultNumerator = Numerator * other.Denominator + other.Numerator * Denominator;
            int resultDenominator = Denominator * other.Denominator;
            Simplify(ref resultNumerator, ref resultDenominator);
            return new Fraction(resultNumerator, resultDenominator);
        }

        public Fraction Subtract(Fraction other)
        {
            int resultNumerator = Numerator * other.Denominator - other.Numerator * Denominator;
            int resultDenominator = Denominator * other.Denominator;
            Simplify(ref resultNumerator, ref resultDenominator);
            return new Fraction(resultNumerator, resultDenominator);
        }

        public Fraction Multiply(Fraction other)
        {
            int resultNumerator = Numerator * other.Numerator;
            int resultDenominator = Denominator * other.Denominator;
            Simplify(ref resultNumerator, ref resultDenominator);
            return new Fraction(resultNumerator, resultDenominator);
        }

        public Fraction Divide(Fraction other)
        {
            int resultNumerator = Numerator * other.Denominator;
            int resultDenominator = Denominator * other.Numerator;
            Simplify(ref resultNumerator, ref resultDenominator);
            return new Fraction(resultNumerator, resultDenominator);
        }

        private static void Simplify(ref int numerator, ref int denominator)
        {
            int gcd = GCD(numerator, denominator);
            numerator /= gcd;
            denominator /= gcd;

            if (denominator < 0)
            {
                numerator *= -1;
                denominator *= -1;
            }
        }

        private static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int remainder = a % b;
                a = b;
                b = remainder;
            }
            return a;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What exercise do you want to see? 1-3:");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    {
                        Fraction fraction1 = new Fraction(8, 2);
                        Fraction fraction2 = new Fraction(3, 4);

                        Fraction sum = fraction1.Add(fraction2);
                        Console.WriteLine($"Sum: {sum.Numerator}/{sum.Denominator}");

                        Fraction difference = fraction1.Subtract(fraction2);
                        Console.WriteLine($"Difference: {difference.Numerator}/{difference.Denominator}");

                        Fraction product = fraction1.Multiply(fraction2);
                        Console.WriteLine($"Product: {product.Numerator}/{product.Denominator}");

                        Fraction quotient = fraction1.Divide(fraction2);
                        Console.WriteLine($"Quotient: {quotient.Numerator}/{quotient.Denominator}");

                        Console.ReadLine();
                        break;
                    }
                case 2:
                    {
                        break;
                    }
                case 3:
                    {
                        break;
                    }
            }
        }
    }
}