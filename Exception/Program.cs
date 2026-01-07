using System;
class Program
{
//   public static void Main()
//   {
//     int num1=0;
//     int num2=0;

//     int result=0;
//     int[] arr = new int[6]{1,2,3,4,5,6};

//     try{
//         Console.WriteLine("enter the first number");
//         num1=Convert.ToInt32(Console.ReadLine());

//         Console.WriteLine("enter the second number");
//         num2=Convert.ToInt32(Console.ReadLine());
//     }
//     catch (FormatException)
//     {
//         Console.WriteLine("Error: Please enter a valid number.");
//     }
//     try{
//       result=num1/num2;
//       for(int i = 0; i < 9; i++)
//         {
//             Console.WriteLine(arr[i]);
//         }
//     }
//     catch(IndexOutOfRangeException ex)
//         {
//             Console.WriteLine($"Index is out of range {ex.Message}");
//         }
//     catch(DivideByZeroException ex)
//     {
//         Console.WriteLine($"Cannot Divivde number by zero {ex.Message.ToString()}");
//     }
    
//     finally{

//       Console.WriteLine($"output of the division of two numbers {num1} and {num2} is {result}");
//     }
//     Console.WriteLine($"output of the division of two numbers {num1} and {num2} is {result}");
//   }

    //-------------Custom or user-defined Exception------------------
    public static void Main(string[] args)
    {
        try
        {
            throw new MyException("Rajesh");
        }
        catch(Exception e)
        {
            Console.WriteLine($"Exception Caught here : {e.Message.ToString()}");
        }
        Console.WriteLine("Last Statement");
    }
}