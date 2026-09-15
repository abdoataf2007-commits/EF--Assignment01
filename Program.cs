using ReadMoreBooks.Data;

namespace ReadMoreBooks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using BookStoreContext context = new BookStoreContext();

            context.Database.EnsureCreated();

            Console.WriteLine("Database created successfully!");

            Console.ReadKey();
        }
    }
}