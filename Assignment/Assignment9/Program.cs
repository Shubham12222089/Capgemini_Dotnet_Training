using System;
using System.Diagnostics.Contracts;
using System.Linq.Expressions;

// public class InvalidPriceException:SystemException
// {
//     public InvalidPriceException() : base("Price must be greater than zero.")
//     {

//     }
//     public InvalidPriceException(string message) : base(message)
//     {

//     }

// }
// public class InvalidQuantityException:SystemException
// {
//     public InvalidQuantityException() : base("Quantity must be greater than zero.")
//     {

//     }
//     public InvalidQuantityException(string message) : base(message)
//     {

//     }

// }
// class Program
// {
//     public static void Main(string[] args)
//     {
//         try{
//             Console.Write("Enter the Price of the Product: ");
//             decimal price = Convert.ToDecimal(Console.ReadLine());
//             if (price <= 0)
//             {
//                 throw new InvalidPriceException();
//             }
//             Console.WriteLine("Enter the Quantity: ");
//             int quantity = Convert.ToInt32(Console.ReadLine());
//             if (quantity <= 0)
//             {
//                 throw new InvalidQuantityException();
//             }

//             decimal totalCost = price*quantity;
//             Console.WriteLine($"Total Cost is : {totalCost:F1}");
//         }
//         catch (InvalidPriceException e)
//         {
//             Console.WriteLine($"Error: {e.Message}");
//         }
//         catch(InvalidQuantityException e)
//         {
//             Console.WriteLine($"Error: {e.Message}");
//         }
//         catch (FormatException)
//         {
//             Console.WriteLine("Error: Please enter a valid number.");
//         }
//         catch (Exception e)
//         {
//             Console.WriteLine($"Error: {e.Message}");
//         }

//     }
// }

//-----------------------------------------------------

// class Program
// {
//     public static void Main(string[] args)
//     {
//         try
//         {
//             Console.Write("Enter the Number of Ticket: ");
//             int number = Convert.ToInt32(Console.ReadLine());
//             if (number <= 0)
//             {
//                 throw new ArgumentException("Number of Ticket must be greater than 0.");
//             }
//             Console.Write("Enter the Price Per Ticket: ");
//             decimal pricePerTicket = Convert.ToDecimal(Console.ReadLine());
//             if (pricePerTicket <= 0)
//             {
//                 throw new ArgumentException("Price per ticket must be greater than 0.");
//             }
//             decimal totalCost = number*pricePerTicket;
//             Console.WriteLine($"Total Cost is : {totalCost}");
//         }
//         catch (ArgumentException e)
//         {
//             Console.WriteLine($"Error: {e.Message}");
//         }
//         catch (FormatException e)
//         {
//             Console.WriteLine("Error: Please enter a valid Number.");
//         }
//         catch(Exception e)
//         {
//             Console.WriteLine($"Error: {e.Message}");
//         }
//     }
// }

//-----------------------------------------------------

class CricketMatch
{
    public int[] playerScores;
    public int currentIndex;
    public CricketMatch()
    {
        playerScores = new int[5];
        currentIndex = 0;
    }

    
    public void AddPlayerScore(int score)
    {
        if (score < 0 || score > 50)
        {
            throw new ArgumentException("Invalid score. Score must be between 0 and 50.");
        }

        if (currentIndex >= 5)
        {
            throw new InvalidOperationException("Cannot add more than 5 player scores.");
        }

        playerScores[currentIndex] = score;
        currentIndex++;
    }

    public int CalculateScore()
    {
        int total=0;
        foreach(int i in playerScores)
        {
            total+=i;
        }
        return total;
    }
}
class Program
{
    public static void Main(string[] args)
    {
        try{
            Console.Write("Enter the Score : ");
            string score = Console.ReadLine();
            CricketMatch cricketMatch = new CricketMatch();
            string[] scores = score.Split(' ');
            foreach (string s in scores)
            {
                int value = Convert.ToInt32(s);
                cricketMatch.AddPlayerScore(value);
            }

            Console.WriteLine($"Total score of the cricket team: {cricketMatch.CalculateScore()}");
            
        }
        catch(ArgumentException e)
        {
            Console.WriteLine($"Error: {e.Message}");
        }
        catch(InvalidOperationException e)
        {
            Console.WriteLine($"Error: {e.Message}");
        }
    }
    
}