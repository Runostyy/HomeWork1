using System;

class Program
{
    static void Main(string[] args)
    {
        // Створюємо об'єкт класу Journal
        Journal myJournal = new Journal("Science Weekly", "Journal", 9.99);
        Console.WriteLine($"Name: {myJournal.Name}");
        Console.WriteLine($"Type: {myJournal.Type}");
        Console.WriteLine($"Price: ${myJournal.Get_Price()}");
        Console.WriteLine(myJournal.About_Company());

        Console.WriteLine();

        // Створюємо об'єкт класу Book
        Book myBook = new Book("The Great Gatsby", "Book", 15.99);
        Console.WriteLine($"Name: {myBook.Name}");
        Console.WriteLine($"Type: {myBook.Type}");
        Console.WriteLine($"Price: ${myBook.Get_Price()}");
        Console.WriteLine(myBook.About_Company());
    }
}
