using System;


// 4. Inheritance
// Interview Concepts:
// - Inheritance: Child class acquires properties and methods of parent class
// - Promotes code reuse and hierarchical classification
// - Syntax: class Child : Parent
// - Child can access public/protected members of parent

class Person // Parent (base) class
{
    public void Speak() => Console.WriteLine("Person speaking");
}
class Student : Person // Child (derived) class
{
    public void Study() => Console.WriteLine("Student studying");
}

class Program
{
    static void Main()
    {
        Student s = new Student();
        s.Speak(); // Inherited method
        s.Study();
    }
}