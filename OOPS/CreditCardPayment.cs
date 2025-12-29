using System;

class CreditCardPayment : IPayment
{
    public void Pay(double amount)
    {
        Console.WriteLine($"Paid : {amount} using Credit Card");
    }
    public void Refund(double amount)
    {
        Console.WriteLine($"Refunded {amount} using Credit Card");
    }
}

internal interface IPayment
{
    public void Pay(double amount);
    public void Refund(double amount);
}
