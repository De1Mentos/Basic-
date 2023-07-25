namespace С__Pack
{
    using System.Collections.Generic;
    internal class Program
    {
        public class Show : IDisposable
        {
            public string Title { get; set; }
            public string Theater { get; set; }
            public string Genre { get; set; }
            public int Duration { get; set; }
            public List<string> Actors { get; set; }


            public Show(string title, string theater, string genre, int duration, List<string> actors)
            {
                Title = title;
                Theater = theater;
                Genre = genre;
                Duration = duration;
                Actors = actors;
            }


            public void DisplayInfo()
            {
                Console.WriteLine($"Title: {Title}");
                Console.WriteLine($"Theatre: {Theater}");
                Console.WriteLine($"Genre: {Genre}");
                Console.WriteLine($"Duration: {Duration} m");
                Console.WriteLine("Actors:");
                foreach (var actor in Actors)
                {
                    Console.WriteLine($" - {actor}");
                }
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

            ~Show()
            {
                Dispose(false);
            }
        }
        public class Film : IDisposable
        {
            public string Title { get; set; }
            public string Studio { get; set; }
            public string Genre { get; set; }
            public int Duration { get; set; }
            public int Year { get; set; }

            public Film(string title, string studio, string genre, int duration, int year)
            {
                Title = title;
                Studio = studio;
                Genre = genre;
                Duration = duration;
                Year = year;
            }

            public void DisplayInfo()
            {
                Console.WriteLine($"Film: {Title}");
                Console.WriteLine($"Studio: {Studio}");
                Console.WriteLine($"Genre: {Genre}");
                Console.WriteLine($"Duration: {Duration} хв");
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

            ~Film()
            {
                Dispose(false);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Choose an exercise (1-2):");
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
                    using (Film film1 = new Film("Inception of life", "Warner Bros.", "Sci-Fi", 148, 1984))
                    {
                        film1.DisplayInfo();
                    }

                    Film film2 = new Film("The smelly and bad", "Paramount Pictures", "Crime/Drama", 175, 1972);
                    film2.DisplayInfo();
                    film2.Dispose();
            }
            static void Exercise2()
            {
                var actors2 = new List<string> { "Joe", "Donald" };
                Show show2 = new Show("Romeo and Juliet", "Shakespeare Theatre", "Tragedy", 150, actors2);
                show2.DisplayInfo();
                show2.Dispose();
            }
        }
    }
}