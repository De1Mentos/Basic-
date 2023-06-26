namespace С__Pack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose an exercise (1-7):");
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
                case 7:
                    Exercise7();
                    break;
                default:
                    Console.WriteLine("Invalid exercise number.");
                    break;
            }
            static void Exercise1()
            {
                Console.Write("Write first number: ");
                int number1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Write second number: ");
                int number2 = Convert.ToInt32(Console.ReadLine());
                int Dobutok = Convert.ToInt32(null);
                if (number1 >= number2)
                {
                    for (int i = number1; i < number2; i++)
                    {
                        Dobutok += i * number1;
                    }
                }
                if (number1 <= number2)
                {
                    for (int i = number2; i < number1; i++)
                    {
                        Dobutok += i * number2;
                    }
                }
                Console.Write(Dobutok);
            }
            static void Exercise2()
            {
                int number = 34;
                bool isFibonacci = IsFibonacciNumber(number);
                Console.WriteLine($"{number} is Fibonacci number: {isFibonacci}");
            }
            static void Exercise3()
            {
                Console.WriteLine("Skipped");
            }
            static void Exercise4()
            {
                City city = new City();
                city.InputData();
                Console.WriteLine("----------------------");
                city.OutputData();
            }
            static void Exercise5()
            {
                Employee employee = new Employee();
                employee.InputData();
                Console.WriteLine("----------------------");
                employee.OutputData();
            }
            static void Exercise6()
            {
                Airplane airplane1 = new Airplane("Boeing 747", "Boeing");
                airplane1.SetYearOfManufacture(2005);
                airplane1.SetAirplaneType("Passenger");
                airplane1.OutputData();

                Console.WriteLine("----------------------");

                Airplane airplane2 = new Airplane("Airbus A380", "Airbus", 2010, "Passenger");
                airplane2.OutputData();

                Console.WriteLine("----------------------");

                Airplane airplane3 = new Airplane("Cessna 172", "Cessna");
                airplane3.InputData();
                Console.WriteLine("----------------------");
                airplane3.OutputData();
            }
            static void Exercise7()
            {
                Console.WriteLine("It's literally EX6");
            }

        }

        public class Airplane
        {
            private string airplaneName;
            private string manufacturer;
            private int yearOfManufacture;
            private string airplaneType;

            public Airplane(string name, string manufacturer)
            {
                airplaneName = name;
                this.manufacturer = manufacturer;
            }

            public Airplane(string name, string manufacturer, int year, string type)
            {
                airplaneName = name;
                this.manufacturer = manufacturer;
                yearOfManufacture = year;
                airplaneType = type;
            }

            public void SetYearOfManufacture(int year)
            {
                yearOfManufacture = year;
            }

            public void SetAirplaneType(string type)
            {
                airplaneType = type;
            }

            public void InputData()
            {
                Console.WriteLine("Введіть назву літака:");
                airplaneName = Console.ReadLine();

                Console.WriteLine("Введіть назву виробника:");
                manufacturer = Console.ReadLine();

                Console.WriteLine("Введіть рік випуску:");
                yearOfManufacture = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введіть тип літака:");
                airplaneType = Console.ReadLine();
            }

            public void OutputData()
            {
                Console.WriteLine("Назва літака: " + airplaneName);
                Console.WriteLine("Назва виробника: " + manufacturer);
                Console.WriteLine("Рік випуску: " + yearOfManufacture);
                Console.WriteLine("Тип літака: " + airplaneType);
            }
        }

        public class Employee
        {
            private string fullName;
            private DateTime dateOfBirth;
            private string contactPhone;
            private string workEmail;
            private string position;
            private string jobDescription;

            public void SetFullName(string name)
            {
                fullName = name;
            }

            public string GetFullName()
            {
                return fullName;
            }

            public void SetDateOfBirth(DateTime date)
            {
                dateOfBirth = date;
            }

            public DateTime GetDateOfBirth()
            {
                return dateOfBirth;
            }

            public void SetContactPhone(string phone)
            {
                contactPhone = phone;
            }

            public string GetContactPhone()
            {
                return contactPhone;
            }

            public void SetWorkEmail(string email)
            {
                workEmail = email;
            }

            public string GetWorkEmail()
            {
                return workEmail;
            }

            public void SetPosition(string position)
            {
                this.position = position;
            }

            public string GetPosition()
            {
                return position;
            }

            public void SetJobDescription(string description)
            {
                jobDescription = description;
            }

            public string GetJobDescription()
            {
                return jobDescription;
            }

            public void InputData()
            {
                Console.WriteLine("Full name:");
                fullName = Console.ReadLine();

                Console.WriteLine("Date of birth (DD.MM.YYYY format):");
                string dobString = Console.ReadLine();
                dateOfBirth = DateTime.ParseExact(dobString, "dd.MM.yyyy", null);

                Console.WriteLine("Telephone number:");
                contactPhone = Console.ReadLine();

                Console.WriteLine("Email:");
                workEmail = Console.ReadLine();

                Console.WriteLine("Position:");
                position = Console.ReadLine();

                Console.WriteLine("Describe the job:");
                jobDescription = Console.ReadLine();
            }

            public void OutputData()
            {
                Console.WriteLine("FN: " + fullName);
                Console.WriteLine("DOB: " + dateOfBirth.ToString("dd.MM.yyyy"));
                Console.WriteLine("Phone: " + contactPhone);
                Console.WriteLine("Email: " + workEmail);
                Console.WriteLine("Position: " + position);
                Console.WriteLine("Job Description: " + jobDescription);
            }
        }

        public static bool IsFibonacciNumber(int number)
        {
            if (number == 0 || number == 1)
            {
                return true;
            }

            int previous = 0;
            int current = 1;

            while (current < number)
            {
                int next = previous + current;
                previous = current;
                current = next;

                if (current == number)
                {
                    return true;
                }
            }

            return false;
        }
        public class City
        {
            private string cityName;
            private string countryName;
            private string[] districts;

            public void SetCityName(string name)
            {
                cityName = name;
            }

            public string GetCityName()
            {
                return cityName;
            }

            public void SetCountryName(string name)
            {
                countryName = name;
            }

            public string GetCountryName()
            {
                return countryName;
            }

            public void SetDistricts(string[] districts)
            {
                this.districts = districts;
            }

            public string[] GetDistricts()
            {
                return districts;
            }

            public void InputData()
            {
                Console.WriteLine("Type city name:");
                cityName = Console.ReadLine();

                Console.WriteLine("Type country name:");
                countryName = Console.ReadLine();

                Console.WriteLine("Write districts names (use commas to devide them):");
                string districtsString = Console.ReadLine();
                districts = districtsString.Split(',');
            }

            public void OutputData()
            {
                Console.WriteLine("City name: " + cityName);
                Console.WriteLine("Country name: " + countryName);
                Console.WriteLine("Districts name: " + string.Join(", ", districts));
            }
        }
        public class Sorting
        {
            public static void BubbleSort(int[] array, bool ascending)
            {
                int length = array.Length;

                for (int i = 0; i < length - 1; i++)
                {
                    for (int j = 0; j < length - i - 1; j++)
                    {
                        if (ascending)
                        {
                            if (array[j] > array[j + 1])
                            {
                                int temp = array[j];
                                array[j] = array[j + 1];
                                array[j + 1] = temp;
                            }
                        }
                        else
                        {
                            if (array[j] < array[j + 1])
                            {
                                int temp = array[j];
                                array[j] = array[j + 1];
                                array[j + 1] = temp;
                            }
                        }
                    }
                }
            }
        }
    }
}