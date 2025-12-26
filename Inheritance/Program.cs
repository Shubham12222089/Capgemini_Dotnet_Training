using System;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;

class Program
{
    public static void Main(string[] args)
    {
        //Object Initializer
        // Employee emp=new Employee
        // {
        //     EmployeeId=101,
        //     Name="Rajesh",
        //     Salary=75000
        // };
        // Console.WriteLine($"Employee Id is : {emp.EmployeeId}");
        // Console.WriteLine($"Employee Name is : {emp.Name}");
        // Console.WriteLine($"Employee Salary is : {emp.Salary}");

        // Console.WriteLine($"{emp}");

        //==============================
        program p = new program();
        p.Add(10,5,9,10);

        
    }
}

class program
{
    // public void Add(int num1, int num2)
    // {
    //     Console.WriteLine($"Sum is : {num1+num2}");
    // }
    public void Add(params int[] arr)
    {
        int sum=0;
        for(int i = 0; i < arr.Length; i++)
        {
            sum+=arr[i];
        }
        Console.WriteLine($"Sum is : {sum}");
    }
}
