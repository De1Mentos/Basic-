namespace С__Pack
{
    class Animal
    {
        public string Name { get; set; }

        public Animal(string name)
        {
            Name = name;
        }

        public virtual void Sound()
        {
            Console.WriteLine("SOUND");
        }
    }
    class Tiger : Animal
    {
        public string Color { get; set; }

        public Tiger(string name, string color) : base(name)
        {
            Color = color;
        }

        public override void Sound()
        {
            Console.WriteLine("ROOOAR");
        }
    }
    class Crocodile : Animal
    {
        public int Length { get; set; }

        public Crocodile(string name, int length) : base(name)
        {
            Length = length;
        }

        public override void Sound()
        {
            Console.WriteLine("Crocodile Sound.exe");
        }
    }

    class Kangaroo : Animal
    {
        public int JumpHeight { get; set; }

        public Kangaroo(string name, int jumpHeight) : base(name)
        {
            JumpHeight = jumpHeight;
        }

        public override void Sound()
        {
            Console.WriteLine("Kangaroo sound");
        }
    }
    class Passport
    {
        public string FullName { get; set; }
        public string Country { get; set; }

        public void Introduction()
        {
            Console.WriteLine($"This human is {FullName}, and he's from {Country}");
        }
    }
    class Foreight : Passport
    {
        public string VISA { get; set; }
        public void ForeightPassport()
        {
            Console.WriteLine($"VISA is {VISA}");
        }
    }
    class Human
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void Introduction()
        {
            Console.WriteLine($"Hello, my name is {Name}, im {Age} old");
        }
    }
    class Builder : Human
    {
        public string Specialization { get; set; }

        public void Build()
        {
            Console.WriteLine($"Im builder with specializations on {Specialization}. Building...");
        }
    }
    class Sailor : Human
    {
        public string ShipName { get; set; }

        public void Sail()
        {
            Console.WriteLine($"Im sailor with ship named {ShipName}. Hitting iceberg!");
        }
    }
    class Pilot : Human
    {
        public string AircraftModel { get; set; }

        public void Fly()
        {
            Console.WriteLine($"Im flying on {AircraftModel}. Starting the flight!");
        }
    }
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
                }
            static void Exercise1()
            {
                Builder builder = new Builder();
                builder.Name = "IGOR BUILDO";
                builder.Age = 35;
                builder.Specialization = "Building eco-toilets";
                builder.Introduction();
                builder.Build();

                Sailor sailor = new Sailor();
                sailor.Name = "PETR SAIL";
                sailor.Age = 45;
                sailor.ShipName = "Titanic";
                sailor.Introduction();
                sailor.Sail();

                Pilot pilot = new Pilot();
                pilot.Name = "OLEXEY ZERO";
                pilot.Age = 30;
                pilot.AircraftModel = "KUKURUZDNIK";
                pilot.Introduction();
                pilot.Fly();

                Console.ReadLine();
            }
            static void Exercise2()
            {
                Foreight foreight = new Foreight();
                foreight.FullName = "JOE BIDEN";
                foreight.Country = "America";
                foreight.VISA = "(I have no idea how VISAs called)";
                foreight.Introduction();
                foreight.ForeightPassport();
            }
            static void Exercise3()
            {
                Tiger tiger = new Tiger("Tiger", "yellow");
                Console.WriteLine($"Name: {tiger.Name}");
                Console.WriteLine($"Colour: {tiger.Color}");
                tiger.Sound();

                Crocodile crocodile = new Crocodile("Crocodile", 4);
                Console.WriteLine($"Name: {crocodile.Name}");
                Console.WriteLine($"Lengh: {crocodile.Length} m");
                crocodile.Sound();

                Kangaroo kangaroo = new Kangaroo("Kangaroo", 3);
                Console.WriteLine($"Name: {kangaroo.Name}");
                Console.WriteLine($"Jump Height: {kangaroo.JumpHeight} m");
                kangaroo.Sound();

                Console.ReadLine();
            }
            static void Exercise4()
            {
            }
        }
    }
}
