namespace С__Pack
{
    public class Play : IDisposable
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }

        public Play(string title, string author, string genre, int year)
        {
            Title = title;
            Author = author;
            Genre = genre;
            Year = year;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Tittle: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Genre: {Genre}");
            Console.WriteLine($"Year: {Year}");
        }

        private void ReleaseManagedResources()
        {
     
        }

        private void ReleaseUnmanagedResources()
        {

        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                ReleaseManagedResources();
            }

            ReleaseUnmanagedResources();
        }

        // Деструктор
        ~Play()
        {
            Dispose(false);
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
            }
            static void Exercise1()
            {
                using (Play play1 = new Play("Gamlet", "Shekspir", "Crying", 1600))
                {
                    play1.DisplayInfo();
                }

                Play play2 = new Play("Romeo And Julieta", "Shekspir", "Crying", 1597);
                play2.DisplayInfo();
                play2.Dispose();
            }
            static void Exercise2()
            {

            }
        }
    }
}