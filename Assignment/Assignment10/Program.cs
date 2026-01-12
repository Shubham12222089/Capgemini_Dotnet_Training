// using System;
// using System.Collections;
// using System.Diagnostics;
// using Microsoft.VisualBasic;

// class Program
// {
//     public static void Main(string[] args)
//     {

//         Console.WriteLine("Enter the Input : ");
//         string str="";
//         ArrayList Names = new ArrayList();
//         while(true){
//             str = Console.ReadLine().ToLower();
//             if(str== "stop".ToLower())
//             {
//                 break;
//             }
//             if (str == null){
//                 continue;
//             }
//             if (!IsValidName(str)){
//                 continue;
//             }
//             if (IsNameInCollection(Names, str))
//             {
//                 Console.WriteLine($"{str} is Already in the Collection.");

//             }
//             else
//             {
//                 Names.Add(str);
//                 Console.WriteLine($"{str} Added to the Collection.");

//             }
//         }
//         DisplayStudentNames(Names);


//     }
//     private static void DisplayStudentNames(ArrayList studentNames)
//     {
//         Console.WriteLine("Unique student names entered: ");
//         foreach(string i in studentNames){
//             Console.WriteLine(i);
//         }
//     }
//     private static bool IsValidName(string name)
//     {
//         return !string.IsNullOrWhiteSpace(name);
//     }
//     private static bool IsNameInCollection(ArrayList studentNames, string name)
//     {
//         if (studentNames.Contains(name))
//         {
//             return true;  
//         }
//         return false; 
//     }
// }

//-----------------------------

// using System;
// using System.Collections;

// public class Program
// {
//     public static void Main(string[] args)
//     {
//         ArrayList numbers = new ArrayList();

//         while (true)
//         {
//             string command = Console.ReadLine();

//             if (command == null)
//                 continue;

//             command = command.ToLower();

//             switch (command)
//             {
//                 case "add":
//                     AddNumber(numbers);
//                     break;

//                 case "remove":
//                     RemoveNumber(numbers);
//                     break;

//                 case "display":
//                     DisplayNumbers(numbers);
//                     break;

//                 case "exit":
//                     return;

//                 default:
//                     Console.WriteLine("Invalid command.");
//                     break;
//             }
//         }
//     }

//     private static void AddNumber(ArrayList numbers)
//     {
//         string input = Console.ReadLine();
//         int value;

//         if (int.TryParse(input, out value))
//         {
//             numbers.Add(value);
//             Console.WriteLine($"{value} added to the number list.");
//         }
//         else
//         {
//             Console.WriteLine("Invalid input. Please enter a valid number.");
//         }
//     }

//     private static void RemoveNumber(ArrayList numbers)
//     {
//         string input = Console.ReadLine();
//         int value;

//         if (int.TryParse(input, out value))
//         {
//             if (numbers.Contains(value))
//             {
//                 numbers.Remove(value);
//                 Console.WriteLine($"{value} removed from the number list.");
//             }
//             else
//             {
//                 Console.WriteLine($"{value} not found in the number list.");
//             }
//         }
//         else
//         {
//             Console.WriteLine("Invalid input. Please enter a valid number.");
//         }
//     }

//     private static void DisplayNumbers(ArrayList numbers)
//     {
//         Console.WriteLine("Current numbers in the list:");
//         foreach (int num in numbers)
//         {
//             Console.WriteLine(num);
//         }
//     }
// }


//-----------------------------

// using System.Collections;

// class Album
// {
//     public string Title{get;set;}
//     public string Artist{get;set;}


// }

// class Program
// {
//     public static void Main(string[] args)
//     {
//         ArrayList albums = new ArrayList();

//         while(true){

//             Console.Write("Enter the Title : ");
//             string title = Console.ReadLine();
//             if (title == null)
//                 continue;

//             if (title.ToLower() == "quit")
//                 break;

//             Console.Write("Enter the Artist: ");
//             string artist = Console.ReadLine();


//             if (IsValidInput(title) && IsValidInput(artist))
//             {
//                 Album albumclass = new Album();
//                 albumclass.Title = title;
//                 albumclass.Artist = artist;
//                 albums.Add(albumclass);
//             }


//         }
//         Display(albums);

//     }
//     private static bool IsValidInput(string input)
//     {
//         if (string.IsNullOrWhiteSpace(input))
//         {
//             return false;
//         }
//         return true;
//     }
//     private static void Display(ArrayList array)
//     {
//         foreach(Album i in array)
//         {
//             Console.WriteLine($"Title: {i.Title}, Artist: {i.Artist}");
//         }
//     }
// }

//---------------------------------

// using System.Data.Common;

// public class Student
// {
//     public int Id{get;set;}
//     public string Name{get;set;}
//     public string Grade{get;set;}



// }

// public class StudentManager
// {
//     public Dictionary<int, Student> students{get;set;}
//     public StudentManager()
//     {
//         students = new Dictionary<int, Student>();
//     }
//     public void AddStudent(Student student)
//     {
//         students[student.Id] = student;
//     }
//     public void DisplayStudents()
//     {
//         foreach (var entry in students)
//         {
//             Student s = entry.Value;
//             Console.WriteLine($"ID: {s.Id}, Name: {s.Name}, Grade: {s.Grade}");
//         }
//     }
// }

// class Program
// {
//     public static void Main(string[] args)
//     {
//         StudentManager studentManager = new StudentManager();
//         Console.WriteLine("Enter the number of Students: ");
//         int number = Convert.ToInt32(Console.ReadLine());
//         for(int i = 0; i < number; i++)
//         {
//             int id = Convert.ToInt32(Console.ReadLine());
//             string name = Console.ReadLine();
//             string grade = Console.ReadLine();

