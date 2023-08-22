namespace GarbageCollection
{
    public class Play : IDisposable
    {
        private bool disposed = false;

        public string Title { get; set; }
        public string AuthorsFullName { get; set; }
        public string Genre { get; set; }
        public uint ReleaseYear { get; set; }

        public Play(string title, string authorsFullName, string genre, uint releaseYear)
        {
            Title = title;
            AuthorsFullName = authorsFullName;
            Genre = genre;
            ReleaseYear = releaseYear;
        }
        //Task 1. .NET 5 (including .NET Core) and later versions don't call finalizers as part of application termination.
        //~Play()
        //{
        //    Console.WriteLine($"{AuthorsFullName}'s play \"{Title}\", written in {ReleaseYear}, was removed!");
        //}

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);

            Console.WriteLine($"{AuthorsFullName}'s play \"{Title}\", written in {ReleaseYear}, was removed!");
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed) return;

            //if (disposing) { }

            disposed = true;
        }

        ~Play()
        {
            Dispose(false);
        }
    }
}
