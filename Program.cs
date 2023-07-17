namespace С__Pack

{
    using System.Collections.Generic;
    public class Stack<T>
    {
        private List<T> items;

        public Stack()
        {
            items = new List<T>();
        }

        public int Count
        {
            get { return items.Count; }
        }

        public void Push(T item)
        {
            items.Add(item);
        }

        public T Pop()
        {
            if (items.Count == 0)
            {
                throw new InvalidOperationException("Стек порожній.");
            }

            int lastIndex = items.Count - 1;
            T lastItem = items[lastIndex];
            items.RemoveAt(lastIndex);
            return lastItem;
        }

        public T Peek()
        {
            if (items.Count == 0)
            {
                throw new InvalidOperationException("Стек порожній.");
            }

            return items[items.Count - 1];
        }
    }
    public class ArraySumCalculator<T>
    {
        public T GetArraySum(T[] array)
        {
            T sum = default(T);

            foreach (T element in array)
            {
                sum = Add(sum, element);
            }

            return sum;
        }

        private T Add(T a, T b)
        {
            dynamic dynamicA = a;
            dynamic dynamicB = b;
            return dynamicA + dynamicB;
        }
    }
    public class MaximumCalculator<T> where T : IComparable<T>
    {
        public T GetMaximum(T a, T b, T c)
        {
            T maximum = a;

            if (b.CompareTo(maximum) > 0)
            {
                maximum = b;
            }

            if (c.CompareTo(maximum) > 0)
            {
                maximum = c;
            }

            return maximum;
        }
    }
    public class MinimumCalculator<T> where T : IComparable<T>
    {
        public T GetMinimum(T a, T b, T c)
        {
            T minimum = a;

            if (b.CompareTo(minimum) < 0)
            {
                minimum = b;
            }

            if (c.CompareTo(minimum) < 0)
            {
                minimum = c;
            }

            return minimum;
        }
    }
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
                int a = 5;
                int b = 10;
                int c = 7;

                MaximumCalculator<int> calculator = new MaximumCalculator<int>();
                int maximum = calculator.GetMaximum(a, b, c);
                Console.WriteLine("Maximum: " + maximum);

                double x = 3.14;
                double y = 2.71;
                double z = 1.618;

                MaximumCalculator<double> calculator2 = new MaximumCalculator<double>();
                double maximum2 = calculator2.GetMaximum(x, y, z);
                Console.WriteLine("Maximum: " + maximum2);
            }
            static void Exercise2()
            {
                int a = 5;
                int b = 10;
                int c = 7;

                MinimumCalculator<int> calculator = new MinimumCalculator<int>();
                int minimum = calculator.GetMinimum(a, b, c);
                Console.WriteLine("Minimum: " + minimum);

                double x = 3.14;
                double y = 2.71;
                double z = 1.618;

                MinimumCalculator<double> calculator2 = new MinimumCalculator<double>();
                double minimum2 = calculator2.GetMinimum(x, y, z);
                Console.WriteLine("Minimum: " + minimum2);
            }
            static void Exercise3()
            {
                int[] intArray = { 1, 2, 3, 4, 5 };
                ArraySumCalculator<int> intArraySumCalculator = new ArraySumCalculator<int>();
                int intArraySum = intArraySumCalculator.GetArraySum(intArray);
                Console.WriteLine("Array Sum: " + intArraySum);

                double[] doubleArray = { 1.5, 2.5, 3.5, 4.5 };
                ArraySumCalculator<double> doubleArraySumCalculator = new ArraySumCalculator<double>();
                double doubleArraySum = doubleArraySumCalculator.GetArraySum(doubleArray);
                Console.WriteLine("Array Sum: " + doubleArraySum);
            }
            static void Exercise4()
            {
            }
            static void Exercise5()
            {
            }
            static void Exercise6()
            {
            }
        }
    }
    }