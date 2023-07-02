using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace С__Pack
{
    internal class Program
    {
        public delegate void MessageDelegate(string message);

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
            }
        }

        static void Exercise1()
        {
            MessageDelegate messageDelegate = DisplayMessage;

            messageDelegate("FIRST MESSAGE");
            messageDelegate("SECOND MESSAGE");

            Console.ReadLine();
        }

        static void DisplayMessage(string message)
        {
            Console.WriteLine("Повідомлення: " + message);
        }
    static void Exercise2()
        {
        }
        static void Exercise3()
        {
        }
        static void Exercise4()
        {
        }
    }
}