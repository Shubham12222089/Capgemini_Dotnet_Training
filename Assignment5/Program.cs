// using System;

// public class Animal
// {
//     public virtual void MakeSound()
//     {
//         Console.WriteLine("Some generic animal Sound");
//     }
// }

// class Dog : Animal
// {
//     public override void MakeSound()
//     {
//         Console.WriteLine("Bark");
//     }
// }

// class Cat : Animal
// {
//     public override void MakeSound()
//     {
//         Console.WriteLine("Meow");
//     }
// }
// class Program
// {
//     public static void Main(string[] args)
//     {
//         int number;
//         while (true)
//         {
//             if (int.TryParse(Console.ReadLine(), out number))
//             {
//                 if (number > 0)
//                     break;
//                 else
//                 {
//                     Console.WriteLine("Please enter a valid positive integer.");
//                     return;
//                 }
//             }
//         }

//         Animal[] animal = new Animal[number];

//         for(int i = 0; i < number; i++)
//         {
//             while (true)
//             {
//                 string input = Console.ReadLine().ToLower();
//                 if (input == "animal")
//                 {
//                     animal[i] = new Animal();
//                     break;
//                 }
//                 else if (input == "dog")
//                 {
//                     animal[i] = new Dog();
//                     break;
//                 }
//                 else if (input == "cat")
//                 {
//                     animal[i] = new Cat();
//                     break;
//                 }
//             }
//         }
//         Console.WriteLine("Sounds of the animals in the array:");
//         foreach (Animal i in animal)
//         {
//             i.MakeSound();
//         }


//     }
// }

//-------------------2nd Question---------------------

public class Employee
{
    protected double hourlyrate;
    protected double hoursworked;

    public Employee(double hourlyRate, double hoursWorked)
    {
        this.hourlyrate = hourlyRate;
        this.hoursworked = hoursWorked;
    }

    public virtual double CalculateSalary()
    {
        return hourlyrate * hoursworked;
    }
}

public class FullTimeEmployee : Employee
{
    public FullTimeEmployee(double hourlyrate, double hoursworked) : base(hourlyrate, hoursworked){ }

    public override double CalculateSalary()
    {
        return hourlyrate * hoursworked;
    }
}

public class PartTimeEmployee : Employee
{
    public PartTimeEmployee(double hourlyrate, double hoursworked)
    : base(hourlyrate,hoursworked){ }

    public override double CalculateSalary()
    {
        return (hourlyrate * 0.8) * hoursworked;
    }
}

public class Intern : Employee
{
    public Intern(double hourlyrate,double hoursworked) :
    base (hourlyrate,hoursworked){}

    public override double CalculateSalary()
    {
        return (hourlyrate * 0.6) * hoursworked;
    }
}


public class Program
{
    public static void Main()
    {
        if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
        {
            Console.WriteLine("Please enter a valid positive integer.");
            return;
        }

        Employee[] employees = new Employee[n];
        string[] employeeTypes = new string[n];

        for (int i = 0; i < n; i++)
        {
            while (true)
            {
                string type = Console.ReadLine().ToLower();

                if (type != "fulltimeemployee" &&
                    type != "parttimeemployee" &&
                    type != "intern")
                {
                    Console.WriteLine(
                        "Unknown employee type. Please enter FullTimeEmployee, PartTimeEmployee, or Intern.");
                    continue;
                }

                double rate, hours;

                if (!double.TryParse(Console.ReadLine(), out rate))
                {
                    Console.WriteLine(
                        "Invalid input for hourly rate. Please enter a numeric value.");
                    continue;
                }

                if (!double.TryParse(Console.ReadLine(), out hours))
                {
                    Console.WriteLine(
                        "Invalid input for hours worked. Please enter a numeric value.");
                    continue;
                }

                if (type == "fulltimeemployee")
                    employees[i] = new FullTimeEmployee(rate, hours);
                else if (type == "parttimeemployee")
                    employees[i] = new PartTimeEmployee(rate, hours);
                else
                    employees[i] = new Intern(rate, hours);

                employeeTypes[i] =
                    char.ToUpper(type[0]) + type.Substring(1);

                break;
            }
        }

        Console.WriteLine("Salaries of the employees:");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(
                $"Salary of Employee {i + 1} ({employeeTypes[i]}): {employees[i].CalculateSalary()}");
        }
    }
}