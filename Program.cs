using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography.X509Certificates;

namespace С__Pack
{
    interface ICalc
    {
        int Less();
        int Greater();
    }
    interface ICalc2
    {
        int CountDistinct();
        int EqualToValue();
    }
    interface IOutput2
    {
        void ShowEven();
        void ShowOdd();
    }
    class IntArray : ICalc , IOutput2, ICalc2
    {
        private int[] array;

        public IntArray(int[] arr)
        {
            array = arr;
        }
        public int Less()
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 3)
                {
                    Console.Write(array[i]); Console.Write(" is less than "); Console.Write("3"); Console.WriteLine(" ");
                }
            }
            return 0;
        }
        public int Greater()
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 3)
                {
                    Console.Write(array[i]); Console.Write(" is greater than "); Console.Write("3"); Console.WriteLine(" ");
                }
            }
            return 0;
        }
        public void ShowEven()
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 1)
                {
                    Console.Write(array[i]); Console.Write(" is even"); Console.WriteLine(" ");
                }
            }
        }
        public void ShowOdd()
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 1)
                {

                }
                else
                {
                    Console.Write(array[i]); Console.Write(" is odd"); Console.WriteLine(" ");
                }
            }
        }
        public int CountDistinct()
        {

            HashSet<int> uniqueValues = new HashSet<int>(array);
            int count = uniqueValues.Count;

            return count;
        }
        public int EqualToValue()
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == 3)
                {

                }
            }
            return 0;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 2, 7, 1, 9 };

            IntArray intArray = new IntArray(arr);
            Console.WriteLine("What exercise do you want to see? 1-3:");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    {
                        int Less = intArray.Less();
                        int Greater = intArray.Greater();
                        break;
                    }
                case 2:
                    {
                        intArray.ShowEven();
                        intArray.ShowOdd();
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








