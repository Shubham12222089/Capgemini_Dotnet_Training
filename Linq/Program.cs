using System;
using System.Linq;
using System.Security.Cryptography;

class Student
{
    public int StudentId { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}

class Program
{
    public static void Main()
    {
        //DataSource

        string[] names = {"Jack","Steve","Dustin","Nancy","Will"};
        // //Write the Query
        // //IEnumerable<string> name =
        // var name = from s in names
        //             where s.Contains("a")
        //             select s;
        // //Execute the Query
        // foreach(string s in name)
        // {
        //     Console.WriteLine(s);
        // }
        //----------------2nd Approach-------------------
        var name = names.Where(s=>s.Contains("a"));
        foreach(string s in name)
        {
            Console.WriteLine(s);
        }
        //--------------using IEnumerable----------------------
        // Console.WriteLine();
        // IEnumerable<int> numbers = new List<int>{1,2,3,4,5,6,7,8,9};
        // var evens = numbers.Where(n=>n%2==0);
        // foreach(int i in evens)
        //     Console.WriteLine(i);

        //-----------------------------------
        // IEnumerable<string> stringList = new List<string>()
        // {
        //     "C# Tutorial",".Net Tutorial",
        //     "Learn C#","Java","SQL Tutorial"
        // };
        // var result = from s in stringList
        //                 where s.Contains("Tutorial")
        //                 select s;
        // foreach(string s in result)
        // {
        //     Console.WriteLine(s);
        // }

        //--------------------------------------
        //Student Collection
        // List<Student> studentList = new List<Student>()
        // {
        //     new Student { StudentId = 101, Name = "Abc", Age=19},
        //     new Student { StudentId = 102, Name = "Cde", Age=22},
        //     new Student { StudentId = 103, Name = "Fgh", Age=15},
        //     new Student { StudentId = 104, Name = "Xyz", Age=25},
        // };
        // //Query Syntax
        // var students = from s in studentList
        //                 where s.Age>12 && s.Age<20
        //                 select s;

        // //Method syntax 
        // var students2 = studentList.Where(s=>s.Age>12 && s.Age<20);
        // Console.WriteLine("Following  Students are Teen Age: ");
        // foreach(var i in students2)
        // {
        //     Console.WriteLine($"Name : {i.Name}");
        // }

        //------------------------------------------------
        List<Employee> employees = new List<Employee>()
        {
            new Employee { Id = 1, Name = "Rahul", Age = 25, Department = "IT", Salary = 50000 },
            new Employee { Id = 2, Name = "Anita", Age = 30, Department = "HR", Salary = 45000 },
            new Employee { Id = 4, Name = "Maccullum", Age = 27, Department = "IT", Salary = 65000 },
            new Employee { Id = 3, Name = "Suresh", Age = 28, Department = "Finance", Salary = 60000 }
        };

        // var query = from employee in employees
        //             where employee.Department=="IT" && employee.Salary>50000
        //             select employee;

        var query = from employee in employees
                    orderby(employee.Name)
                    select employee;
        foreach(var q in query)
        {
            Console.WriteLine(
                $"Id: {q.Id}, Name: {q.Name}, Age: {q.Age}, Dept: {q.Department}, Salary: {q.Salary}"
            );
        }
    }
}