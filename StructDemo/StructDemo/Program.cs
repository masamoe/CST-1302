


namespace StructDemo
{
    struct Book // struct is a value type
    {
        public string title;
        public string author;
        public string price;
        public int book_id;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Book book1;
            book1.title = "C# Programming";
            book1.author = "John Smith";
            book1.price = "$19.99";
            book1.book_id = 1;
            
            Console.WriteLine("Book 1 title: {0}", book1.title);
            Console.WriteLine("Book 1 author: {0}", book1.author);
            Console.WriteLine("Book 1 price: {0}", book1.price);
            Console.WriteLine("Book 1 id: {0}", book1.book_id);
            
            Console.ReadLine();
        }
}
