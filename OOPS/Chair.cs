using System;
public class Chair: Furniture
{
    public override void Accept()
    {
        Console.WriteLine($"Enter the number of Chairs:");
        num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Enter the color of Chairs:");
        color = Console.ReadLine() ?? string.Empty;
        Console.WriteLine($"Enter the width of Chairs:");
        width = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Enter the height of Chairs:");
        height = Convert.ToInt32(Console.ReadLine());
    }

    public override void Display()
    {
        Console.WriteLine($"Number of Chairs: {num}");
        Console.WriteLine($"Color of Chairs: {color}");
        Console.WriteLine($"Width of Chairs: {width}");
        Console.WriteLine($"Height of Chairs: {height}");
    }
}