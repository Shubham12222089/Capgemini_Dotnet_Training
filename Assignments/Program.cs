// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a year to check if it's a leap year: ");
        int year = Convert.ToInt32(Console.ReadLine());
        Assignment1 as1 = new Assignment1();
        as1.LeapYear(year);

        Console.WriteLine("=====================================");
        Assignment2 as2 = new Assignment2();
        as2.TempreatureConverter();
        
        Console.WriteLine("=====================================");
        Assignment3 as3 = new Assignment3();
        Console.WriteLine($"Grade : {as3.StudentGrade()}");

        Console.WriteLine("=====================================");
        Assignment4 as4 = new Assignment4();
        Console.Write("Enter a number (> 0) or 'q' to quit: ");
        string input = Console.ReadLine()?.Trim() ?? "";
        while (input.ToLower() != "q")
        {
            if (int.TryParse(input, out int number) && number > 0)
            {
                as4.Factorial(number);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a positive integer.");
            }

            Console.Write("Enter a number (> 0) or 'q' to quit: ");
            input = Console.ReadLine()?.Trim() ?? "";
        }

        Console.WriteLine("=====================================");
        Assignment5 as5 = new Assignment5();
        as5.SumTillN();

        Console.WriteLine("=====================================");
        Assignment6 as6 = new Assignment6();
        as6.Even();

    }
}

class Assignment1
{
    public void LeapYear(int year)
    {
        if(year%4==0 && year%100 !=0 || year % 400 == 0)
        {
            Console.WriteLine("{0} is a Leap Year", year);
        }
        else
        {
            Console.WriteLine("{0} is not a Leap Year", year);
        }
    }
}

class Assignment2
{
    public void TempreatureConverter()
    {
        Console.Write("Enter the Tempreature in Celsius : ");
        int Celsius = Convert.ToInt32(Console.ReadLine());
        float Fahrenheit = (Celsius * 9f / 5f) + 32f;
        Console.WriteLine($"Tempreature in Celsius : {Celsius}");
        Console.WriteLine($"Tempreature in Fahrenheit : {Fahrenheit}");
    }
}

class Assignment3
{
    public string StudentGrade()
    {
        Console.Write("Enter the Student's Exam Score: ");
        int grade=Convert.ToInt32(Console.ReadLine());
        string g;
        if (grade >= 90)
        {
            g="A";
        }
        else if(grade >= 80)
        {
            g="B";
        }
        else if(grade >= 70)
        {
            g="C";
        }
        else if(grade >= 60)
        {
            g="D";
        }
        else
        {
            g="F";
        }
        return g;
    }
}

class Assignment4
{
    public void Factorial(int fact)
    {
        if (fact <= 0)
        {
            Console.WriteLine("Number should be greater than 0");
            return;
        }

        int result = 1;

        for (int i = 1; i <= fact; i++)
        {
            result *= i;
        }

        Console.WriteLine($"Factorial of {fact} is {result}");
    }
}

class Assignment5
{
    public void SumTillN()
    {
        Console.Write("Enter the Number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        int result=0;
        if (num > 0)
        {
            for(int i = 1; i <= num; i++)
            {
                result+=i;
            }
            Console.WriteLine($"Sum of the first {num} natural numbers: {result}");
        }
        else
        {
            Console.WriteLine("Please enter a positive integer.");
        }
        
    }
}

class Assignment6
{
    public void Even()
    {
        Console.Write("Enter the Number: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"First {n} even numbers: ");
        while (n > 0)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i * 2);
            }
            break;
        }
    }
}