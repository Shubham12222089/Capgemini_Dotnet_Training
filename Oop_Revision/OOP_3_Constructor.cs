using System;


// 3. Constructor
// Interview Concepts:
// - Constructor: Special method called when object is created
// - Used for initialization of fields
// - Types: Default, Parameterized, Copy, Static
// - No return type (not even void)

class Employee
{
    public int Id;
    public string Name;
    // Parameterized constructor (initializes fields)
    public Employee(int id, string name) { Id = id; Name = name; }
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