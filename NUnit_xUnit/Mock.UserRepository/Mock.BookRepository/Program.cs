namespace Mock.BookRepository
{
    public class BookRepository : IBookRepository
    {
        public IEnumerable<Book> FindAll()
        {
            return null;
        }
    }

    public interface IBookRepository
    {
        IEnumerable<Book> FindAll();
    }

    public class Book
    {
        public string Title
        { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}