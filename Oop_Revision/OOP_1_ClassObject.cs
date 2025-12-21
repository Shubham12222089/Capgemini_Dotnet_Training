using System;


// 1. Class & Object
// Interview Concepts:
// - Class: Blueprint for creating objects (defines properties and methods)
// - Object: Real instance of a class (occupies memory)
// - Presentation logic: Displaying output to user

class Student
{
    public int Id; // Field (data member)
    public string Name; // Field
    public void Display() => Console.WriteLine($"Id: {Id}, Name: {Name}"); // Presentation logic
}

class Program
{
    static void Main()
    {
        // Creating object (instance) of Student
        Student s1 = new Student();
        s1.Id = 101;
        s1.Name = "Amit";
        s1.Display();
    }
}