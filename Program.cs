using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;

namespace С__Pack
{
    internal class Program
    {
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
                default:
                    Console.WriteLine("Invalid exercise number.");
                    break;
            }
        }

        static void Exercise1()
        {
            Money money = new Money();

            while (true)
            {
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("1 - Put Dollars; 2 - Put Grivna; 3 - Put Euro; 4 - See money; 5 - Buy something");
                int valute = int.Parse(Console.ReadLine());

                switch (valute)
                {
                    case 1:
                        money.InputDataDollar();
                        break;
                    case 2:
                        money.InputDataGrivna();
                        break;
                    case 3:
                        money.InputDataEuro();
                        break;
                    case 4:
                        money.OutputData();
                        break;
                    case 5:
                        Console.WriteLine("Available items:");
                        for (int i = 0; i < money.items.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {money.items[i].Name} - ${money.items[i].Price}");
                        }
                        Console.WriteLine("Select an item to buy (enter the item number):");
                        int itemNumber = int.Parse(Console.ReadLine());
                        if (itemNumber >= 1 && itemNumber <= money.items.Count)
                        {
                            Item selected = money.items[itemNumber - 1];
                            if (money.GetDollars() >= selected.Price && selected.Quantity > 0)
                            {
                                money.SetDollars(money.GetDollars() - selected.Price);
                                selected.Quantity--;
                                Console.WriteLine($"You bought {selected.Name} for ${selected.Price}. Remaining balance: {money.GetDollars()}");
                            }
                            else
                            {
                                Console.WriteLine("Insufficient funds or item not available.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid item number.");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
        }

        static void Exercise2()
        {
            Kettle kettle = new Kettle("Electric Kettle", "Powerful electric kettle for quick boiling.");
            Microwave microwave = new Microwave("Microwave Oven", "Versatile microwave oven for cooking and heating.");
            Car car = new Car("Sports Car", "Fast and stylish sports car for a thrilling driving experience.");
            Steamship steamship = new Steamship("Steamship", "Classic steamship for luxurious sea voyages.");

            kettle.Show();
            kettle.Desc();
            kettle.Sound();

            Console.WriteLine();

            microwave.Show();
            microwave.Desc();
            microwave.Sound();

            Console.WriteLine();

            car.Show();
            car.Desc();
            car.Sound();

            Console.WriteLine();

            steamship.Show();
            steamship.Desc();
            steamship.Sound();

            Console.ReadLine();
        }

        static void Exercise3()
        {
            Violin violin = new Violin("Violin", "A classical string instrument with a rich sound.");
            Trombone trombone = new Trombone("Trombone", "A brass instrument with a slide for changing the pitch.");
            Ukulele ukulele = new Ukulele("Ukulele", "A small guitar-like instrument with a bright and cheerful sound.");
            Cello cello = new Cello("Cello", "A large bowed string instrument with a warm and resonant tone.");

            violin.Show();
            violin.Desc();
            violin.Sound();
            violin.History();

            Console.WriteLine();

            trombone.Show();
            trombone.Desc();
            trombone.Sound();
            trombone.History();

            Console.WriteLine();

            ukulele.Show();
            ukulele.Desc();
            ukulele.Sound();
            ukulele.History();

            Console.WriteLine();

            cello.Show();
            cello.Desc();
            cello.Sound();
            cello.History();

            Console.ReadLine();
        }

        static void Exercise4()
        {
            President president = new President("John Biden", 1000000);
            Security security = new Security("Jane Smith", "Day Shift");
            Manager manager = new Manager("David Johnson", "Sales");
            Engineer engineer = new Engineer("Emily Brown", "Software");

            president.Print();
            Console.WriteLine();

            security.Print();
            Console.WriteLine();

            manager.Print();
            Console.WriteLine();

            engineer.Print();
            Console.WriteLine();

            Console.ReadLine();
        }
    }

    public class Money
    {
        private double dollars;
        public List<Item> items;

        public double GetDollars()
        {
            return dollars;
        }

        public void SetDollars(double value)
        {
            dollars = value;
        }

        public Money()
        {
            items = new List<Item>();
            InitializeItems();
        }

        private void InitializeItems()
        {
            items.Add(new Item { Name = "Item 1", Price = 10.0, Quantity = 5 });
            items.Add(new Item { Name = "Item 2", Price = 20.0, Quantity = 10 });
            items.Add(new Item { Name = "Item 3", Price = 15.0, Quantity = 3 });
            // Add more items as needed
        }

        public void InputDataDollar()
        {
            Console.WriteLine("How much Dollars do you want to put into your bank? Dollars.Cents ");
            dollars += double.Parse(Console.ReadLine());
        }

        public void InputDataGrivna()
        {
            Console.WriteLine("How much Grivnas do you want to put into your bank? Grivna.Kopeiki ");
            double grivna;
            grivna = double.Parse(Console.ReadLine());
            dollars += grivna / 36.93;
        }

        public void InputDataEuro()
        {
            Console.WriteLine("How much Euros do you want to put into your bank? Euro.Cents ");
            double euro;
            euro = double.Parse(Console.ReadLine());
            dollars += euro * 1.09;
        }

        public void OutputData()
        {
            Console.WriteLine(GetDollars());
        }
    }

    public class Item
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
    }
    class Device
    {
        protected string name;
        protected string description;

        public Device(string name, string description)
        {
            this.name = name;
            this.description = description;
        }

        public void Show()
        {
            Console.WriteLine($"Device: {name}");
        }

        public void Desc()
        {
            Console.WriteLine($"Description: {description}");
        }

        public virtual void Sound()
        {
            Console.WriteLine("The device makes a sound.");
        }
    }

    class Kettle : Device
    {
        public Kettle(string name, string description) : base(name, description)
        {
        }

        public override void Sound()
        {
            Console.WriteLine("fuuuUUUUUUUUUUUUUUUUUUUUUUUU");
        }
    }

    class Microwave : Device
    {
        public Microwave(string name, string description) : base(name, description)
        {
        }

        public override void Sound()
        {
            Console.WriteLine("MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM");
        }
    }

    class Car : Device
    {
        public Car(string name, string description) : base(name, description)
        {
        }

        public override void Sound()
        {
            Console.WriteLine("BRU BRU BRU BRU");
        }
    }

    class Steamship : Device
    {
        public Steamship(string name, string description) : base(name, description)
        {
        }

        public override void Sound()
        {
            Console.WriteLine("BRRRRRRRRRR.");
        }
    }
    class MusicalInstrument
    {
        protected string name;
        protected string description;

        public MusicalInstrument(string name, string description)
        {
            this.name = name;
            this.description = description;
        }

        public void Show()
        {
            Console.WriteLine($"Instrument: {name}");
        }

        public void Desc()
        {
            Console.WriteLine($"Description: {description}");
        }

        public virtual void Sound()
        {
            Console.WriteLine("The instrument makes a sound.");
        }

        public virtual void History()
        {
            Console.WriteLine("The instrument has a rich history.");
        }
    }

    class Violin : MusicalInstrument
    {
        public Violin(string name, string description) : base(name, description)
        {
        }

        public override void Sound()
        {
            Console.WriteLine("VIN VIN");
        }

        public override void History()
        {
            Console.WriteLine("The violin has been played for centuries and is an integral part of classical music.");
        }
    }

    class Trombone : MusicalInstrument
    {
        public Trombone(string name, string description) : base(name, description)
        {
        }

        public override void Sound()
        {
            Console.WriteLine("puuuUUUUuum");
        }

        public override void History()
        {
            Console.WriteLine("The trombone has roots dating back to ancient civilizations and has evolved over centuries.");
        }
    }

    class Ukulele : MusicalInstrument
    {
        public Ukulele(string name, string description) : base(name, description)
        {
        }

        public override void Sound()
        {
            Console.WriteLine("DZEN DZEN DZIN.");
        }

        public override void History()
        {
            Console.WriteLine("The ukulele originated in Hawaii and gained popularity worldwide in the 20th century.");
        }
    }

    class Cello
         : MusicalInstrument
    {
        public Cello(string name, string description) : base(name, description)
        {
        }

        public override void Sound()
        {
            Console.WriteLine("RYAAAAA.");
        }

        public override void History()
        {
            Console.WriteLine("The cello is a key instrument in orchestras and chamber music, with a history dating back several centuries.");
        }
    }
    abstract class Worker
    {
        protected string name;

        public Worker(string name)
        {
            this.name = name;
        }

        public abstract void Print();
    }

    class President : Worker
    {
        private double salary;

        public President(string name, double salary) : base(name)
        {
            this.salary = salary;
        }

        public override void Print()
        {
            Console.WriteLine("President:");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Salary: $" + salary);
        }
    }

    class Security : Worker
    {
        private string shift;

        public Security(string name, string shift) : base(name)
        {
            this.shift = shift;
        }

        public override void Print()
        {
            Console.WriteLine("Security:");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Shift: " + shift);
        }
    }

    class Manager : Worker
    {
        private string department;

        public Manager(string name, string department) : base(name)
        {
            this.department = department;
        }

        public override void Print()
        {
            Console.WriteLine("Manager:");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Department: " + department);
        }
    }

    class Engineer : Worker
    {
        private string specialization;

        public Engineer(string name, string specialization) : base(name)
        {
            this.specialization = specialization;
        }

        public override void Print()
        {
            Console.WriteLine("Engineer:");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Specialization: " + specialization);
        }
    }
}