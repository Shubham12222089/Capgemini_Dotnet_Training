using System;


// 2. Encapsulation
// Interview Concepts:
// - Encapsulation: Wrapping data (fields) and methods together
// - Data hiding: Use of private fields to restrict direct access
// - Access modifiers: private, public, protected, internal
// - Business logic: Methods that operate on data (Deposit, GetBalance)

class Account
{
    private double balance; // Data hiding (private field)
    public void Deposit(double amount) => balance += amount; // Business logic
    public double GetBalance() => balance; // Business logic
}

class Program
{
    static void Main()
    {
        Account acc = new Account();
        acc.Deposit(500);
        Console.WriteLine($"Balance: {acc.GetBalance()}"); // Presentation logic
    }
}