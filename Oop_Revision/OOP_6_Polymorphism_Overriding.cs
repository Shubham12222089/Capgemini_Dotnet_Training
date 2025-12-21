using System;


// 6. Polymorphism (Overriding)
// Interview Concepts:
// - Method Overriding: Child class redefines parent class method
// - Use virtual (parent) and override (child) keywords
// - Runtime polymorphism (resolved at runtime)
// - Base class reference can point to derived class object
// - Method binding: Decided at runtime (dynamic binding)

class Animal
{
    public virtual void Sound() => Console.WriteLine("Animal sound"); // Virtual method
}
class Dog : Animal
{
    public override void Sound() => Console.WriteLine("Dog barks"); // Overridden method
}

class Program
{
    static void Main()
    {
        Animal a = new Dog(); // Base reference, derived object
        a.Sound(); // Calls Dog's Sound (runtime polymorphism)
    }
}