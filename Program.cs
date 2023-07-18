namespace С__Pack
{
    using System.Collections.Generic;

    public class LinkedList<T>
    {
        private class Node
        {
            public T Value { get; set; }
            public Node Next { get; set; }

            public Node(T value)
            {
                Value = value;
                Next = null;
            }
        }

        private Node head;
        private Node tail;
        private int count;

        public LinkedList()
        {
            head = null;
            tail = null;
            count = 0;
        }

        public int Count
        {
            get { return count; }
        }

        public bool IsEmpty
        {
            get { return count == 0; }
        }

        public void AddFirst(T value)
        {
            Node newNode = new Node(value);

            if (IsEmpty)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                newNode.Next = head;
                head = newNode;
            }

            count++;
        }

        public void AddLast(T value)
        {
            Node newNode = new Node(value);

            if (IsEmpty)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail.Next = newNode;
                tail = newNode;
            }

            count++;
        }

        public void RemoveFirst()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("List is empty");
            }

            if (head == tail)
            {
                head = null;
                tail = null;
            }
            else
            {
                head = head.Next;
            }

            count--;
        }

        public void RemoveLast()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("List is empty");
            }

            if (head == tail)
            {
                head = null;
                tail = null;
            }
            else
            {
                Node current = head;
                while (current.Next != tail)
                {
                    current = current.Next;
                }
                current.Next = null;
                tail = current;
            }

            count--;
        }

        public bool Contains(T value)
        {
            Node current = head;
            while (current != null)
            {
                if (current.Value.Equals(value))
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
        }
    }
    public class CircularQueue<T>
    {
        private T[] queueArray;
        private int front;
        private int rear;
        private int size;

        public CircularQueue(int capacity)
        {
            queueArray = new T[capacity];
            front = 0;
            rear = -1;
            size = 0;
        }

        public int Count
        {
            get { return size; }
        }

        public int Capacity
        {
            get { return queueArray.Length; }
        }

        public bool IsEmpty
        {
            get { return size == 0; }
        }

        public bool IsFull
        {
            get { return size == queueArray.Length; }
        }

        public void Enqueue(T item)
        {
            if (IsFull)
            {
                throw new InvalidOperationException("Queue is full");
            }

            rear = (rear + 1) % queueArray.Length;
            queueArray[rear] = item;
            size++;
        }

        public T Dequeue()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("Queue is empty");
            }

            T dequeuedItem = queueArray[front];
            queueArray[front] = default(T);
            front = (front + 1) % queueArray.Length;
            size--;
            return dequeuedItem;
        }

        public T Peek()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("Queue is empty");
            }

            return queueArray[front];
        }

        public void Clear()
        {
            Array.Clear(queueArray, 0, queueArray.Length);
            front = 0;
            rear = -1;
            size = 0;
        }
    }
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
                CircularQueue<string> queue = new CircularQueue<string>(5);

                queue.Enqueue("Елемент 1");
                queue.Enqueue("Елемент 2");
                queue.Enqueue("Елемент 3");

                int count = queue.Count;

                string firstItem = queue.Peek();

                string dequeuedItem = queue.Dequeue();

                count = queue.Count;

                queue.Clear();

                bool isEmpty = queue.IsEmpty;
            }
            static void Exercise4()
            {
                LinkedList<int> list = new LinkedList<int>();

                list.AddFirst(10);
                list.AddLast(20);
                list.AddLast(30);

                int count = list.Count;

                bool contains = list.Contains(20);

                list.RemoveFirst();

                list.RemoveLast();

                list.Clear();

                bool isEmpty = list.IsEmpty;
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