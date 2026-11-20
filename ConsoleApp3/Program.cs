using System;

class Book
{
    string Title;
    int Pages;
}

class Program
{
    static void Main()
    {
        
        Book b = new Book();
        object obj = b;
        Console.WriteLine(obj);

        Console.WriteLine(b.ToString());
        Console.WriteLine(b.Equals(b));
        Console.WriteLine(b.GetHashCode());
        Console.WriteLine(b.GetType());

        int pages = 464;

         // Q05
        int pages2 = 300;
        double number = pages2;

        // Q06
        double price = 49.99;
        int price2 = (int)price;

        // Q07
        string pagesText = "464";
        int pages3 = Convert.ToInt32(pagesText);

        // Q08
        string yearText = "2023";
        int year = int.Parse(yearText);

        string badText = "abc";
        int number2;

        if (int.TryParse(badText, out number2))
        {
            Console.WriteLine(number2);
        }
        else
        {
            Console.WriteLine("Invalid number");
        }

        // Q09
        int pages4 = 464;
        string text = pages4.ToString();

        Console.WriteLine(text);
        Console.WriteLine(text.GetType());

        // Q10
        int copies = 100;
        object obj2 = copies;
        int newCopies = (int)obj2;

        Console.WriteLine(copies);
        Console.WriteLine(newCopies);
    }
}