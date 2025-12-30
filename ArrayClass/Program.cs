// 🔹 1. Properties / Information
// Member	            Purpose
// Length	            Total number of elements
// Rank	                Number of dimensions
// LongLength	        Length (64-bit)
// GetLength(dimension)	    Size of a dimension
// GetUpperBound(dimension)	    Last index
// GetLowerBound(dimension)	    First index
// 🔹 2. Copying / Clearing
// Method	Purpose
// Copy(source, dest, length)	    Copy elements
// CopyTo(dest, index)	    Copy to another array
// Clone()	    Shallow copy
// Clear(array, index, length)	    Reset values
// 🔹 3. Sorting / Reordering
// Method	Purpose
// Sort(array)	    Sort ascending
// Reverse(array)	Reverse order
// 🔹 4. Searching
// Method	Purpose
// IndexOf(array, value)	    First index
// LastIndexOf(array, value)	Last index
// BinarySearch(array, value)	Fast search (sorted)
// Find(array, predicate)	    First match
// FindIndex(array, predicate)	Index of match
// FindLast(array, predicate)	Last match
// FindAll(array, predicate)	All matches
// 🔹 5. Condition Checking
// Method	Purpose
// Exists(array, predicate)	    Exists or not
// TrueForAll(array, predicate)	All satisfy condition

using System;
using System.Data;
// class Program
// {
//     public static void Main(string[] args)
//     {

//         int[] arr = new int[6];
//         arr = [10,9,12,18,20,30];
//         //----------------------------------
//         Console.WriteLine($"Array value at index 3 : {arr.GetValue(3)}");
//         Console.WriteLine($"Array is Fixed Sized :  {arr.IsFixedSize}");
//         Console.WriteLine($"Array is ReadOnly : {arr.IsReadOnly}");
//         //----------------------------------
//         Array.Sort(arr);
//         Console.Write("Sorted Array is : ");
//         for(int i = 0; i < arr.Length; i++)
//         {
//             Console.Write(arr[i]+" ");
//         }
//         //-----------------------------------
//         Array.Reverse(arr);
//         Console.Write("\nReversed Array is : ");
//         for(int i = 0; i < arr.Length; i++)
//         {
//             Console.Write(arr[i]+" ");
//         }
//         //-----------------------------------
//         int[] copy = new int[arr.Length];
//         Array.Copy(arr,copy,arr.Length);
//         Console.Write("\nCopied Array is : ");
//         foreach(int i in copy)
//         {
//             Console.Write(i+" ");
//         }
//         //-----------------------------------
//         Console.WriteLine();
//         int index = Array.IndexOf(arr, 30);
//         Console.WriteLine($"30 is present at index: {index}");

//         //------------------------------------------
//         //Binary search (array must be sorted)
//         Array.Sort(arr);
//         int pos = Array.BinarySearch(arr,18);
//         Console.WriteLine($"18 is present at index: {pos}");

//         //-------------------------------------------
//         int[,] matrix = new int[2, 3];
//         Console.WriteLine($"Matrix Rank : {matrix.Rank}");          // 2
//         Console.WriteLine($"Number of row of matrix is : {matrix.GetLength(0)}");  // rows
//         Console.WriteLine($"Number of Columns of matrix is : {matrix.GetLength(1)}");  // columns


//     }
// }


//-----------------------
using System;

class Program
{
    public static void Main(string[] args)
    {
        Program program = new Program();

        // Creating Employee objects (same Id, different Names)
        Employee employee1 = new Employee { Id = 30, Name = "Rajesh" };
        Employee employee2 = new Employee { Id = 20, Name = "Suresh" };
        Employee employee3 = new Employee { Id = 10, Name = "Mahesh" };
        Employee employee4 = new Employee { Id = 50, Name = "Ganesh" };
        Employee employee5 = new Employee { Id = 40, Name = "Jayesh" };

        // Storing employees in array
        Employee[] employeeList = new Employee[5];
        employeeList[0] = employee1;
        employeeList[1] = employee2;
        employeeList[2] = employee3;
        employeeList[3] = employee4;
        employeeList[4] = employee5;

        Console.WriteLine("Before Sorting:");
        foreach (Employee e in employeeList)
        {
            Console.WriteLine(e);
        }

        // Sorting the array
        Array.Sort(employeeList);

        Console.WriteLine("\nAfter Sorting (Id same → sorted by Name):");
        foreach (Employee e in employeeList)
        {
            Console.WriteLine(e);
        }

        Console.WriteLine("\nPassing Single Object:");
        Employee emp = new Employee { Id = 90, Name = "Dinesh Ramdin" };
        program.PassObject(emp);

        Console.WriteLine("\nReturning Object from Method:");
        Employee returnedEmployee = program.ReturnObject();
        Console.WriteLine(returnedEmployee);

        Console.WriteLine("\nPassing Array to Method:");
        program.PassArrayObject(employeeList);
    }

    // Method to accept single object
    public void PassObject(Employee employee)
    {
        Console.WriteLine(employee);
    }

    // Method to return object
    public Employee ReturnObject()
    {
        Employee employee = new Employee
        {
            Id = 120,
            Name = "Suresh Raina"
        };
        return employee;
    }

    // Method to accept array of objects
    public void PassArrayObject(Employee[] employees)
    {
        foreach (Employee e in employees)
        {
            Console.WriteLine(e);
        }
    }
}

