using System;


// 5. Polymorphism (Overloading)
// Interview Concepts:
// - Polymorphism: Many forms (same method name, different behavior)
// - Method Overloading: Same method name, different parameter list (type/number/order)
// - Compile-time polymorphism (resolved at compile time)
// - Business logic: Add method performs addition for different types

class Calculator
{
    public int Add(int a, int b) => a + b; // Overloaded method (int)
    public double Add(double a, double b) => a + b; // Overloaded method (double)
}

class Program
{
    static void Main()
    {
        Calculator calc = new Calculator();
        Console.WriteLine(calc.Add(2, 3)); // Calls int version
        Console.WriteLine(calc.Add(2.5, 3.5)); // Calls double version
    }
}