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

// class Program
// {
//     public static void Main(string[] args)
//     {
//         // Using default constructor
//         // Calculator cal = new Calculator();
//         // cal.Number1 = 20;
//         // cal.Number2 = 10;

//         // // Using parameterized constructor
//         // Calculator calc = new Calculator(cal.Number1, cal.Number2);

//         // int sum = calc.Add(cal.Number1, cal.Number2);
//         // Console.WriteLine($"Sum of {cal.Number1} and {cal.Number2} is : {sum}");

//         // Console.WriteLine($"Subtraction of {cal.Number1} and {cal.Number2} is : {calc.Subtract()}");

//         // calc.Multiply(cal.Number1, cal.Number2);

//         // calc.Divide();

//         Calculator calc = new Calculator();
//         // int n1 = 50, n2 = 10;
//         // Console.WriteLine($"Before swapping n1 = {n1} and n2 = {n2}");
//         // calc.swapNumbers(ref n1, ref n2);
//         // Console.WriteLine($"Before swapping n1 = {n1} and n2 = {n2}");

//         // int a=5;
//         // calc.CalculateSquareAndCube(a,out int b, out int square, out int cube);
//         // Console.WriteLine($"Square of {a} is {square} and Cube of {b} is {cube}");
//         // Console.ReadKey();

//         StaticDemo sd1 = new StaticDemo();
//         sd1.var=30;
//         sd1.count();
//         sd1.count();
//         sd1.count();
//         Console.WriteLine($"Instance variable after increment: {sd1.display()}");

//         StaticDemo sd2 = new StaticDemo();
//         sd2.count();
//         Console.WriteLine($"Instance variable of new object: {sd2.display()}");
//     }
// }


//---------------------------------

// class Program
// {
//     public static void Main(string[] args)
//     {
//         //method overloading
//         Calculator2 calc = new Calculator2();

//         int result1 = calc.Add(50);
//         Console.WriteLine($"Result of Add(int n): {result1}");

//         int result2 = calc.Add(20, 30);
//         Console.WriteLine($"Result of Add(int n1, int n2): {result2}");

//         calc.Add("Hello, ", "World!");

//         calc.Add("SampleString", 12.34f, 56);
//     }
// }
//method overloading

// class Calculator2
// {
//     public int Add(int n)
//     {
//         int num1=30;
//         int num2=n;
//         return num1+num2;
//     }

//     public int Add(int n1,int n2)
//     {
//         int num1=n1;
//         int num2=n2;
//         return num1+num2;
//     }

//     public int Add(string str1,string str2)
//     {
//         string str3=str1+str2;
//         Console.WriteLine($"Concatenated string is : {str3}");
//         return 0;
//     }
//     public int Add(string str1, float f1, int n1)
//     {
//         Console.WriteLine($"String is : {str1}, Float is : {f1}, Integer is : {n1}");
//         return 0;
//     }
// }

//-----------------------
// class Program
// {
//     public static void Main(string[] args)
//     {
//         double distance=50.0;
//         double hour=5.0;
//         double fuel=10.0;
//         Vehical v = new Vehical(distance,hour,fuel);
//         v.Average();//Calling base class member method
//         v.Speed();//Calling base class member method

//         Car c = new Car(distance,hour,fuel);
//         c.Average();
//         c.Speed();

//     }
// }

//----------------------------------------
// class Program
// {
//     public static void Main(string[] args)
//     {
//         Furniture furniture;
//         Bookshelve bookshelves = new Bookshelve();
//         bookshelves.Accept();
//         bookshelves.Display();

//         Chair chair = new Chair();
//         chair.Accept();
//         chair.Display();

//         furniture = bookshelves;
//     }
// }

//-------------Interface--------------------

class Program
{
    public static void Main(string[] args)
    {
        IPayment payment;
        payment = new CreditCardPayment();
        payment.Refund(1000.0);
        payment.Pay(1000.0);

    }
}