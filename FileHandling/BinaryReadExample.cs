// using System;
// using System.IO;

// class BinaryReadExample
// {
//     static void Main()
//     {
//         string filepath = "employee.dat";
//         using(FileStream fs = new FileStream(filepath,FileMode.Open))
//         using(BinaryReader binaryReader = new BinaryReader(fs))
//         {
//             int id = binaryReader.ReadInt32();
//             string name = binaryReader.ReadString();
//             double salary = binaryReader.ReadDouble();
//             bool isActive = binaryReader.ReadBoolean();

//             Console.WriteLine($"ID : {id}");
//             Console.WriteLine($"Name : {name}");
//             Console.WriteLine($"Salary : {salary}");
//             Console.WriteLine($"IsActive : {isActive}");
//         }
//     }
// }