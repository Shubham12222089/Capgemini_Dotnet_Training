
using System;
using System.Diagnostics.Contracts;

class Employee
{
    public int EmployeeId {get;set;}
    public string Name {get;set;}
    public float Salary {get;set;}
    public Employee()
    {
        EmployeeId=0;
        Name=string.Empty;
        Salary=0.0f;
    }
    public Employee(int EmpId,string Name,float salary)
    {
        this.EmployeeId=EmpId;
        this.Name=Name;
        this.Salary=salary;
    }

    //Override using ToString
    public override string ToString()
    {
        return $"Employee Details are\n"
                +$"Emplyee Id is : {EmployeeId}\n"+
                $"Employee Name is : {Name}\n"+
                $"Employee Salary is : {Salary}";
    }
}