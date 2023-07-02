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
    class Shop
    {
        private double area;

        public double Area
        {
            get { return area; }
            set
            {
                if (value >= 0)
                    area = value;
                else
                    throw new ArgumentException("Area cannot be negative.");
            }
        }

        public Shop(double area)
        {
            Area = area;
        }

        public static Shop operator +(Shop shop, double increaseArea)
        {
            return new Shop(shop.Area + increaseArea);
        }

        public static Shop operator -(Shop shop, double decreaseArea)
        {
            double newArea = shop.Area - decreaseArea;
            return newArea >= 0 ? new Shop(newArea) : shop;
        }

        public static bool operator ==(Shop shop1, Shop shop2)
        {
            if (ReferenceEquals(shop1, shop2))
                return true;

            if (shop1 is null || shop2 is null)
                return false;

            return shop1.Area == shop2.Area;
        }

        public static bool operator !=(Shop shop1, Shop shop2)
        {
            return !(shop1 == shop2);
        }

        public static bool operator <(Shop shop1, Shop shop2)
        {
            if (shop1 is null || shop2 is null)
                throw new ArgumentNullException();

            return shop1.Area < shop2.Area;
        }

        public static bool operator >(Shop shop1, Shop shop2)
        {
            if (shop1 is null || shop2 is null)
                throw new ArgumentNullException();

            return shop1.Area > shop2.Area;
        }

        public override bool Equals(object obj)
        {
            if (obj is Shop otherShop)
                return this == otherShop;

            return false;
        }

        public override int GetHashCode()
        {
            return area.GetHashCode();
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
                        Console.WriteLine("SKIPPED");
                    }
                    static void Exercise2()
                    {
                        Shop shop1 = new Shop(100);
                        Shop shop2 = new Shop(200);
                        Shop shop3 = new Shop(100);

                        Console.WriteLine("Shop 1 Area: " + shop1.Area);
                        Console.WriteLine("Shop 2 Area: " + shop2.Area);
                        Console.WriteLine("Shop 3 Area: " + shop3.Area);

                        shop1 = shop1 + 50;
                        shop2 = shop2 - 80;

                        Console.WriteLine("After operations:");
                        Console.WriteLine("Shop 1 Area: " + shop1.Area);
                        Console.WriteLine("Shop 2 Area: " + shop2.Area);

                        Console.WriteLine("Shop 1 == Shop 3: " + (shop1 == shop3));
                        Console.WriteLine("Shop 1 != Shop 2: " + (shop1 != shop2));

                        Console.WriteLine("Shop 1 < Shop 2: " + (shop1 < shop2));
                        Console.WriteLine("Shop 2 > Shop 3: " + (shop2 > shop3));

                        Console.ReadLine();
                    }
                    static void Exercise3()
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
            }
        }
        }
    }