using System;


// 8. Interface
// Interview Concepts:
// - Interface provides 100% abstraction (no implementation in interface itself)
// - Supports multiple inheritance (a class can implement multiple interfaces)
// - No fields or constructors allowed in interfaces
// - Used for defining contracts (what should be done, not how)
// - Business logic is implemented in the class, not in the interface

interface IPayment // Contract: All payment types must implement Pay()
{
    void Pay(); // Abstract method (no body)
}

class UpiPayment : IPayment
{
    // Business logic for UPI payment
    public void Pay() => Console.WriteLine("Payment via UPI");
}

class Program
{
    static void Main()
    {
        // Presentation logic: User interacts with the payment system
        IPayment payment = new UpiPayment();
        payment.Pay();
    }
}