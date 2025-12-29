// virtual: “You may override this.”
// override: “I am overriding it.”
// abstract: “You must override this (in concrete child).”
// sealed: “You cannot inherit/override further.”
//A partial method is a method you can declare in one part of a partial class/struct and optionally implement in another part.
using System;
public class Employee
{
    protected int Eid, Eage;
    protected string Ename, Eaddress;
    protected float Salary;
    //why virtual method -> because we want to override it in derived class
    public virtual void GetEmployeeDetails()
    {
        Console.WriteLine("Enter Employee Details:");
        Console.WriteLine("Enter Employee Id: ");
        Eid = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Employee Name: ");
        Ename = Console.ReadLine();
        Console.WriteLine("Enter Employee Address: ");
        Eaddress = Console.ReadLine();
        Console.WriteLine("Enter Employee Age: ");
        Eage = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Employee Salary: ");
        Salary = float.Parse(Console.ReadLine() ?? "0");
    }
    public virtual void DisplayEmployeeDetails()
    {
        Console.WriteLine("Employee Details:");
        Console.WriteLine($"Employee Id: {Eid}");
        Console.WriteLine($"Employee Name: {Ename}");
        Console.WriteLine($"Employee Address: {Eaddress}");
        Console.WriteLine($"Employee Age: {Eage}");
        Console.WriteLine($"Employee Salary: {Salary}");
    }
    public virtual void CalculateSalary()
    {
        Console.WriteLine($"Employee Salary : {Salary}");
    }
}