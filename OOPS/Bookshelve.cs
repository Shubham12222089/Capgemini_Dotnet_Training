using System;

public class Bookshelve : Furniture
{
    public override void Accept()
    {
        Console.WriteLine($"Enter the number of Bookshelve:");
        num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Enter the color of Bookshelve:");
        color = Console.ReadLine() ?? string.Empty;
        Console.WriteLine($"Enter the width of Bookshelve:");
        width = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Enter the height of Bookshelve:");
        height = Convert.ToInt32(Console.ReadLine());
    }

    public override void Display()
    {
        Console.WriteLine($"Number of Bookshelves: {num}");
        Console.WriteLine($"Color of Bookshelves: {color}");
        Console.WriteLine($"Width of Bookshelves: {width}");
        Console.WriteLine($"Height of Bookshelves: {height}");
    }
}