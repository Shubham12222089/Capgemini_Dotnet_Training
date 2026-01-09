// using System;
// using System.Runtime.CompilerServices;
// class BinaryWriteExample
// {
//     static void Main()
//     {
//         string filepath = "employee.dat";
//         using(FileStream fs = new FileStream(filepath, FileMode.Create))
//         using (BinaryWriter writer = new BinaryWriter(fs))
//         {
//             writer.Write(101);
//             writer.Write("Abc");
//             writer.Write(45000.75);
//             writer.Write(true);
//         }
//         Console.WriteLine("Binary file written successfully");
//     }
// }

