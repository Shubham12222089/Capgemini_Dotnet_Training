// using System;
// using System.Dynamic;
// public class Account
// {
//     public double Balance{get;set;}
//     public string AccountNumber{get;set;}
//     public void Deposit(double amount)
//     {
//         if (amount > 0)
//         {
//             Balance+=amount;
//             Console.WriteLine($"Updated Balance is : {Balance}");
//         }
//         else
//         {
//             throw new ArgumentException("Deposit Amount must be positive");
//         }
//     }
//     public void Withdraw(double amount)
//     {
//         if(amount>0 && amount <= Balance)
//         {
//             Balance-=amount;
//             Console.WriteLine($"Updated Balance is : {Balance}");

//         }
//         else if (amount > Balance)
//         {
//             throw new InvalidOperationException("Insufficient funds");
//         }
//         else
//         {
//             throw new ArgumentException("Withdrawal amount must be Positive");
//         }

//     }
// }
// class Program
// {
//     public static void Main(string[] args)
//     {
//         try{
//             Account account = new Account();
//             Console.WriteLine("1. Deposit\n2. Withdraw");
//             Console.Write("Enter the Choice: ");
//             int choice= Convert.ToInt32(Console.ReadLine());

//             switch (choice)
//             {
//                 case 1:
//                     Console.Write("Enter the Amount to deposit: ");
//                     double amount1 = Convert.ToDouble(Console.ReadLine());
//                     account.Deposit(amount1);
//                     break;
//                 case 2: 
//                     Console.Write("Enter the Amount to withdraw: ");
//                     double amount2 = Convert.ToDouble(Console.ReadLine());
//                     account.Withdraw(amount2);
//                     break;
//                 default : 
//                     Console.WriteLine("Invalid Choice");
//                     break;
//             }
//         }
//         catch (ArgumentException e)
//         {
//             Console.WriteLine($"Error: {e.Message}");
//         }
//         catch(InvalidOperationException e)
//         {
//             Console.WriteLine($"Error: {e.Message}");
//         }
//     }
// }

//--------GymStream Membership Validation System-------

// using System;
// public class InvalidTierException : Exception
// {
//     public InvalidTierException(string message):base(message){}
// }
// public class Membership
// {
//     public string Tier{get;set;}
//     public int DurationMonths{get;set;}
//     public double BasePricePerMonth{get;set;}

//     public bool ValidateEnrollment()
//     {
//         if (Tier != "Basic" || Tier != "Premium" || Tier != "Elite")
//         {
//             throw new InvalidTierException("Tier not recognized. Please choose an available membership plan.");
//         }
//         if (DurationMonths <= 0)
//         {
//             throw new Exception("Duration must be atleast one month.");
//         }
//         return true;
//     }
//     public double CalculateTotalBill()
//     {
//         double totalPrice = DurationMonths*BasePricePerMonth;
//         double discountPercentage=0;
//         switch (Tier)
//         {
//             case "Basic":
//                 discountPercentage=2;
//                 break;
//             case "Premium":
//                 discountPercentage=7;
//                 break;
//             case "Elite":
//                 discountPercentage=12;
//                 break;
//         }
//         double discountAmount = totalPrice*(discountPercentage/100);
//         return totalPrice-discountAmount;
//     }
// }
// class Program
// {
//     public static void Main(string[] args)
//     {
//         Membership member = new Membership();
//         try
//             {
//                 Console.WriteLine("--- GymStream Enrollment Portal ---");
                
//                 Console.WriteLine("Enter membership tier (Basic/Premium/Elite):");
//                 member.Tier = Console.ReadLine();

//                 Console.WriteLine("Enter duration in months:");
//                 member.DurationMonths = Convert.ToInt32(Console.ReadLine());

//                 Console.WriteLine("Enter base price per month:");
//                 member.BasePricePerMonth = Convert.ToDouble(Console.ReadLine());

//                 // Perform Validation
//                 if (member.ValidateEnrollment())
//                 {
//                     Console.WriteLine("\nEnrollment Successful!");
//                     double finalBill = member.CalculateTotalBill();
//                     Console.WriteLine($"Total amount after discount: {finalBill:F2}");
//                 }
//             }
//             // Catch Block 1: Custom Exception for Tiers
//             catch (InvalidTierException ex)
//             {
//                 Console.WriteLine($"\nError: {ex.Message}");
//             }
//             // Catch Block 2: General Exception for Duration or numeric errors
//             catch (Exception ex)
//             {
//                 Console.WriteLine($"\nError: {ex.Message}");
//             }

//             Console.WriteLine("\nPress any key to close...");
//             Console.ReadKey();
//         }

//     }

//--------Logistic Pro Shipment System--------------
using System;
public class Shipment
{
    public string ShipmentCode{get;set;}
    public string TransportMode{get;set;}
    public double Weight{get;set;}
    public int StorageDays{get;set;}
}
public class ShipmentDetails:Shipment
{
    public bool ValidateShipmentCode()
    {
        if (string.IsNullOrEmpty(ShipmentCode) || ShipmentCode.Length!=7)
        {
            return false;
        }
        if (!ShipmentCode.StartsWith("GC#"))
        {
            return false;
        }
        for(int i = 3; i < ShipmentCode.Length; i++)
        {
            if (!char.IsDigit(ShipmentCode[i]))
            {
                return false;
            }

        }
        return true;

    }   
    public double CalculateTotalCost()
    {
        double ratePerKg=0;
        switch (TransportMode)
        {
            case "Sea":
                ratePerKg=15.00;
                break;
            case "Air":
                ratePerKg=50.00;
                break;
            case "Land":
                ratePerKg = 25;
                break;
            
        }
        double TotalCost = (Weight*ratePerKg)+Math.Sqrt(StorageDays);
        return TotalCost;
    }
}
class Program
{
    public static void Main(string[] args)
    {
        ShipmentDetails shipment = new ShipmentDetails();
        Console.Write("Enter the ShipmentCode: ");
        shipment.ShipmentCode = Console.ReadLine();

        if (!shipment.ValidateShipmentCode())
        {
            Console.WriteLine($"Invalid shipment code");
        }
        Console.Write("Enter Transport Mode (Sea/Air/Land): ");
        shipment.TransportMode = Console.ReadLine();

        Console.Write("Enter Weight: ");
        shipment.Weight = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Storage Days: ");
        shipment.StorageDays = Convert.ToInt32(Console.ReadLine());

        // Calculation Phase
        double cost = shipment.CalculateTotalCost();

        Console.WriteLine($"The total shipping cost is {cost:F2}");
        
    }
}