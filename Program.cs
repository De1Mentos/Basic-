namespace С__Pack
{
    using System.Collections.Generic;

    public class PriorityQueue<T>
    {
        private List<T> elements;
        private IComparer<T> comparer;

        public int Count { get { return elements.Count; } }

        public PriorityQueue()
        {
            elements = new List<T>();
            comparer = Comparer<T>.Default;
        }

        public PriorityQueue(IComparer<T> customComparer)
        {
            elements = new List<T>();
            comparer = customComparer;
        }

        public void Enqueue(T item)
        {
            elements.Add(item);
            int childIndex = elements.Count - 1;

            while (childIndex > 0)
            {
                int parentIndex = (childIndex - 1) / 2;

                if (comparer.Compare(elements[childIndex], elements[parentIndex]) >= 0)
                    break;

                T temp = elements[childIndex];
                elements[childIndex] = elements[parentIndex];
                elements[parentIndex] = temp;

                childIndex = parentIndex;
            }
        }

        public T Dequeue()
        {
            if (elements.Count == 0)
                throw new InvalidOperationException("Queue is empty");

            T dequeuedItem = elements[0];
            int lastIndex = elements.Count - 1;
            elements[0] = elements[lastIndex];
            elements.RemoveAt(lastIndex);

            int parentIndex = 0;
            while (true)
            {
                int leftChildIndex = 2 * parentIndex + 1;
                int rightChildIndex = 2 * parentIndex + 2;

                if (leftChildIndex >= elements.Count)
                    break;

                int minChildIndex = leftChildIndex;
                if (rightChildIndex < elements.Count && comparer.Compare(elements[rightChildIndex], elements[leftChildIndex]) < 0)
                    minChildIndex = rightChildIndex;

                if (comparer.Compare(elements[minChildIndex], elements[parentIndex]) >= 0)
                    break;

                T temp = elements[minChildIndex];
                elements[minChildIndex] = elements[parentIndex];
                elements[parentIndex] = temp;

                parentIndex = minChildIndex;
            }

            return dequeuedItem;
        }

        public T Peek()
        {
            if (elements.Count == 0)
                throw new InvalidOperationException("Queue is empty");

            return elements[0];
        }
    }
    public class Swapper
    {
        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
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
                Swapper.Swap(ref a, ref b);
                Console.WriteLine($"a = {a}, b = {b}");

                string x = "JOE";
                string y = "BIDEN";
                Swapper.Swap(ref x, ref y);
                Console.WriteLine($"x = {x}, y = {y}");
            }
            static void Exercise2()
            {
                PriorityQueue<int> priorityQueue = new PriorityQueue<int>();

                priorityQueue.Enqueue(5);
                priorityQueue.Enqueue(10);
                priorityQueue.Enqueue(2);
                priorityQueue.Enqueue(8);

                while (priorityQueue.Count > 0)
                {
                    int item = priorityQueue.Dequeue();
                    Console.WriteLine(item);
                }
            }
            static void Exercise3()
            {
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