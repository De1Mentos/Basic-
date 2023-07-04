using System;

interface IOutput
{
    void Show();
    void Show(string info);
}

interface IMath
{
    int Max();
    int Min();
    float Avg();
    bool Search(int valueToSearch);
}

interface ISort
{
    void SortAsc();
    void SortDesc();
}

class IntArray : IOutput, IMath, ISort
{
    private int[] array;

    public IntArray(int[] arr)
    {
        array = arr;
    }

    public void Show()
    {
        Console.WriteLine("Array elements:");
        foreach (var element in array)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }

    public void Show(string info)
    {
        Console.WriteLine(info);
        Show();
    }

    public int Max()
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
    }

    public int Min()
    {
        int min = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
            }
        }
        return min;
    }

    public float Avg()
    {
        int sum = 0;
        foreach (var element in array)
        {
            sum += element;
        }
        return (float)sum / array.Length;
    }

    public bool Search(int valueToSearch)
    {
        foreach (var element in array)
        {
            if (element == valueToSearch)
            {
                return true;
            }
        }
        return false;
    }

    public void SortAsc()
    {
        Array.Sort(array);
    }

    public void SortDesc()
    {
        Array.Sort(array);
        Array.Reverse(array);
    }
}

class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 5, 2, 7, 1, 9 };

        IntArray intArray = new IntArray(arr);

        Console.WriteLine("Select an operation:");
        Console.WriteLine("1. Show array");
        Console.WriteLine("2. Show array with info");
        Console.WriteLine("3. Find maximum value");
        Console.WriteLine("4. Find minimum value");
        Console.WriteLine("5. Calculate average");
        Console.WriteLine("6. Search for a value");
        Console.WriteLine("7. Sort array in ascending order");
        Console.WriteLine("8. Sort array in descending order");

        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                intArray.Show();
                break;
            case 2:
                Console.WriteLine("Enter info:");
                string info = Console.ReadLine();
                intArray.Show(info);
                break;
            case 3:
                int max = intArray.Max();
                Console.WriteLine("Maximum value: " + max);
                break;
            case 4:
                int min = intArray.Min();
                Console.WriteLine("Minimum value: " + min);
                break;
            case 5:
                float avg = intArray.Avg();
                Console.WriteLine("Average: " + avg);
                break;
            case 6:
                Console.WriteLine("Enter value to search:");
                int valueToSearch = Convert.ToInt32(Console.ReadLine());
                bool found = intArray.Search(valueToSearch);
                if (found)
                {
                    Console.WriteLine("Value found in the array.");
                }
                else
                {
                    Console.WriteLine("Value not found in the array.");
                }
                break;
            case 7:
                intArray.SortAsc();
                Console.WriteLine("Array sorted in ascending order:");
                intArray.Show();
                break;
            case 8:
                intArray.SortDesc();
                Console.WriteLine("Array sorted in descending order:");
                intArray.Show();
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }
}