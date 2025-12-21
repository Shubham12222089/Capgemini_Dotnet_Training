using System;


// 11. Exception Handling
// Interview Concepts:
// - Exception: Runtime error that disrupts program flow
// - try-catch-finally: Used for error handling
// - catch: Handles the exception
// - finally: Always executes (cleanup code)
// - Business logic: Code that may throw exception (division)

class Program
{
    static void Main()
    {
        try
        {
            int a = 10, b = 0;
            int c = a / b; // Business logic (may throw exception)
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message); // Error message (presentation logic)
        }
        finally
        {
            Console.WriteLine("Always executes"); // Cleanup or final message
        }
    }
}