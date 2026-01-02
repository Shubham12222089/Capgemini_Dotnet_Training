// using System;
// using System.Text;

// public class Program
// {
//     public static void Main()
//     {
//         Console.WriteLine("===== STRING vs STRINGBUILDER =====");

//         // -------------------------------------------------
//         // 1. STRING (IMMUTABLE)
//         // -------------------------------------------------
//         string s = "Hello";
//         s += " World";   // Creates a NEW object in memory

//         Console.WriteLine("String Result: " + s);

//         // -------------------------------------------------
//         // 2. STRINGBUILDER (MUTABLE)
//         // -------------------------------------------------
//         StringBuilder sb = new StringBuilder("Hello");

//         sb.Append(" World");   // Modifies SAME object
//         Console.WriteLine("StringBuilder Result: " + sb);

//         // -------------------------------------------------
//         // 3. APPEND
//         // -------------------------------------------------
//         sb.Append("!");
//         Console.WriteLine("After Append: " + sb);

//         // -------------------------------------------------
//         // 4. INSERT
//         // -------------------------------------------------
//         sb.Insert(5, ",");
//         Console.WriteLine("After Insert: " + sb);

//         // -------------------------------------------------
//         // 5. REMOVE
//         // -------------------------------------------------
//         sb.Remove(5, 1); // remove comma
//         Console.WriteLine("After Remove: " + sb);

//         // -------------------------------------------------
//         // 6. REPLACE
//         // -------------------------------------------------
//         sb.Replace("World", "C#");
//         Console.WriteLine("After Replace: " + sb);

//         // -------------------------------------------------
//         // 7. CLEAR
//         // -------------------------------------------------
//         sb.Clear();
//         Console.WriteLine("After Clear: '" + sb + "'");

//         // -------------------------------------------------
//         // 8. CAPACITY & LENGTH
//         // -------------------------------------------------
//         StringBuilder sb2 = new StringBuilder("Hello");

//         Console.WriteLine("Length: " + sb2.Length);
//         Console.WriteLine("Capacity: " + sb2.Capacity);

//         sb2.Append(" Welcome to StringBuilder");
//         Console.WriteLine("Updated String: " + sb2);
//         Console.WriteLine("Updated Length: " + sb2.Length);
//         Console.WriteLine("Updated Capacity: " + sb2.Capacity);

//         // -------------------------------------------------
//         // 9. APPENDFORMAT
//         // -------------------------------------------------
//         StringBuilder sb3 = new StringBuilder();
//         sb3.AppendFormat("Name: {0}, Age: {1}", "Raj", 25);
//         Console.WriteLine("AppendFormat: " + sb3);

//         // -------------------------------------------------
//         // 10. TOSTRING (CONVERT TO STRING)
//         // -------------------------------------------------
//         string finalString = sb3.ToString();
//         Console.WriteLine("Converted to String: " + finalString);

//         // -------------------------------------------------
//         // 11. STRINGBUILDER IN LOOP (BEST USE CASE)
//         // -------------------------------------------------
//         StringBuilder sbLoop = new StringBuilder();

//         for (int i = 1; i <= 5; i++)
//         {
//             sbLoop.Append(i);
//             sbLoop.Append(" ");
//         }

//         Console.WriteLine("Loop Result: " + sbLoop);

//         // -------------------------------------------------
//         // 12. STRINGBUILDER INDEX ACCESS
//         // -------------------------------------------------
//         sbLoop[0] = 'X';   // Modify character directly
//         Console.WriteLine("After Index Change: " + sbLoop);

//         // -------------------------------------------------
//         // 13. STRINGBUILDER VS STRING (PERFORMANCE IDEA)
//         // -------------------------------------------------
//         Console.WriteLine("\nUse StringBuilder when:");
//         Console.WriteLine("- Frequent concatenation");
//         Console.WriteLine("- Inside loops");
//         Console.WriteLine("- Large text manipulation");
//     }
// }


using System;
using System.Globalization;
using System.Text;
class Program
{
    public static void Main(string[] args)
    {
        StringBuilder str = new StringBuilder("Hello World");
        // for(int i = 0; i < str.Length; i++)
        // {
        //     Console.Write(str[i]);
        // }

        // StringBuilder sb = new StringBuilder();
        // sb.AppendLine("World!");
        // sb.Append("Hello ");
        // sb.AppendLine("World");
        // sb.AppendLine("Hello CS");
        // Console.Write(sb);

        StringBuilder sbAmount = new StringBuilder();
        sbAmount.AppendFormat("{0:C} ",25);

        CultureInfo India = new CultureInfo("en-IN");
        sbAmount.AppendFormat(India,"{0:C}",12345678);

        Console.WriteLine(sbAmount);

        //insert
        // StringBuilder sb = new StringBuilder("Hello World");
        
        // sb.Insert(5,"C#");
        // Console.WriteLine(sb);

        // StringBuilder sb = new StringBuilder("Hello World",50);
        // sb.Remove(6,6);
        // Console.WriteLine(sb);

    }
}