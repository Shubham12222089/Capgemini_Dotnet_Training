using System;
using System.IO;
class FileInfoDemo
{
    public static void Main()
    {
        //string path = @"C:\Users\shubh\OneDrive\Desktop\.net\File\test2.txt";
        //using fileInfo
        // FileInfo fi = new FileInfo(path);
        // File.Create(path);
        // {
        //     Console.WriteLine("File Created Successfully");
        // }

        // string path2 = @"C:\Users\shubh\OneDrive\Desktop\.net\File\test3.txt";

        // FileStream fs = new FileStream(path2, FileMode.Create);
        // Console.WriteLine("File created successfully using FileStream");

        // fs.Close();

        //----------------------This method is used to delete in existing file.
        // FileInfo fi = new FileInfo(@"C:\Users\shubh\OneDrive\Desktop\.net\File\test2.txt");
        // fi.Delete();
        // Console.WriteLine("File has been deleted");

        //---------------The CopyTo method is used to copy an existing file into a new file
        //test3.txt should not exist , if it exist then it will throw the error.
        // string path = @"C:\Users\shubh\OneDrive\Desktop\.net\File\test2.txt";
        // string path2 = @"C:\Users\shubh\OneDrive\Desktop\.net\File\test3.txt";
        // FileInfo fi1 = new FileInfo(path);
        // FileInfo fi2 = new FileInfo(path2);
        // fi1.CopyTo(path2);
        // Console.WriteLine("{0} was Copied to {1}",path,path2);

        //-------The MoveTo method is used to move the content from one file to another file
        // string path = @"C:\Users\shubh\OneDrive\Desktop\.net\File\test2.txt";
        // string path2 = @"C:\Users\shubh\OneDrive\Desktop\.net\File\test4.txt";
        // FileInfo fi1 = new FileInfo(path);
        // FileInfo fi2 = new FileInfo(path2);
        // fi1.MoveTo(path2);
        // Console.WriteLine("{0} was Copied to {1}",path,path2);

        //-------This method creates a stremWriter that appends text to the file represented by this
        // FileInfo fi = new FileInfo(@"C:\Users\shubh\OneDrive\Desktop\.net\File\newFile1.txt");
        // StreamWriter sw = fi.AppendText();
        // sw.WriteLine("This");
        // sw.WriteLine("is Extra");
        // sw.WriteLine("Text");
        // Console.WriteLine("File has been appended");
        // sw.Close();

        //------This method creates a streamReader with UTF8 encoding that reads from existing text file
        // FileInfo fi = new FileInfo(@"C:\Users\shubh\OneDrive\Desktop\.net\File\newFile1.txt");
        // StreamReader sr = fi.OpenText();
        // string s = "";
        // while((s = sr.ReadLine()) != null)
        // {
        //     Console.WriteLine(s);
        // }

        //-------------------
        FileInfo fi = new FileInfo(@"C:\Users\shubh\OneDrive\Desktop\.net\File\newFile1.txt");
        Console.WriteLine($"File name is : {fi.Name}");
        Console.WriteLine($"File Creation Time is : {fi.CreationTime.ToLongTimeString()}");
        Console.WriteLine($"File LastAccess Time is : {fi.LastAccessTime.ToLongDateString()}");
        Console.WriteLine($"File length is : {fi.Length.ToString()}"+ " Bytes");
        Console.WriteLine($"File Extension is : {fi.Extension}");
        Console.WriteLine($"File Exist ? : {fi.Exists}");
    }

    

}