using System;
namespace PartialDemo
{
    public partial class PartialEmployee
    {
        public void DisplayEmployeeFullName()
        {
            Console.WriteLine($"Employee Full Name is : {_FirstName} {_LastName}");
        }
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine("Employee Details:");
            Console.WriteLine($"First Name: {_FirstName}");
            Console.WriteLine($"Last Name: {_LastName}");
            Console.WriteLine($"Gender: {_Gender}");
            Console.WriteLine($"Salary: {_Salary}");
        }
        partial void PartialMethod()
        {
            Console.WriteLine("Partial Method Invoked.");
        }
    }
}