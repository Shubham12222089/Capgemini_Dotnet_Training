// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
// class Program
// {
//     public static void Main(string[] args)
//     {
//         Console.Write("Enter a year to check if it's a leap year: ");
//         int year = Convert.ToInt32(Console.ReadLine());
//         Assignment1 as1 = new Assignment1();
//         as1.LeapYear(year);

//         Console.WriteLine("=====================================");
//         Assignment2 as2 = new Assignment2();
//         as2.TempreatureConverter();
        
//         Console.WriteLine("=====================================");
//         Assignment3 as3 = new Assignment3();
//         Console.WriteLine($"Grade : {as3.StudentGrade()}");

//         Console.WriteLine("=====================================");
//         Assignment4 as4 = new Assignment4();
//         Console.Write("Enter a number (> 0) or 'q' to quit: ");
//         string input = Console.ReadLine()?.Trim() ?? "";
//         while (input.ToLower() != "q")
//         {
//             if (int.TryParse(input, out int number) && number > 0)
//             {
//                 as4.Factorial(number);
//             }
//             else
//             {
//                 Console.WriteLine("Invalid input. Please enter a positive integer.");
//             }

//             Console.Write("Enter a number (> 0) or 'q' to quit: ");
//             input = Console.ReadLine()?.Trim() ?? "";
//         }

//         Console.WriteLine("=====================================");
//         Assignment5 as5 = new Assignment5();
//         as5.SumTillN();

//         Console.WriteLine("=====================================");
//         Assignment6 as6 = new Assignment6();
//         as6.Even();

//     }
// }

// class Assignment1
// {
//     public void LeapYear(int year)
//     {
//         if(year%4==0 && year%100 !=0 || year % 400 == 0)
//         {
//             Console.WriteLine("{0} is a Leap Year", year);
//         }
//         else
//         {
//             Console.WriteLine("{0} is not a Leap Year", year);
//         }
//     }
// }

// class Assignment2
// {
//     public void TempreatureConverter()
//     {
//         Console.Write("Enter the Tempreature in Celsius : ");
//         int Celsius = Convert.ToInt32(Console.ReadLine());
//         float Fahrenheit = (Celsius * 9f / 5f) + 32f;
//         Console.WriteLine($"Tempreature in Celsius : {Celsius}");
//         Console.WriteLine($"Tempreature in Fahrenheit : {Fahrenheit}");
//     }
// }

// class Assignment3
// {
//     public string StudentGrade()
//     {
//         Console.Write("Enter the Student's Exam Score: ");
//         int grade=Convert.ToInt32(Console.ReadLine());
//         string g;
//         if (grade >= 90)
//         {
//             g="A";
//         }
//         else if(grade >= 80)
//         {
//             g="B";
//         }
//         else if(grade >= 70)
//         {
//             g="C";
//         }
//         else if(grade >= 60)
//         {
//             g="D";
//         }
//         else
//         {
//             g="F";
//         }
//         return g;
//     }
// }

// class Assignment4
// {
//     public void Factorial(int fact)
//     {
//         if (fact <= 0)
//         {
//             Console.WriteLine("Number should be greater than 0");
//             return;
//         }

//         int result = 1;

//         for (int i = 1; i <= fact; i++)
//         {
//             result *= i;
//         }

//         Console.WriteLine($"Factorial of {fact} is {result}");
//     }
// }

// class Assignment5
// {
//     public void SumTillN()
//     {
//         Console.Write("Enter the Number: ");
//         int num = Convert.ToInt32(Console.ReadLine());
//         int result=0;
//         if (num > 0)
//         {
//             for(int i = 1; i <= num; i++)
//             {
//                 result+=i;
//             }
//             Console.WriteLine($"Sum of the first {num} natural numbers: {result}");
//         }
//         else
//         {
//             Console.WriteLine("Please enter a positive integer.");
//         }
        
//     }
// }

// class Assignment6
// {
//     public void Even()
//     {
//         Console.Write("Enter the Number: ");
//         int n = Convert.ToInt32(Console.ReadLine());
//         Console.WriteLine($"First {n} even numbers: ");
//         while (n > 0)
//         {
//             for (int i = 1; i <= n; i++)
//             {
//                 Console.WriteLine(i * 2);
//             }
//             break;
//         }
//     }
// }

//-------------------------2nd Assignment----------------------------

// class Program
// {
//     public static void Main(string[] args)
//     {
//         Console.WriteLine("======================Assignment 1=======================");
//         Calculator calc = new Calculator();
//         calc.Number1=10;
//         calc.Number2=5;

//         Console.WriteLine($"Addition of {calc.Number1} and {calc.Number2} is : {calc.Add(calc.Number1,calc.Number2)}");
//         Console.WriteLine($"Substraction is : {calc.Subtract()}");
//         calc.Multiply(calc.Number1,calc.Number2);
//         calc.Divide();  

//         Console.WriteLine("======================Assignment 2=======================");
//         Console.WriteLine("Using Default Constructor:");
//         BillingSoftware bs = new BillingSoftware();
//         Console.WriteLine($"Addition is : {bs.Number3} + {bs.Number4} = {bs.Add(bs.Number3,bs.Number4)}");
//         Console.WriteLine("Using Parameterized Constructor:");
//         BillingSoftware bill = new BillingSoftware(15,25);
//         Console.WriteLine($"Addition is : {bill.Number3} + {bill.Number4} = {bs.Add(bill.Number3,bill.Number4)}");

