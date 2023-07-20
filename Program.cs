namespace С__Pack
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class FootballPlayer
    {
        public string Name { get; set; }
        public int Number { get; set; }
        public string Position { get; set; }

        public FootballPlayer(string name, int number, string position)
        {
            Name = name;
            Number = number;
            Position = position;
        }
    }

    public class FootballTeam : IEnumerable<FootballPlayer>
    {
        private List<FootballPlayer> players;

        public FootballTeam()
        {
            players = new List<FootballPlayer>();
        }

        public void AddPlayer(FootballPlayer player)
        {
            players.Add(player);
        }

        public IEnumerator<FootballPlayer> GetEnumerator()
        {
            return players.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
    public class MarineCreature
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public int Age { get; set; }
        public string Description { get; set; }

        public MarineCreature(string name, string species, int age, string description)
        {
            Name = name;
            Species = species;
            Age = age;
            Description = description;
        }
    }

    public class Dolphin : MarineCreature
    {
        public int JumpHeight { get; set; }

        public Dolphin(string name, string species, int age, string description, int jumpHeight) : base(name, species, age, description)
        {
            JumpHeight = jumpHeight;
        }
    }

    public class Shark : MarineCreature
    {
        public bool IsDangerous { get; set; }
        public Shark(string name, string species, int age, string description, bool isDangerous) : base(name, species, age, description)
        {
            IsDangerous = isDangerous;
        }
    }

    public class Oceanarium : IEnumerable<MarineCreature>
    {
        private List<MarineCreature> creatures;

        public Oceanarium()
        {
            creatures = new List<MarineCreature>();
        }

        public void AddCreature(MarineCreature creature)
        {
            creatures.Add(creature);
        }

        public IEnumerator<MarineCreature> GetEnumerator()
        {
            return creatures.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose an exercise (1-3):");
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
                    static void Exercise1()
                    {
                        Oceanarium myOceanarium = new Oceanarium();

                        myOceanarium.AddCreature(new Dolphin("DOLPE", "Smart Dolphin", 5, "Friendly and cool^^" , 3));
                        myOceanarium.AddCreature(new Shark("KUSAKA", "Great White", 15, "Angry and bity >w<", true));
                        foreach (MarineCreature creature in myOceanarium)
                        {
                            Console.WriteLine($"Name: {creature.Name}, Species: {creature.Species}, Age: {creature.Age}, Description: {creature.Description}");
                            if (creature is Dolphin dolphin)
                            {
                                Console.WriteLine($"Jump Height: {dolphin.JumpHeight}");
                            }
                            else if (creature is Shark shark)
                            {
                                Console.WriteLine($"Is Dangerous: {shark.IsDangerous}");
                            }
                            Console.WriteLine();
                        }
                    }
                    static void Exercise2()
                    {
                        FootballTeam myTeam = new FootballTeam();

                        myTeam.AddPlayer(new FootballPlayer("Habibi Sus", 10, "Forward"));
                        myTeam.AddPlayer(new FootballPlayer("JOHN. JOHN SMITH", 5, "Defender"));
                        myTeam.AddPlayer(new FootballPlayer("Mike Vasovski", 1, "Goalkeeper"));

                        Console.WriteLine("Football Team Players:");
                        foreach (FootballPlayer player in myTeam)
                        {
                            Console.WriteLine($"Name: {player.Name}, Number: {player.Number}, Position: {player.Position}");
                        }
                    }
                    static void Exercise3()
                    {

                    }
            }
        }
    }
}