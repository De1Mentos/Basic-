namespace С__Pack
{
    internal class Program
    {
        delegate int CalculateSquareDelegate(int number);
        delegate bool CheckEvenDelegate(int number);
        delegate int CalculateCubeDelegate(int number);
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

                CheckEvenDelegate checkEven = delegate (int number)
                {
                    return number % 2 == 0;
                };

                Console.WriteLine(checkEven(4)); 
                Console.WriteLine(checkEven(7)); 
            }
            static void Exercise2()
            {
            CalculateSquareDelegate calculateSquare = delegate (int number)
            {
                return number * number;
            };

            Console.WriteLine(calculateSquare(5)); 
            Console.WriteLine(calculateSquare(8));
        }
            static void Exercise3()
            {
            CalculateCubeDelegate calculateCube = number => number * number * number;

            Console.WriteLine(calculateCube(2));
            Console.WriteLine(calculateCube(3));
        }
            static void Exercise4()
            {
            Func<DateTime, bool> isProgrammersDay = date => date.DayOfYear == 256;

            DateTime date1 = new DateTime(2023, 9, 13);
            DateTime date2 = new DateTime(2023, 1, 1); 

            Console.WriteLine(isProgrammersDay(date1));
            Console.WriteLine(isProgrammersDay(date2));
        }
            static void Exercise5()
            {
            Func<int[], int> findMax = array =>
            {
                int max = array[0];
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] > max)
                    {
                        max = array[i];
                    }
                }
                return max;
            };
            int[] numbers1 = { 5, 10, 3, 8, 2 };    
            int[] numbers2 = { -1, -5, -10, -3 };    

            Console.WriteLine(findMax(numbers1));   
            Console.WriteLine(findMax(numbers2));   
        }
            static void Exercise6()
            {

            }
            static void Exercise7()
            {

            }
        }
    }