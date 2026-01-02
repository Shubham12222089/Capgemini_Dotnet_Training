using System;
using System.Text;

class Program
{
    static void Main()
    {
        // ===============================
        // 1. STRING CREATION
        // ===============================
        string s1 = "Hello";
        string s2 = "World";
        string s3 = String.Empty;
        string s4 = null;

        Console.WriteLine("String Creation:");
        Console.WriteLine(s1);
        Console.WriteLine(s2);

        // ===============================
        // 2. LENGTH & INDEXING
        // ===============================
        Console.WriteLine("\nLength & Indexing:");
        Console.WriteLine("Length of s1: " + s1.Length);
        Console.WriteLine("Character at index 1: " + s1[1]);

        // ===============================
        // 3. CONCATENATION
        // ===============================
        string concat1 = s1 + " " + s2;
        string concat2 = string.Concat(s1, " ", s2);

        Console.WriteLine("\nConcatenation:");
        Console.WriteLine(concat1);
        Console.WriteLine(concat2);

        // ===============================
        // 4. COMPARISON
        // ===============================
        Console.WriteLine("\nComparison:");
        Console.WriteLine(s1 == "hello");
        Console.WriteLine(s1.Equals("hello", StringComparison.OrdinalIgnoreCase));
        Console.WriteLine(string.Compare("A", "B"));

        // ===============================
        // 5. SEARCHING
        // ===============================
        string sentence = "Welcome to C Sharp Programming";

        Console.WriteLine("\nSearching:");
        Console.WriteLine(sentence.Contains("C Sharp"));
        Console.WriteLine(sentence.StartsWith("Welcome"));
        Console.WriteLine(sentence.EndsWith("Programming"));
        Console.WriteLine(sentence.IndexOf("to"));
        Console.WriteLine(sentence.LastIndexOf("o"));

        // ===============================
        // 6. SUBSTRING
        // ===============================
        Console.WriteLine("\nSubstring:");
        Console.WriteLine(sentence.Substring(0, 7));
        Console.WriteLine(sentence.Substring(11));

        // ===============================
        // 7. REPLACE & REMOVE
        // ===============================
        Console.WriteLine("\nReplace & Remove:");
        Console.WriteLine(sentence.Replace("C Sharp", "C#"));
        Console.WriteLine(sentence.Remove(11));
        Console.WriteLine(sentence.Remove(11, 7));

        // ===============================
        // 8. CASE CONVERSION
        // ===============================
        Console.WriteLine("\nCase Conversion:");
        Console.WriteLine(sentence.ToUpper());
        Console.WriteLine(sentence.ToLower());

        // ===============================
        // 9. TRIM
        // ===============================
        string spaced = "   Hello World   ";
        Console.WriteLine("\nTrim:");
        Console.WriteLine(spaced.Trim());
        Console.WriteLine(spaced.TrimStart());
        Console.WriteLine(spaced.TrimEnd());

        // ===============================
        // 10. SPLIT & JOIN
        // ===============================
        Console.WriteLine("\nSplit & Join:");
        string csv = "A,B,C,D";
        string[] parts = csv.Split(',');
        foreach (string part in parts)
        {
            Console.WriteLine(part);
        }
        Console.WriteLine(string.Join("-", parts));

        // ===============================
        // 11. CONVERSION
        // ===============================
        Console.WriteLine("\nConversion:");
        int num = int.Parse("100");
        int num2;
        int.TryParse("200", out num2);
        string numStr = num.ToString();
        Console.WriteLine(num + " " + num2 + " " + numStr);

        // ===============================
        // 12. STRING FORMATTING
        // ===============================
        Console.WriteLine("\nFormatting:");
        string format1 = string.Format("Name: {0}, Age: {1}", "Raj", 25);
        string format2 = $"Name: {"Raj"}, Age: {25}";
        Console.WriteLine(format1);
        Console.WriteLine(format2);

        // ===============================
        // 13. NULL / EMPTY CHECK
        // ===============================
        Console.WriteLine("\nNull / Empty Check:");
        Console.WriteLine(string.IsNullOrEmpty(s3));
        Console.WriteLine(string.IsNullOrWhiteSpace("   "));

        // ===============================
        // 14. CHARACTER OPERATIONS
        // ===============================
        Console.WriteLine("\nCharacter Operations:");
        Console.WriteLine(char.IsDigit('5'));
        Console.WriteLine(char.IsLetter('A'));
        Console.WriteLine(char.IsUpper('A'));
        Console.WriteLine(char.ToLower('Z'));

        // ===============================
        // 15. STRINGBUILDER (MUTABLE STRING)
        // ===============================
        Console.WriteLine("\nStringBuilder:");
        StringBuilder sb = new StringBuilder("Hello");
        sb.Append(" World");
        sb.Insert(5, ",");
        sb.Replace("World", "C#");
        sb.Remove(5, 1);
        Console.WriteLine(sb.ToString());

        // ===============================
        // 16. STRING REVERSE (COMMON PROGRAM)
        // ===============================
        Console.WriteLine("\nReverse String:");
        string original = "ABCDE";
        char[] arr = original.ToCharArray();
        Array.Reverse(arr);
        string reversed = new string(arr);
        Console.WriteLine(reversed);

        // ===============================
        // 17. STRING INTERNING
        // ===============================
        Console.WriteLine("\nString Interning:");
        string a = "Hello";
        string b = "Hello";
        Console.WriteLine(object.ReferenceEquals(a, b));

        // ===============================
        // 18. ESCAPE & VERBATIM
        // ===============================
        Console.WriteLine("\nEscape & Verbatim:");
        Console.WriteLine("Hello\nWorld");
        Console.WriteLine(@"C:\Users\Admin\Documents");
    }
}


// class Program
// {
//     public static void Main(string[] args)
//     {
//         string fname, lname;
//         fname="Roman";
//         lname = "Reigns";

//         char[] letters = ['H','e','l','l','o'];
//         string[] sarray = ["Abc","cde","fgh","ijk","mno"];

//         string greetings = new string(letters);
//         Console.WriteLine("Greeting : {0}",greetings);

//         string message = string.Join(" ",sarray);
//         Console.WriteLine("Message : {0}",message);

//         DateTime waiting = new DateTime(2012,10,10,17,58,1);
//         string chat = String.Format("Message Sent at : {0:t} on {0:D}",waiting);
//         Console.WriteLine("Message : {0}",chat);

//         string str1= "This is test";
//         string str2="This is test";
//         Console.WriteLine(str1.IndexOf("tes"));
//         if (string.Compare(str1, str2) == 0)
//         {
//             Console.WriteLine(str1 + " and "+ str2 + " are equal.");
//         }
//         else
//         {
//             Console.WriteLine(str1 + " and "+ str2 + " are not equal.");
//         }

//         if (str1.Contains("test"))
//         {
//             Console.WriteLine("The sequence 'test' was found.");
//         }
        
//         string str3 = "Last night I dreamt of San Pedro";
//         Console.WriteLine(str3);
//         string substr=str3.Substring(23);
//         Console.WriteLine(substr);

//         Console.WriteLine("Hello\nWorld");
//         Console.WriteLine("\"Hello World\"");
//         Console.WriteLine("D:\\Projects\\csharp\\Program.cs");
//         Console.WriteLine(@"D:\Projects\csharp\Program.cs");

//         var message1 = @"Hello Alice,
//                     Good Morining!
                        
//                     Your File has been Saved to this location.
//                     \shared\Alice
//                     Thanks.";
//         Console.WriteLine(message1);


//     }
// }