//             Student student = new Student()
//             {
//                 Id = id,
//                 Name = name,
//                 Grade = grade
//             };
//             studentManager.AddStudent(student);
//         }
//         studentManager.DisplayStudents();
//     }
// }

//---------------------------------

// using System;
// using System.Collections.Generic;

// public class Program
// {
//     public static void Main(string[] args)
//     {
//         HashSet<string> items = new HashSet<string>();

//         while (true)
//         {
//             Console.WriteLine("Choose an operation:");
//             Console.WriteLine("1: Create (Add a new string)");
//             Console.WriteLine("2: Read (Display all strings)");
//             Console.WriteLine("3: Update (Update an existing string)");
//             Console.WriteLine("4: Delete (Remove a string)");
//             Console.WriteLine("5: Exit");

//             Console.Write("Enter your choice: ");
//             int choice = int.Parse(Console.ReadLine());

//             switch (choice)
//             {
//                 case 1:
//                     Create(items);
//                     break;

//                 case 2:
//                     Read(items);
//                     break;

//                 case 3:
//                     Update(items);
//                     break;

//                 case 4:
//                     Delete(items);
//                     break;

//                 case 5:
//                     Console.WriteLine("Exiting...");
//                     return;

//                 default:
//                     Console.WriteLine("Invalid choice.");
//                     break;
//             }
//         }
//     }

//     public static void Create(HashSet<string> items)
//     {
//         Console.Write("Enter the string to add: ");
//         string value = Console.ReadLine();

//         if (items.Add(value))
//         {
//             Console.WriteLine($"'{value}' has been added.");
//         }
//         else
//         {
//             Console.WriteLine($"'{value}' already exists in the set.");
//         }
//     }

//     public static void Read(HashSet<string> items)
//     {
//         Console.WriteLine("Current items in the set:");
//         foreach (string item in items)
//         {
//             Console.WriteLine(item);
//         }
//     }

//     public static void Update(HashSet<string> items)
//     {
//         Console.Write("Enter the string to update: ");
//         string oldValue = Console.ReadLine();

//         if (!items.Contains(oldValue))
//         {
//             Console.WriteLine($"'{oldValue}' does not exist in the set.");
//             return;
//         }

//         Console.Write("Enter the new string: ");
//         string newValue = Console.ReadLine();

//         if (items.Contains(newValue))
//         {
//             Console.WriteLine($"Update failed. '{newValue}' already exists in the set.");
//             return;
//         }

//         items.Remove(oldValue);
//         items.Add(newValue);
//         Console.WriteLine($"'{oldValue}' has been updated to '{newValue}'.");
//     }

//     public static void Delete(HashSet<string> items)
//     {
//         Console.Write("Enter the string to delete: ");
//         string value = Console.ReadLine();

//         if (items.Remove(value))
//         {
//             Console.WriteLine($"'{value}' has been removed.");
//         }
//         else
//         {
//             Console.WriteLine($"'{value}' does not exist in the set.");
//         }
//     }
// }


//-----------------------------------
// using System;
// using System.Collections.Generic;

// public class Program
// {
//     public static void Main(string[] args)
//     {
//         string input = Console.ReadLine();

//         List<int> numbers = ParseIntegers(input);
//         List<int> oddNumbers = GetOddNumbers(numbers);

//         if (oddNumbers.Count > 0)
//         {
//             Console.WriteLine(string.Join(" ", oddNumbers));
//         }
//     }

//     private static List<int> ParseIntegers(string input)
//     {
//         List<int> result = new List<int>();

//         if (string.IsNullOrWhiteSpace(input))
//             return result;

//         string[] tokens = input.Split(' ');

//         foreach (string token in tokens)
//         {
//             if (int.TryParse(token, out int value))
//             {
//                 result.Add(value);
//             }
//         }

//         return result;
//     }

//     private static List<int> GetOddNumbers(List<int> numbers)
//     {
//         List<int> oddNumbers = new List<int>();

//         foreach (int num in numbers)
//         {
//             if (num % 2 != 0)
//             {
//                 oddNumbers.Add(num);
//             }
//         }

//         oddNumbers.Sort();
//         return oddNumbers;
//     }
// }


//------Simple Calculator using delegate-------------
class Program
{
    public delegate double ArithmeticOperation(double a,double b);
    public static void Main(string[] args)
    {
        try{
            Console.Write("Enter the First  Number : ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the Second Number : ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Operation : ");
            string operation = Console.ReadLine();
            ArithmeticOperation op=null;
            switch (operation)
            {
                case "add":
                    op=Add;
                    break;
                case "substract":
                    op = Substract;
                    break;
                case "multiply":
                    op=Multiply;
                    break;
                case "divide":
                    op = Divide;
                    break;
                default:
                    Console.WriteLine("Invalid Operation");
                    return;
            }
            double result = PerformOperation(op,a,b);
            Console.WriteLine($"The Result is: {result:F2}");
        }
        catch(DivideByZeroException e)
        {
            Console.WriteLine($"Error: {e.Message}");
        }
    }
    public static double Add(double a,double b)
    {
        return a+b;
    }
    public static double Substract(double a,double b)
    {
        return a-b;
    }
    public static double Multiply(double a,double b)
    {
        return a*b;
    }
    public static double Divide(double a,double b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Division by zero is not Allowed.");
        }
        return a/b;
    }
    public static double PerformOperation(ArithmeticOperation operation, double a, double b)
    {
        return operation(a, b);
    }
}