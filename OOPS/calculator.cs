using System;

public class Calculator
{
    private int number1;
    private int number2;
    private int result;

    // Properties
    public int Number1
    {
        get { return number1; }
        set { number1 = value; }
    }

    public int Number2
    {
        get { return number2; }
        set { number2 = value; }
    }

    public int Result
    {
        get { return result; }
    }

    // Default Constructor
    public Calculator()
    {
        number1 = 0;
        number2 = 0;
        result = 0;
    }

    // Parameterized Constructor
    public Calculator(int number1, int number2)
    {
        this.number1 = number1;
        this.number2 = number2;
    }

    //copy constructor
    

    //static Constructor
    static Calculator()
    {
        Console.WriteLine("Static Constructor called. Calculator class is being used.");
    }

    // Method with parameters and return type
    public int Add(int number1, int number2)
    {
        result = number1 + number2;
        return result;
    }

    // Method without parameters but with return type
    public int Subtract()
    {
        result = number1 - number2;
        return result;
    }

    // Method with parameters and without return type
    public void Multiply(int number1, int number2)
    {
        result = number1 * number2;
        Console.WriteLine($"Multiplication of {number1} and {number2} is : {result}");
    }

    // Method without parameters and without return type
    public void Divide()
    {
        if (number2 != 0)
        {
            result = number1 / number2;
            Console.WriteLine($"Division of {number1} and {number2} is : {result}");
        }
        else
        {
            Console.WriteLine("Error: Division by zero");
        }
    }

    public void swapNumbers(ref int number1, ref int number2)
    {
        int temp = number1;
        number1 = number2;
        number2 = temp;
    }
    // example of in - out parameters
    //how it is working
    // in parameter is used to pass value to the method
    // out parameter is used to return multiple values from the method
    public void CalculateSquareAndCube(int number, out int b, out int square, out int cube)
    {
        square = number * number;
        b=6;
        cube = b * b * b;
    }
}
