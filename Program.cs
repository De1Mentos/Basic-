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
    struct ComplexNumber
    {
        public double Real;
        public double Imaginary;

        public ComplexNumber(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

        public ComplexNumber Add(ComplexNumber other)
        {
            double resultReal = Real + other.Real;
            double resultImaginary = Imaginary + other.Imaginary;
            return new ComplexNumber(resultReal, resultImaginary);
        }

        public ComplexNumber Subtract(ComplexNumber other)
        {
            double resultReal = Real - other.Real;
            double resultImaginary = Imaginary - other.Imaginary;
            return new ComplexNumber(resultReal, resultImaginary);
        }

        public ComplexNumber Multiply(ComplexNumber other)
        {
            double resultReal = Real * other.Real - Imaginary * other.Imaginary;
            double resultImaginary = Real * other.Imaginary + Imaginary * other.Real;
            return new ComplexNumber(resultReal, resultImaginary);
        }

        public ComplexNumber Divide(ComplexNumber other)
        {
            double denominator = other.Real * other.Real + other.Imaginary * other.Imaginary;
            double resultReal = (Real * other.Real + Imaginary * other.Imaginary) / denominator;
            double resultImaginary = (Imaginary * other.Real - Real * other.Imaginary) / denominator;
            return new ComplexNumber(resultReal, resultImaginary);
        }
    }
    struct Birthday
    {
        private DateTime _birthDate;

        public Birthday(DateTime birthDate)
        {
            _birthDate = birthDate;
        }

        public void SetBirthDate(DateTime birthDate)
        {
            _birthDate = birthDate;
        }

        public DayOfWeek GetBirthDayOfWeek()
        {
            return _birthDate.DayOfWeek;
        }

        public DayOfWeek GetBirthDayOfWeek(int year)
        {
            DateTime targetDate = new DateTime(year, _birthDate.Month, _birthDate.Day);
            return targetDate.DayOfWeek;
        }

        public int GetDaysUntilBirthday()
        {
            DateTime today = DateTime.Today;
            DateTime nextBirthday = new DateTime(today.Year, _birthDate.Month, _birthDate.Day);

            if (nextBirthday < today)
                nextBirthday = nextBirthday.AddYears(1);

            TimeSpan timeUntilBirthday = nextBirthday - today;
            return timeUntilBirthday.Days;
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
                        ComplexNumber number1 = new ComplexNumber(2, 3);
                        ComplexNumber number2 = new ComplexNumber(1, 4);

                        ComplexNumber sum = number1.Add(number2);
                        Console.WriteLine($"Sum: {sum.Real} + {sum.Imaginary}i");

                        ComplexNumber difference = number1.Subtract(number2);
                        Console.WriteLine($"Difference: {difference.Real} + {difference.Imaginary}i");

                        ComplexNumber product = number1.Multiply(number2);
                        Console.WriteLine($"Product: {product.Real} + {product.Imaginary}i");

                        ComplexNumber quotient = number1.Divide(number2);
                        Console.WriteLine($"Quotient: {quotient.Real} + {quotient.Imaginary}i");

                        Console.ReadLine();

                        break;
                    }
                case 3:
                    {
                        Birthday birthday = new Birthday(new DateTime(2000, 4, 1));

                        Console.WriteLine($"Birth Day of Week: {birthday.GetBirthDayOfWeek()}");

                        DayOfWeek birthDayOfWeekIn2025 = birthday.GetBirthDayOfWeek(2025);
                        Console.WriteLine($"Birth Day of Week in 2025: {birthDayOfWeekIn2025}");

                        int daysUntilBirthday = birthday.GetDaysUntilBirthday();
                        Console.WriteLine($"Days Until Birthday: {daysUntilBirthday}");

                        Console.ReadLine();
                        break;
                    }
            }
        }
    }
}