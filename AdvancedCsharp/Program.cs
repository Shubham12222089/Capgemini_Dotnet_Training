using System;
using System.Runtime.CompilerServices;
// namespace PartialDemo
// {
//     class Program
//     {
//         public static void Main(string[] args)
//         {
//             PartialEmployee emp = new PartialEmployee();
//             emp.FirstName = "Rajesh";
//             emp.LastName = "Kumar";
//             emp.Gender= "Male";
//             emp.Salary = 75000;
//             emp.DisplayEmployeeDetails();
//             emp.DisplayEmployeeFullName();
//             //emp.PartialMethod(); //Inaccessible due to protection level
//         }
//     }
// }

//delegate example
namespace CalculatorApp
{
    public delegate int CalculatorDelegate(int num1,int num2);
    class Program
    {
        public static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            CalculatorDelegate calcutAdd = new CalculatorDelegate(calculator.Add);
            CalculatorDelegate calcutSub = new CalculatorDelegate(calculator.Subtract);
            CalculatorDelegate calcutMul = new CalculatorDelegate(calculator.Multiply);
            CalculatorDelegate calcutDiv = new CalculatorDelegate(calculator.Divide);
            CalculatorDelegate CalculateMultiCast;

            //calling the delegate 
            int sum = calcutAdd(30,20);
            Console.WriteLine($"Sum of the Two Number is : {sum}");

            int subtract = calcutSub(30,20);
            Console.WriteLine($"Subtraction of the Two Number is : {subtract}");

            int mult = calcutMul(30,20);
            Console.WriteLine($"Multiplication of the Two Number is : {mult}");

            int div = calcutDiv(30,20);
            Console.WriteLine($"Division of the Two Number is : {div}");

            CalculateMultiCast = calcutAdd;
            CalculateMultiCast = calcutSub;
            CalculateMultiCast = calcutMul;
            CalculateMultiCast = calcutDiv;

            Console.WriteLine($"Called Multicast Delegate : "+CalculateMultiCast(30,3));
        }
    }
}