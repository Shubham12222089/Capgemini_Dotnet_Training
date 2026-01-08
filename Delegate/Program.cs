using System;

//We use delegates to pass methods as parameters, call methods dynamically, 
//and achieve loose coupling between components.

// class Program //Subscriber
// {
//     public static void Main(string[] args)
//     {
//         AddTwoNumbers a = new AddTwoNumbers();
//         a.ev_OddNumber += new AddTwoNumbers.dg_OddNumber(EventMessage);
//         a.Add();
//     }

//     static void EventMessage()
//     {
//         Console.WriteLine("********Event Executed: This is Odd Number *********");
//     }

// }
class Program
{
    private static int AddNumbers(int param1, int param2)
    {
        return param1 + param2;
    }

    //Predicate target method
    private static bool IsApple(string value)
    {
        return value.ToLower().Contains("iphone");
    }

    public static void Main(string[] args)
    {
        // Func example
        Func<int, int, int> AdditionFunc = AddNumbers;
        int sum = AdditionFunc(10, 20);
        Console.WriteLine($"Addition using Func: {sum}");

        // Predicate example
        Predicate<string> checkIfApple = IsApple;

        bool result = checkIfApple("I phone 6");

        if (result)
        {
            Console.WriteLine("It's an iPhone");
        }
        else
        {
            Console.WriteLine("Not an iPhone");
        }
    }
}