namespace С__Pack
{
    class BookList
    {
        private List<string> books;

        public int Count => books.Count;

        public BookList()
        {
            books = new List<string>();
        }

        public string this[int index]
        {
            get { return books[index]; }
            set { books[index] = value; }
        }

        public void AddBook(string book)
        {
            books.Add(book);
        }

        public void RemoveBook(string book)
        {
            books.Remove(book);
        }

        public bool ContainsBook(string book)
        {
            return books.Contains(book);
        }

        public static BookList operator +(BookList bookList, string book)
        {
            bookList.AddBook(book);
            return bookList;
        }

        public static BookList operator -(BookList bookList, string book)
        {
            bookList.RemoveBook(book);
            return bookList;
        }

        public static bool operator ==(BookList bookList, string book)
        {
            return bookList.ContainsBook(book);
        }

        public static bool operator !=(BookList bookList, string book)
        {
            return !(bookList == book);
        }

        public override bool Equals(object obj)
        {
            if (obj is BookList otherBookList)
            {
                if (Count != otherBookList.Count)
                    return false;

                for (int i = 0; i < Count; i++)
                {
                    if (this[i] != otherBookList[i])
                        return false;
                }

                return true;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return books.GetHashCode();
        }
    }

    class Matrix
    {
        private int[,] data;

        public int Rows { get; }
        public int Columns { get; }

        public Matrix(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
            data = new int[rows, columns];
        }

        public int this[int row, int column]
        {
            get { return data[row, column]; }
            set { data[row, column] = value; }
        }

        public static Matrix operator +(Matrix matrix1, Matrix matrix2)
        {
            if (matrix1.Rows != matrix2.Rows || matrix1.Columns != matrix2.Columns)
                throw new ArgumentException("Matrix dimensions must be the same.");

            int rows = matrix1.Rows;
            int columns = matrix1.Columns;
            Matrix result = new Matrix(rows, columns);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    result[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }

            return result;
        }

        public static Matrix operator -(Matrix matrix1, Matrix matrix2)
        {
            if (matrix1.Rows != matrix2.Rows || matrix1.Columns != matrix2.Columns)
                throw new ArgumentException("Matrix dimensions must be the same.");

            int rows = matrix1.Rows;
            int columns = matrix1.Columns;
            Matrix result = new Matrix(rows, columns);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    result[i, j] = matrix1[i, j] - matrix2[i, j];
                }
            }

            return result;
        }

        public static Matrix operator *(Matrix matrix1, Matrix matrix2)
        {
            if (matrix1.Columns != matrix2.Rows)
                throw new ArgumentException("Number of columns in the first matrix must match the number of rows in the second matrix.");

            int rows = matrix1.Rows;
            int columns = matrix2.Columns;
            int common = matrix1.Columns;

            Matrix result = new Matrix(rows, columns);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    for (int k = 0; k < common; k++)
                    {
                        result[i, j] += matrix1[i, k] * matrix2[k, j];
                    }
                }
            }

            return result;
        }

        public static Matrix operator *(Matrix matrix, int scalar)
        {
            int rows = matrix.Rows;
            int columns = matrix.Columns;

            Matrix result = new Matrix(rows, columns);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    result[i, j] = matrix[i, j] * scalar;
                }
            }

            return result;
        }

        public static bool operator ==(Matrix matrix1, Matrix matrix2)
        {
            if (ReferenceEquals(matrix1, matrix2))
                return true;

            if (matrix1 is null || matrix2 is null)
                return false;

            if (matrix1.Rows != matrix2.Rows || matrix1.Columns != matrix2.Columns)
                return false;

            for (int i = 0; i < matrix1.Rows; i++)
            {
                for (int j = 0; j < matrix1.Columns; j++)
                {
                    if (matrix1[i, j] != matrix2[i, j])
                        return false;
                }
            }

            return true;
        }

        public static bool operator !=(Matrix matrix1, Matrix matrix2)
        {
            return !(matrix1 == matrix2);
        }

        public override bool Equals(object obj)
        {
            if (obj is Matrix matrix)
                return this == matrix;

            return false;
        }

        public override int GetHashCode()
        {
            return data.GetHashCode();
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
        }
        static void Exercise1()
        {
            Employee employee = new Employee();
            employee.InputData();
            Console.WriteLine("----------------------");
            employee.OutputData();

            Console.WriteLine("Enter the amount to increase the salary:");
            decimal increaseAmount = decimal.Parse(Console.ReadLine());
            employee.IncreaseSalary(increaseAmount);

            Console.WriteLine("Enter the amount to decrease the salary:");
            decimal decreaseAmount = decimal.Parse(Console.ReadLine());
            employee.DecreaseSalary(decreaseAmount);

            Console.WriteLine("----------------------");
            employee.OutputData();
        }
        static void Exercise2()
        {
            Matrix matrix1 = new Matrix(2, 2);
            matrix1[0, 0] = 1;
            matrix1[0, 1] = 2;
            matrix1[1, 0] = 3;
            matrix1[1, 1] = 4;

            Matrix matrix2 = new Matrix(2, 2);
            matrix2[0, 0] = 5;
            matrix2[0, 1] = 6;
            matrix2[1, 0] = 7;
            matrix2[1, 1] = 8;

            Matrix sum = matrix1 + matrix2;
            Matrix difference = matrix1 - matrix2;
            Matrix product = matrix1 * matrix2;
            Matrix scalarProduct = matrix1 * 2;

            Console.WriteLine("Matrix1:");
            PrintMatrix(matrix1);

            Console.WriteLine("Matrix2:");
            PrintMatrix(matrix2);

            Console.WriteLine("Sum:");
            PrintMatrix(sum);

            Console.WriteLine("Difference:");
            PrintMatrix(difference);

            Console.WriteLine("Product:");
            PrintMatrix(product);

            Console.WriteLine("Scalar Product:");
            PrintMatrix(scalarProduct);

            Console.WriteLine("Matrix1 == Matrix2: " + (matrix1 == matrix2));
            Console.WriteLine("Matrix1 != Matrix2: " + (matrix1 != matrix2));

            Console.ReadLine();
        }
        static void PrintMatrix(Matrix matrix)
        {
            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Columns; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }
        static void Exercise3()
        {

        }
        static void Exercise4()
        {
            BookList bookList = new BookList();
            bookList.AddBook("Book 1");
            bookList.AddBook("Book 2");
            bookList.AddBook("Book 3");

            Console.WriteLine("Book List:");
            PrintBookList(bookList);

            bookList = bookList + "Book 4";
            bookList = bookList + "Book 5";

            Console.WriteLine("Book List after adding books:");
            PrintBookList(bookList);

            bookList = bookList - "Book 2";

            Console.WriteLine("Book List after removing Book 2:");
            PrintBookList(bookList);

            Console.WriteLine("Does Book List contain Book 3? " + (bookList == "Book 3"));
            Console.WriteLine("Does Book List contain Book 6? " + (bookList == "Book 6"));

            Console.ReadLine();
        }
        static void PrintBookList(BookList bookList)
        {
            for (int i = 0; i < bookList.Count; i++)
            {
                Console.WriteLine(bookList[i]);
            }

            Console.WriteLine();
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