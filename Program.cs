namespace С__Pack
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public int YearPublished { get; set; }

        public Book(string title, string author, string genre, int yearPublished)
        {
            Title = title;
            Author = author;
            Genre = genre;
            YearPublished = yearPublished;
        }
    }

    class BookManagement
    {
        private LinkedList<Book> books;

        public BookManagement()
        {
            books = new LinkedList<Book>();
        }

        public void AddBook(Book book)
        {
            books.AddLast(book);
        }

        public void RemoveBook(Book book)
        {
            books.Remove(book);
        }

        public void UpdateBook(Book book, string title, string author, string genre, int yearPublished)
        {
            book.Title = title;
            book.Author = author;
            book.Genre = genre;
            book.YearPublished = yearPublished;
        }

        public List<Book> SearchBooks(string searchTerm)
        {
            List<Book> results = new List<Book>();
            foreach (var book in books)
            {
                if (book.Title.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                    book.Author.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                    book.Genre.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                    book.YearPublished.ToString().Contains(searchTerm))
                {
                    results.Add(book);
                }
            }
            return results;
        }

        public void InsertAtStart(Book book)
        {
            books.AddFirst(book);
        }

        public void InsertAtEnd(Book book)
        {
            books.AddLast(book);
        }

        public void InsertAtPosition(Book book, int position)
        {
            if (position <= 0)
            {
                books.AddFirst(book);
            }
            else if (position >= books.Count)
            {
                books.AddLast(book);
            }
            else
            {
                var currentNode = books.First;
                for (int i = 0; i < position; i++)
                {
                    currentNode = currentNode.Next;
                }
                books.AddBefore(currentNode, book);
            }
        }

        public void RemoveFromStart()
        {
            if (books.Count > 0)
            {
                books.RemoveFirst();
            }
        }

        public void RemoveFromEnd()
        {
            if (books.Count > 0)
            {
                books.RemoveLast();
            }
        }

        public void RemoveFromPosition(int position)
        {
            if (position < 0 || position >= books.Count)
            {
                throw new ArgumentOutOfRangeException(nameof(position), "Invalid position");
            }
            var currentNode = books.First;
            for (int i = 0; i < position; i++)
            {
                currentNode = currentNode.Next;
            }
            books.Remove(currentNode);
        }
    }

    class Employee
    {
        public string FullName { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }
        public string Email { get; set; }

        public Employee(string fullName, string position, decimal salary, string email)
        {
            FullName = fullName;
            Position = position;
            Salary = salary;
            Email = email;
        }
    }

    class EmployeeManagement
    {
        private List<Employee> employees;

        public EmployeeManagement()
        {
            employees = new List<Employee>();
        }

        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        public void RemoveEmployee(Employee employee)
        {
            employees.Remove(employee);
        }

        public void UpdateEmployee(Employee employee, string fullName, string position, decimal salary, string email)
        {
            employee.FullName = fullName;
            employee.Position = position;
            employee.Salary = salary;
            employee.Email = email;
        }

        public List<Employee> SearchEmployees(string searchTerm)
        {
            return employees
                .Where(e =>
                    e.FullName.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                    e.Position.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                    e.Email.Contains(searchTerm, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        public List<Employee> SortEmployeesBySalary()
        {
            return employees.OrderBy(e => e.Salary).ToList();
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
                        EmployeeManagement employeeManagement = new EmployeeManagement();

                        employeeManagement.AddEmployee(new Employee("Joseph Stalin", "Secretar", 3500, "Stalin@example.com"));
                        employeeManagement.AddEmployee(new Employee("Lenin Kurlov", "Financial CEO", 4000, "Lenin@example.com"));
                        employeeManagement.AddEmployee(new Employee("Mao Dzedung", "Manager", 3200, "Mao@example.com"));

                        Employee employeeToUpdate = employeeManagement.SearchEmployees("Іван Петров").FirstOrDefault();
                        if (employeeToUpdate != null)
                        {
                            employeeManagement.UpdateEmployee(employeeToUpdate, "Joe Fanicov", "Manager of trade", 3800, "Joe.Fanicov@example.com");
                        }

                        List<Employee> searchResults = employeeManagement.SearchEmployees("Maria");
                        Console.WriteLine("RESULT OF SEARCH:");
                        foreach (Employee employee in searchResults)
                        {
                            Console.WriteLine($"{employee.FullName} - {employee.Position} - {employee.Email}");
                        }

                        List<Employee> sortedEmployees = employeeManagement.SortEmployeesBySalary();
                        Console.WriteLine("SORTED:");
                        foreach (Employee employee in sortedEmployees)
                        {
                            Console.WriteLine($"{employee.FullName} - {employee.Position} - {employee.Email} - {employee.Salary}");
                        }
                    }
                    static void Exercise2()
                    {
                        BookManagement bookManagement = new BookManagement();

                        bookManagement.AddBook(new Book("The Great Gatsby", "F. Scott Fitzgerald", "Classic", 1925));
                        bookManagement.AddBook(new Book("To Kill a Mockingbird", "Harper Lee", "Fiction", 1960));
                        bookManagement.AddBook(new Book("1984", "George Orwell", "Dystopian", 1949));

                        List<Book> searchResults = bookManagement.SearchBooks("Mockingbird");
                        Console.WriteLine("Search Results:");
                        foreach (var book in searchResults)
                        {
                            Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Genre: {book.Genre}, Year Published: {book.YearPublished}");
                        }

                        bookManagement.InsertAtStart(new Book("Zipi Zubi", "J.D", "Classic", 1951));

                        bookManagement.InsertAtEnd(new Book("1984", "George Orwell", "Political Allegory", 1945));

                        bookManagement.InsertAtPosition(new Book("Intermezzo", "Jane Austen", "Romance", 1813), 2);

                        bookManagement.RemoveFromStart();

                        bookManagement.RemoveFromEnd();

                        bookManagement.RemoveFromPosition(1);

                        Console.WriteLine("Remaining Books:");
                        foreach (var book in bookManagement.SearchBooks(""))
                        {
                            Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Genre: {book.Genre}, Year Published: {book.YearPublished}");
                        }
                    }
                    static void Exercise3()
                    {

                    }
            }
        }
    }
}