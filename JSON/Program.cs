using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

public class Book
{
    [JsonIgnore]
    public int PublishingHouseId { get; set; }

    [JsonPropertyName("Title")]
    public required string Name { get; set; }

    public required PublishingHouse PublishingHouse { get; set; }
}

public class PublishingHouse
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string Adress { get; set; }
}

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        string exePath = AppDomain.CurrentDomain.BaseDirectory;
        string jsonFilePath = Path.Combine(exePath, "json.json");

        string json = File.ReadAllText(jsonFilePath, Encoding.UTF8);
        List <Book> books = JsonSerializer.Deserialize<List<Book>>(json);

        foreach (var book in books)
        {
            Console.WriteLine($"Назва: {book.Name}, Видавництво: {book.PublishingHouse.Name}");
        }
    }
}