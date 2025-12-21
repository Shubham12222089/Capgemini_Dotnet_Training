using System;
//using switch cases
namespace MyConsoleApp
{
    class Calculator
    {
        // Parameterized constructor to initialize values
        private int num1;
        private int num2;

        public Calculator(int number1, int number2)
        {
            num1 = number1;
            num2 = number2;
        }

        public int Add()
        {
            return num1 + num2;
        }

        public int Subtract()
        {
            return num1 - num2;
        }

        public int Multiply()
        {
            return num1 * num2;
        }

        public double Divide()
        {
            if (num2 == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            return (double)num1 / num2;
        }
    }
}