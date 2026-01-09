using System;
using System.IO;
class FileInfoDemo
{
    public static void Main()
    {
        string path = @"C:\Users\shubh\OneDrive\Desktop\.net\File\test2.txt";
        //using fileInfo
        FileInfo fi = new FileInfo(path);
        File.Create(path);
        {
            Console.WriteLine("File Created Successfully");
        }
        
    }
}