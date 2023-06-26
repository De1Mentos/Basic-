using static С__Pack.Program.Website;

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
                int sideLength = 5;
                char symbol = '*';

                DisplaySquare(sideLength, symbol);
            }
            static void Exercise2()
            {
                int number = 1221;

                bool isPalindrome = IsPalindrome(number);
                Console.WriteLine(isPalindrome);
            }
            static void Exercise3()
            {
                int[] originalArray = { 1, 2, 6, -1, 88, 7, 6 };
                int[] filterArray = { 6, 88, 7 };

                int[] filteredArray = FilterArray(originalArray, filterArray);
                Console.WriteLine(string.Join(" ", filteredArray));
            }
            static void Exercise4()
            {
                Website website = new Website();
                website.InputData();
                Console.WriteLine();
                website.DisplayData();
            }
            static void Exercise5()
            {
                Journal journal = new Journal();
                journal.InputData();
                Console.WriteLine();
                journal.DisplayData();
            }
            static void Exercise6()
            {

            }
            static void Exercise7()
            {
            }

        }
        public static void DisplaySquare(int sideLength, char symbol)
        {
            for (int i = 0; i < sideLength; i++)
            {
                for (int j = 0; j < sideLength; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
        }
        public static bool IsPalindrome(int number)
        {
            int originalNumber = number;
            int reversedNumber = 0;

            while (number > 0)
            {
                int remainder = number % 10;
                reversedNumber = reversedNumber * 10 + remainder;
                number /= 10;
            }

            return originalNumber == reversedNumber;
        }
        public static int[] FilterArray(int[] originalArray, int[] filterArray)
        {
            return originalArray.Except(filterArray).ToArray();
        }
        public class Website
        {
            private string siteName;
            private string sitePath;
            private string siteDescription;
            private string ipAddress;

            public void SetSiteName(string name)
            {
                siteName = name;
            }

            public string GetSiteName()
            {
                return siteName;
            }

            public void SetSitePath(string path)
            {
                sitePath = path;
            }

            public string GetSitePath()
            {
                return sitePath;
            }

            public void SetSiteDescription(string description)
            {
                siteDescription = description;
            }

            public string GetSiteDescription()
            {
                return siteDescription;
            }

            public void SetIPAddress(string ip)
            {
                ipAddress = ip;
            }

            public string GetIPAddress()
            {
                return ipAddress;
            }

            public void InputData()
            {
                Console.Write("Enter the website name: ");
                siteName = Console.ReadLine();

                Console.Write("Enter the website path: ");
                sitePath = Console.ReadLine();

                Console.Write("Enter the website description: ");
                siteDescription = Console.ReadLine();

                Console.Write("Enter the website IP address: ");
                ipAddress = Console.ReadLine();
            }
            public class Journal
            {
                private string journalName;
                private int foundationYear;
                private string journalDescription;
                private string contactPhone;
                private string email;

                public void SetJournalName(string name)
                {
                    journalName = name;
                }

                public string GetJournalName()
                {
                    return journalName;
                }

                public void SetFoundationYear(int year)
                {
                    foundationYear = year;
                }

                public int GetFoundationYear()
                {
                    return foundationYear;
                }

                public void SetJournalDescription(string description)
                {
                    journalDescription = description;
                }

                public string GetJournalDescription()
                {
                    return journalDescription;
                }

                public void SetContactPhone(string phone)
                {
                    contactPhone = phone;
                }

                public string GetContactPhone()
                {
                    return contactPhone;
                }

                public void SetEmail(string email)
                {
                    this.email = email;
                }

                public string GetEmail()
                {
                    return email;
                }

                public void InputData()
                {
                    Console.Write("Enter the journal name: ");
                    journalName = Console.ReadLine();

                    Console.Write("Enter the foundation year: ");
                    foundationYear = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter the journal description: ");
                    journalDescription = Console.ReadLine();

                    Console.Write("Enter the contact phone: ");
                    contactPhone = Console.ReadLine();

                    Console.Write("Enter the email: ");
                    email = Console.ReadLine();
                }

                public void DisplayData()
                {
                    Console.WriteLine("Journal Name: " + journalName);
                    Console.WriteLine("Foundation Year: " + foundationYear);
                    Console.WriteLine("Journal Description: " + journalDescription);
                    Console.WriteLine("Contact Phone: " + contactPhone);
                    Console.WriteLine("Email: " + email);
                }
            }
            public void DisplayData()
            {
                Console.WriteLine("Website Name: " + siteName);
                Console.WriteLine("Website Path: " + sitePath);
                Console.WriteLine("Website Description: " + siteDescription);
                Console.WriteLine("Website IP Address: " + ipAddress);
            }
        }
    }
}