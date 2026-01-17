using System;
using System.Text.RegularExpressions;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("---------------------Task1--------------------");
        // string headerRegex =
        //     @"^\[(INFO|WARN|ERROR|DEBUG|CRITICAL)\] \d{4}-(0[1-9]|1[0-2])-(0[1-9]|[12]\d|3[01])T([01]\d|2[0-3]):[0-5]\d:[0-5]\dZ";

        // string log = Console.ReadLine();
        // Console.WriteLine("Header Valid: " + Regex.IsMatch(log, headerRegex));

        // Console.WriteLine("---------------------Task2--------------------");
        // Console.WriteLine("Enter string for task2 : ");
        // string NameUserID = Console.ReadLine();
        // var userId = Regex.Match(NameUserID, @"USR_(\d{4}");
        // var service = Regex.Match(NameUserID, @"service=(?<service>[a-z]+)");
        // Console.WriteLine($"Service: {service.Groups["service"]}, UserID: {userId}");

        // Console.WriteLine("---------------------Task3--------------------");
        // Console.WriteLine("Enter log for Task 3:");
        // string input2 = Console.ReadLine();

        // var weakPassword = Regex.Match(
        //     input2,
        //     @"password[a-z0-9]*"
        // );

        // if (weakPassword.Success)
        //     Console.WriteLine("Weak Password Found: " + weakPassword.Value);
        // else
        //     Console.WriteLine("No weak password found");

        Console.WriteLine("---------------------Task4--------------------");
        Console.WriteLine("Enter log for Task 4:");
        string input4 = Console.ReadLine();

        var txnId = Regex.Match(input4, @"TXN\d+");
        var amount = Regex.Match(input4, @"(₹[\d,]+|\$\d+(\.\d+)?)");

        Console.WriteLine($"txnId: {txnId.Value}");
        Console.WriteLine($"amount: {amount.Value}");
        // Console.WriteLine("---------------------Task5--------------------");
        // Console.WriteLine("Enter log for Task 5:");
        // string input = Console.ReadLine();

        // var secret = Regex.Match(
        //     input,
        //     @"(?i)\bpassword\b(?!=\*+|=#+|=X+)\s*=?\s*[a-z0-9]+"
        // );

        // if (secret.Success)
        //     Console.WriteLine("Unmasked Secret: " + secret.Value);
        // else
        //     Console.WriteLine("Masked or no secret");

    }
}