// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

// class Program
// {
//     public static void Main(string[] args)
//     {
//         // Employee emp=new Employee();
//         // emp.AcceptDetails();
//         // emp.DisplayDetails();
//         // emp.SalaryDetails();
//         // Console.ReadKey();
//         Student stu=new Student();
//         stu.AcceptDetails();
//         stu.ShowDetails();
//         Console.ReadKey();

//     }
// }


using System;

class Program
{
    public static void Main(string[] args)
    {
        // Using default constructor
        // Calculator cal = new Calculator();
        // cal.Number1 = 20;
        // cal.Number2 = 10;

        // // Using parameterized constructor
        // Calculator calc = new Calculator(cal.Number1, cal.Number2);

        // int sum = calc.Add(cal.Number1, cal.Number2);
        // Console.WriteLine($"Sum of {cal.Number1} and {cal.Number2} is : {sum}");

        // Console.WriteLine($"Subtraction of {cal.Number1} and {cal.Number2} is : {calc.Subtract()}");

        // calc.Multiply(cal.Number1, cal.Number2);

        // calc.Divide();

        Calculator calc = new Calculator();
        // int n1 = 50, n2 = 10;
        // Console.WriteLine($"Before swapping n1 = {n1} and n2 = {n2}");
        // calc.swapNumbers(ref n1, ref n2);
        // Console.WriteLine($"Before swapping n1 = {n1} and n2 = {n2}");

        // int a=5;
        // calc.CalculateSquareAndCube(a,out int b, out int square, out int cube);
        // Console.WriteLine($"Square of {a} is {square} and Cube of {b} is {cube}");
        // Console.ReadKey();

        StaticDemo sd1 = new StaticDemo();
        sd1.var=30;
        sd1.count();
        sd1.count();
        sd1.count();
        Console.WriteLine($"Instance variable after increment: {sd1.display()}");

        StaticDemo sd2 = new StaticDemo();
        sd2.count();
        Console.WriteLine($"Instance variable of new object: {sd2.display()}");
    }
}
