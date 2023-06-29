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
            }
        }
        static void Exercise1()
        {
            Employee employee = new Employee();
            employee.InputData();
            Console.WriteLine("----------------------");
            employee.OutputData();
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
        public class Employee
        {
            private string fullName;
            private DateTime dateOfBirth;
            private string contactPhone;
            private string workEmail;
            private string position;
            private string jobDescription;
            private decimal salary;

            public string FullName
            {
                get { return fullName; }
                set { fullName = value; }
            }

            public DateTime DateOfBirth
            {
                get { return dateOfBirth; }
                set { dateOfBirth = value; }
            }

            public string ContactPhone
            {
                get { return contactPhone; }
                set { contactPhone = value; }
            }

            public string WorkEmail
            {
                get { return workEmail; }
                set { workEmail = value; }
            }

            public string Position
            {
                get { return position; }
                set { position = value; }
            }

            public string JobDescription
            {
                get { return jobDescription; }
                set { jobDescription = value; }
            }

            public decimal Salary
            {
                get { return salary; }
                set { salary = value; }
            }

            public void IncreaseSalary(decimal amount)
            {
                salary += amount;
            }

            public void DecreaseSalary(decimal amount)
            {
                salary -= amount;
            }

            public bool IsEqualSalary(Employee otherEmployee)
            {
                return salary == otherEmployee.Salary;
            }

            public bool IsGreaterSalary(Employee otherEmployee)
            {
                return salary > otherEmployee.Salary;
            }

            public bool IsLessSalary(Employee otherEmployee)
            {
                return salary < otherEmployee.Salary;
            }

            public override bool Equals(object obj)
            {
                if (obj == null || GetType() != obj.GetType())
                {
                    return false;
                }

                Employee otherEmployee = (Employee)obj;
                return salary == otherEmployee.Salary;
            }

            public override int GetHashCode()
            {
                return salary.GetHashCode();
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

                Console.WriteLine("Salary:");
                salary = decimal.Parse(Console.ReadLine());
            }

            public void OutputData()
            {
                Console.WriteLine("FN: " + fullName);
                Console.WriteLine("DOB: " + dateOfBirth.ToString("dd.MM.yyyy"));
                Console.WriteLine("Phone: " + contactPhone);
                Console.WriteLine("Email: " + workEmail);
                Console.WriteLine("Position: " + position);
                Console.WriteLine("Job Description: " + jobDescription);
                Console.WriteLine("Salary: " + salary);
            }
        }
    }
}