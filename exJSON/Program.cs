using System.Text.Json;
class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;
        string booksJson = File.ReadAllText("bookslist.json");
        List<Book> books = JsonSerializer.Deserialize<List<Book>>(booksJson);

        for (int i = 0; i < books.Count; i++)
        {
            books[i].DisplayInfo();
            Console.WriteLine();
            Console.WriteLine();
        }
    }

}
class Book
{
    public string Title { get; set; }
    public PublishingHouse PublishingHouse { get; set; }

    public void DisplayInfo()
    {
        Console.WriteLine("------ Інформація про книгу ------");
        Console.WriteLine($"Назва: {Title}");
        Console.WriteLine();
        PublishingHouse.DisplayInfo();
    }
}
class PublishingHouse
{
    private static int Id;
    public readonly int id;
    public string Name { get; set; }
    public string Address { get; set; }

    public PublishingHouse()
    {
        id = Id++;
    }
    public void DisplayInfo()
    {
        Console.WriteLine("--- Інформація про видавництво ---");
        Console.WriteLine($"Id: {id}");
        Console.WriteLine($"Назва: {Name}");
        Console.WriteLine($"Адреса: {Address}");
        Console.WriteLine("----------------------------------");
    }
}
