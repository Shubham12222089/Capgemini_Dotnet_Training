using System;

//A custom exception is a user-defined exception used to handle application-specific errors by extending the Exception class.
class MyException : Exception
{
    public MyException(string message) : base(message)
    {
        Console.WriteLine("User Defined Exception");
    }
}
