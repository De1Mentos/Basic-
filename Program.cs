namespace С__Pack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bruh//
            Console.WriteLine("EX 1");
            Console.Write("Write a number between 1 and 100: ");
            int number;

            if (int.TryParse(Console.ReadLine(), out number))
            {
                if (number >= 1 && number <= 100)
                {
                    if (number % 3 == 0)
                    {
                        Console.WriteLine("FIZZ");
                    }
                    if (number % 5 == 0)
                    {
                        Console.WriteLine("BUZZ");
                    }
                    else
                    {
                        Console.WriteLine(number);
                    }
                }
                else
                {
                    Console.WriteLine("Error. Wrong number, write a number between 1 and 100");
                }
            }
            else
            {
                Console.WriteLine("Error. Parihmaher Dadya tolic, podstregi menya pod nolik");
            }
            Console.WriteLine("EX 2");
            double? numberUber = null;
            int? a = null;
            int? b = null;
            Console.Write("Input number: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input procent (1 - 100): ");
            b = Convert.ToInt32(Console.ReadLine());
            if (b >= 101 || b <= 0)
            {
                Console.Write("Fatal error, number is not 1 - 100: ");
            }
            else
            {
                numberUber = a / b;
                Console.Write(numberUber); Console.Write("%");
            }

            Console.WriteLine("EX 3");
            int? q = null;
            int? w = null;
            int? e = null;
            int? r = null;
            Console.Write("Input number 1: ");
            q = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input number 2: ");
            w = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input number 3: ");
            e = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input number 4: ");
            r = Convert.ToInt32(Console.ReadLine());
            Console.Write(q); Console.Write(w); Console.Write(e); Console.Write(r);

            Console.WriteLine("EX 6");
            int? t = null;
            Console.Write("Input temperature in Celcius: ");
            t = Convert.ToInt32(Console.ReadLine());
            Console.Write("Forengeit = "); Console.Write(t * 9 / 5 + 32);

            Console.WriteLine("EX 7");
            int z = 0;
            int x = 0;
            Console.Write("Input number 1: ");
            z = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input number 2: ");
            x = Convert.ToInt32(Console.ReadLine());
            if (z > x)
            {
                for (int i = x; i < z; i++)
                {
                   if (i % 2 == 0)
                    {
                        Console.Write(i);
                    }
                }
            }
            else
            {
                for (int i = z; i < x; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }
}