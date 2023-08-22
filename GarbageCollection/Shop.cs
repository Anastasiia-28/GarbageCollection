namespace GarbageCollection
{
    public class Shop : IDisposable
    {
        private bool disposed = false;

        public string Name { get; set; }
        public string Address { get; set; }
        public ShopType Type { get; set; }

        public Shop(string name, string address, ShopType type)
        {
            Name = name;
            Address = address;
            Type = type;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);

            Console.WriteLine($"{Type} shop \"{Name}\" has been disposed!");
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed) return;

            //if (disposing) { }

            disposed = true;
        }

        ~Shop()
        {
            Dispose(false);
        }

        //Task 2
        //public void Dispose()
        //{
        //    Console.WriteLine($"{Type} shop \"{Name}\" has been disposed!");
        //} 
    }

    public enum ShopType
    {
        None,
        Food,
        Clothing,
        Shoe,
        Household
    }
}
