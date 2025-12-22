using System;


// 3. Constructor
// Interview Concepts:
// - Constructor: Special method called when object is created
// - Used for initialization of fields
// - Types: Default, Parameterized, Copy, Static
// - No return type (not even void)

//types of constructors in C# , dotnet:
// 1. Default Constructor: No parameters, initializes fields with default values
// 2. Parameterized Constructor: Takes parameters to initialize fields with specific values
// 3. Copy Constructor: Initializes a new object as a copy of an existing object


class Employee
{
    public int Id;
    public string Name;
    // Parameterized constructor (initializes fields)
    public Employee(int id, string name) { Id = id; Name = name; }
    // Default constructor (no parameters)
    public Employee() { Id = 0; Name = "Unknown"; }
}

class Program
{
    static void Main()
    {
        // Object creation with parameterized constructor
        Employee emp = new Employee(1, "Rahul");
        Console.WriteLine($"Id: {emp.Id}, Name: {emp.Name}"); // Presentation logic
    }
}