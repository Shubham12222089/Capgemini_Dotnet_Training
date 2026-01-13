// A class without a name, created at runtime, used to hold a set of read-only properties temporarily.
// Why do we use Anonymous Classes?
// When you don’t want to create a full class
// For temporary data grouping

// using System;

// public class Program
// {
//     public static void Main()
//     {
//         var employee = new
//         {
//             Id = 101,
//             Name = "Abc",
//             Department = "AI/ML",
//             Salary = 50000
//         };

//         Console.WriteLine("Employee Details:");
//         Console.WriteLine("Id: " + employee.Id);
//         Console.WriteLine("Name: " + employee.Name);
//         Console.WriteLine("Department: " + employee.Department);
//         Console.WriteLine("Salary: " + employee.Salary);
//     }
// }

//---------------using delegate-----------------------

// using System;

// public delegate int Calculation(int a, int b);
// public delegate void Display(string message);

// public class Program
// {
//     public static void Main()
//     {
//         var calculator = new
//         {
//             Add = new Calculation(AddNumbers),
//             Show = new Display(ShowMessage)
//         };

//         int sum = calculator.Add(5, 7);
//         calculator.Show("Addition completed");

//         Console.WriteLine("Result: " + sum);
//     }

//     public static int AddNumbers(int a, int b)
//     {
//         return a + b;
//     }

//     public static void ShowMessage(string message)
//     {
//         Console.WriteLine("Message: " + message);
//     }
// }

//--------------------------

// using System;

// delegate bool IsTeenager(Student stud);

// class Student
// {
//     public int Id { get; set; }
//     public string Name { get; set; }
//     public int Age { get; set; }
// }

// class Program
// {
//     public static void Main(string[] args)
//     {
//         Student student = new Student
//         {
//             Id = 101,
//             Name = "Rajesh",
//             Age = 19
//         };

//         // Anonymous method
//         IsTeenager isTeenagerAnon = delegate (Student s)
//         {
//             return s.Age > 12 && s.Age < 20;
//         };

//         // Lambda expression (block body)
//         IsTeenager isTeenager1 = (s) =>
//         {
//             return s.Age > 12 && s.Age < 20;
//         };

//         // Lambda expression (expression body)
//         IsTeenager isTeenager2 = s => s.Age > 12 && s.Age < 20;

//         Console.WriteLine(isTeenager1(student)); // True
//     }
// }


//---------------Extension method--------------

using System;

namespace CalculatorLib
{
    // Original class
    public class Calculator
    {
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        public int Divide(int num1, int num2)
        {
            return num1 / num2;
        }
    }

    // Extension methods
    public static class CalculatorExtensions
    {
        public static int Multiply(this Calculator calculator, int num1, int num2)
        {
            return num1 * num2;
        }

        public static int Modulus(this Calculator calculator, int num1, int num2)
        {
            return num1 % num2;
        }
    }

    // Program class INSIDE SAME NAMESPACE
    class Program
    {
        static void Main()
        {
            Calculator calculator = new Calculator();

            Console.WriteLine(calculator.Add(10, 5));       // 15
            Console.WriteLine(calculator.Subtract(10, 5));  // 5
            Console.WriteLine(calculator.Divide(10, 5));    // 2

            // Extension methods (NOW WORKS)
            Console.WriteLine(calculator.Multiply(10, 5));  // 50
            Console.WriteLine(calculator.Modulus(10, 3));   // 1
        }
    }
}
