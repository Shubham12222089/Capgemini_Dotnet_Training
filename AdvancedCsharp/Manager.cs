// using System;
// public sealed class Manager : Employee //sealed class cannot be inherited
// {
//     double Bonus, CA;
//     public override void GetEmployeeDetails()
//     {
//         Console.WriteLine("Enter the Manager Details:");
//         Console.WriteLine("Enter the Manager ID: ");
//         Eid = Convert.ToInt32(Console.ReadLine());
//         Console.WriteLine("Enter the Manager Name: ");
//         Ename = Console.ReadLine();
//         Console.WriteLine("Enter the Bonus: ");
//         Bonus = Convert.ToDouble(Console.ReadLine());
//         Console.WriteLine("Enter the CA: ");
//         CA = Convert.ToDouble(Console.ReadLine());
        
//     }
//     public override void DisplayEmployeeDetails()
//     {
//         Console.WriteLine("Manager Details:");
//         Console.WriteLine($"Manager Id: {Eid}");
//         Console.WriteLine($"Manager Name: {Ename}");
//         Console.WriteLine($"Bonus: {Bonus}");
//         Console.WriteLine($"CA: {CA}");
//     }
//     public override void CalculateSalary()
//     {
//         Console.WriteLine($"Manager Salary is : {Salary}");
//     }
// }