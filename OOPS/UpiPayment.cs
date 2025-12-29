using System;

class UpiPayment : IPayment
{
    public void Pay(double amount)
    {
        Console.WriteLine($"Paid : {amount} using UPI");
    }
    public void Refund(double amount)
    {
        Console.WriteLine($"Refunded {amount} using UPI");
    }
}