//         Console.WriteLine("======================Assignment 3=======================");
//         Payroll p = new Payroll();
//         int num1=30000;
//         int num2=6000;
//         Console.WriteLine("Before Method Call:");
//         Console.WriteLine($"Basic Pay: {num1}, Allowance: {num2}");
//         p.swap(num1, num2);
//         Console.WriteLine("After Method Call:");
//         Console.WriteLine($"Basic Pay: {num1}, Allowance: {num2}");

//         Console.WriteLine("======================Assignment 4=======================");
//         UsingReferene ur = new UsingReferene();
//         int emp1=101;
//         int emp2=202;
//         Console.WriteLine("Before Method Call:");
//         Console.WriteLine($"Employee A ID: {emp1}, Employee B ID: {emp2}");
//         ur.swap1(ref emp1,ref emp2);
//         Console.WriteLine("After Method Call:");
//         Console.WriteLine($"Employee A ID: {emp1}, Employee B ID: {emp2}");

//         Console.WriteLine("======================Assignment 5=======================");
//         Examination ex = new Examination();
//         int subject1 = 85;
//         int subject2 = 90;

//         int total, mark1, mark2;
//         ex.Addition(subject1, subject2, out total, out mark1, out mark2);
//         Console.WriteLine($"Subject 1 Marks: {mark1}");
//         Console.WriteLine($"Subject 2 Marks: {mark2}");
//         Console.WriteLine($"Total Marks: {total}");

//         Console.WriteLine("======================Assignment 6=======================");
//         UtilityService us = new UtilityService();
//         us.Number1 = 50;
//         us.Number2 = 30;
//         us.Add();

//         Console.WriteLine("======================Assignment 7=======================");
//         int num5 = 40;
//         int num6 = 60;

//         int result, num7, num8;

//         CalculatorFeatures calf = new CalculatorFeatures();
//         calf.Addition(num5, num6, out result, out num7, out num8);
//         Console.WriteLine($"{num7} + {num8} = {result}");
//     }
// }

// //Assignment 1----------------
// class Calculator
// {
//     private int number1;
//     private int number2;
//     public int Number1
//     {
//         get { return number1; }
//         set { number1 = value; }
//     }

//     public int Number2
//     {
//         get { return number2; }
//         set { number2 = value; }
//     }

//     public Calculator()
//     {
//         number1 = 0;
//         number2 = 0;
//     }
//     public Calculator(int num1, int num2)
//     {
//         this.number1 = num1;
//         this.number2 = num2;
//     }

//     public int Add(int number1, int number2)
//     {
//         return number1 + number2;
//     }

//     public int Subtract()
//     {
//         return number1 - number2;
//     }

//     public void Multiply(int number1, int number2)
//     {
//         int result = number1 * number2;
//         Console.WriteLine($"Multiplication of {number1} and {number2} is : {result}");
//     }

//     public void Divide()
//     {
//         if (number2 != 0)
//         {
//             int result = number1 / number2;
//             Console.WriteLine($"Division of {number1} by {number2} is : {result}");
//         }
//         else
//         {
//             Console.WriteLine("Division by zero is not allowed.");
//         }
//     }
// }

// //Assignment 2
// class BillingSoftware
// {
//     private int number3;
//     private int number4;

//     public int Number3
//     {
//         get { return number3; }
//         set { number3 = value; }
//     }
//     public int Number4
//     {
//         get { return number4; }
//         set { number4 = value; }
//     }
//     public BillingSoftware()
//     {
//         number3 = 0;
//         number4 = 0;
        
//     }
//     public BillingSoftware(int num3, int num4)
//     {
//         this.number3 = num3;
//         this.number4 = num4;
//     }

//     public int Add(int number3, int number4)
//     {
//         return number3 + number4;
//     }

//     public int Multiply()
//     {
//         return number3 * number4;
//     }
// }

// //Assignment 3
// class Payroll
// {
//     public void swap(int num1, int num2)
//     {
//         int temp=num1;
//         num1=num2;
//         num2=temp;
        
//     }
// }

// //Assignment 4
// class UsingReferene
// {
//     public void swap1(ref int num1,ref int num2)
//     {
//         int temp=num1;
//         num1=num2;
//         num2=temp;
//     }
// }

// //Assignment 5

// class Examination
// {
//     public void Addition(int n1, int n2, out int result, out int n3, out int n4)
//     {
        
//         result = n1 + n2;
//         n3 = n1;
//         n4 = n2;
//     }
// }

// //Assignment 6

// class UtilityService
// {
//     public int Number1 { get; set; }
//     public int Number2 { get; set; }
//     public int Result { get; set; }

//     public void Add()
//     {
//         Result = Number1 + Number2;
//         Console.WriteLine($"Result: {Result}" );
//     }
// }

// class CalculatorFeatures
// {
//     public void Addition(int num5, int num6, out int result, out int num7, out int num8)
//     {
//         result = num5 + num6;
//         num7 = num5;
//         num8 = num6;
//     }
// }


