using System;


// 12. Properties
// Interview Concepts:
// - Properties: Special members to read, write, or compute values of private fields
// - Auto-implemented properties: No explicit backing field needed
// - Encapsulation: Properties provide controlled access to fields
// - get/set: Accessors for reading/writing

class Product
{
    public int Id { get; set; } // Auto-implemented property
    public string Name { get; set; } // Auto-implemented property
}

class Program
{
    static void Main()
    {
        Product p = new Product { Id = 1, Name = "Pen" }; // Object initializer
        Console.WriteLine($"Id: {p.Id}, Name: {p.Name}"); // Presentation logic
    }
}