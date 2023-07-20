namespace С__Pack
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class Garage : IEnumerable<Car>
    {
        private List<Car> cars;

        public Garage()
        {
            cars = new List<Car>();
        }

        public void AddCar(Car car)
        {
            cars.Add(car);
        }

        public IEnumerator<Car> GetEnumerator()
        {
            return cars.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
    }
    public class Apartment
    {
        public string ApartmentNumber { get; set; }
        public List<string> Residents { get; set; }

        public Apartment(string apartmentNumber)
        {
            ApartmentNumber = apartmentNumber;
            Residents = new List<string>();
        }
    }

    public class House : IEnumerable<Apartment>
    {
        private List<Apartment> apartments;

        public House()
        {
            apartments = new List<Apartment>();
        }

        public void AddApartment(Apartment apartment)
        {
            apartments.Add(apartment);
        }

        public IEnumerator<Apartment> GetEnumerator()
        {
            return apartments.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class Alphabet : IEnumerable<char>
    {
        private char[] letters;

        public Alphabet()
        {
            letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        }

        public IEnumerator<char> GetEnumerator()
        {
            for (int i = 0; i < letters.Length; i++)
            {
                yield return letters[i];
            }
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
            }
            static void Exercise1()
            {
                Alphabet alphabet = new Alphabet();

                foreach (char letter in alphabet)
                {
                    Console.Write(letter + " ");
                }
            }
            static void Exercise2()
            {
                House house = new House();
                house.AddApartment(new Apartment("1A"));
                house.AddApartment(new Apartment("2B"));
                house.AddApartment(new Apartment("3C"));

                house.ElementAt(0).Residents.Add("Joe");
                house.ElementAt(0).Residents.Add("Trump");
                house.ElementAt(1).Residents.Add("Washington");
                house.ElementAt(2).Residents.Add("Zelenskiy");

                foreach (Apartment apartment in house)
                {
                    Console.WriteLine("Apartment Number: " + apartment.ApartmentNumber);
                    Console.WriteLine("Residents: ");
                    foreach (string resident in apartment.Residents)
                    {
                        Console.WriteLine("- " + resident);
                    }
                    Console.WriteLine();
                }
            }
            static void Exercise3()
            {
                Garage myGarage = new Garage();

                myGarage.AddCar(new Car { Make = "Submraine", Model = "Torpedo", Year = 1937 });
                myGarage.AddCar(new Car { Make = "Honda", Model = "Civic", Year = 2019 });
                myGarage.AddCar(new Car { Make = "Ford", Model = "Focus", Year = 2022 });

                foreach (Car car in myGarage)
                {
                    Console.WriteLine($"Make: {car.Make}, Model: {car.Model}, Year: {car.Year}");
                }
            }
        }
    }
}
