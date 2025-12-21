using System;


// 7. Abstraction (Abstract Class)
// Interview Concepts:
// - Abstraction: Hiding implementation details, showing only essential features
// - Abstract class: Cannot be instantiated, can have abstract and non-abstract members
// - Abstract method: No body, must be overridden in derived class
// - Partial implementation: Some methods can be implemented, some left abstract

abstract class Shape // Abstract class (cannot create object)
{
    public abstract void Draw(); // Abstract method (no body)
}
class Circle : Shape
{
    public override void Draw() => Console.WriteLine("Drawing Circle"); // Implementation of abstract method
}

class Program
{
    static void Main()
    {
        Shape s = new Circle(); // Reference of abstract class, object of derived
        s.Draw();
    }
}