using System.Collections;
using System.Data.Common;

class Program
{
    public static void Main(string[] args)
    {
        ArrayList list = new ArrayList();
        Employee employee1 = new Employee(){Id=10, Name="Rajesh"};
        Employee employee2 = new Employee(){Id=20, Name="Mahesh"};
        list.Add(10);
        list.Add(20);
        list.Add(30);
        list.Add(50);
        list.Add(40);
        list.Add(false);
        list.Add(employee1);
        list.Add(employee2);

        Console.WriteLine($"Count of Array list is : {list.Count}");

        foreach(var item in list)
        {
            Console.Write(item+" ");
        }

        ArrayList list1 = new ArrayList();
        list1.Add(80);
        list1.Add(60);
        list1.Add(70);
        list.AddRange(list1);
        Console.WriteLine("\n\n\n List After Adding Ranges ");
        foreach(var item in list)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine($"Count of Array is {list.Count}");

        if (list.Contains(50))
        {
            Console.WriteLine($"Object 50 is at index no : {list.IndexOf(50)}");
        }
        else
        {
            Console.WriteLine($"Object Not Found");
        }
        list.RemoveAt(5);
        list.RemoveRange(5,2);
        Console.WriteLine($"\nList Before Sorting the List: ");
        foreach(var item in list)
        {
            Console.Write(item+" ");
        }
        Console.WriteLine($"\nList After Sorting the List: ");
        list.Sort();
        foreach(var item in list)
        {
            Console.Write(item+" ");
        }
    }
}


// using System;
// using System.Collections;

// public class Program
// {
//     public static void Main()
//     {
//         Console.WriteLine("===== ARRAYLIST COMPLETE OPERATIONS =====\n");

//         // -------------------------------------------------
//         // 1. CREATE ARRAYLIST
//         // -------------------------------------------------
//         ArrayList list = new ArrayList();

//         // -------------------------------------------------
//         // 2. ADD ELEMENTS
//         // -------------------------------------------------
//         list.Add(10);
//         list.Add(20);
//         list.Add(30);
//         list.Add("Hello");   // ArrayList allows mixed types
//         list.Add(40.5);

//         Console.WriteLine("After Add:");
//         Print(list);

//         // -------------------------------------------------
//         // 3. INSERT ELEMENT
//         // -------------------------------------------------
//         list.Insert(2, 99);

//         Console.WriteLine("\nAfter Insert at index 2:");
//         Print(list);

//         // -------------------------------------------------
//         // 4. REMOVE ELEMENT
//         // -------------------------------------------------
//         list.Remove(20);  // Removes first occurrence

//         Console.WriteLine("\nAfter Remove (20):");
//         Print(list);

//         // -------------------------------------------------
//         // 5. REMOVE AT INDEX
//         // -------------------------------------------------
//         list.RemoveAt(1);

//         Console.WriteLine("\nAfter RemoveAt index 1:");
//         Print(list);

//         // -------------------------------------------------
//         // 6. COUNT
//         // -------------------------------------------------
//         Console.WriteLine("\nCount: " + list.Count);

//         // -------------------------------------------------
//         // 7. CONTAINS
//         // -------------------------------------------------
//         Console.WriteLine("Contains 30? " + list.Contains(30));

//         // -------------------------------------------------
//         // 8. INDEX OF
//         // -------------------------------------------------
//         Console.WriteLine("Index of 30: " + list.IndexOf(30));

//         // -------------------------------------------------
//         // 9. SORT (ONLY WORKS FOR SAME DATA TYPE)
//         // -------------------------------------------------
//         ArrayList numbers = new ArrayList();
//         numbers.Add(50);
//         numbers.Add(10);
//         numbers.Add(30);
//         numbers.Add(20);

//         numbers.Sort();

//         Console.WriteLine("\nSorted ArrayList:");
//         Print(numbers);

//         // -------------------------------------------------
//         // 10. REVERSE
//         // -------------------------------------------------
//         numbers.Reverse();

//         Console.WriteLine("\nReversed ArrayList:");
//         Print(numbers);

//         // -------------------------------------------------
//         // 11. COPY TO ARRAY
//         // -------------------------------------------------
//         object[] arr = new object[numbers.Count];
//         numbers.CopyTo(arr);

//         Console.WriteLine("\nCopied to Array:");
//         foreach (object o in arr)
//         {
//             Console.Write(o + " ");
//         }
//         Console.WriteLine();

//         // -------------------------------------------------
//         // 12. CLEAR
//         // -------------------------------------------------
//         numbers.Clear();
//         Console.WriteLine("\nAfter Clear, Count = " + numbers.Count);

//         // -------------------------------------------------
//         // 13. TRIM TO SIZE
//         // -------------------------------------------------
//         list.TrimToSize();
//         Console.WriteLine("\nTrimToSize executed.");

//         // -------------------------------------------------
//         // 14. ITERATION USING FOREACH
//         // -------------------------------------------------
//         Console.WriteLine("\nIterating using foreach:");
//         foreach (object item in list)
//         {
//             Console.WriteLine(item);
//         }

//         // -------------------------------------------------
//         // 15. ARRAYLIST PROPERTIES
//         // -------------------------------------------------
//         Console.WriteLine("\nIs Fixed Size? " + list.IsFixedSize);
//         Console.WriteLine("Is ReadOnly? " + list.IsReadOnly);
//         Console.WriteLine("Is Synchronized? " + list.IsSynchronized);
//     }

//     // Helper method to print ArrayList
//     static void Print(ArrayList list)
//     {
//         foreach (object item in list)
//         {
//             Console.Write(item + " ");
//         }
//         Console.WriteLine();
//     }
// }
