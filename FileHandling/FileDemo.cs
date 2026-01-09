class FileDemo
{
    public void ReadTextFile()
    {
        FileStream fileStream = new FileStream(@"C:\Users\shubh\OneDrive\Desktop\.net\File\test.txt", FileMode.Open, FileAccess.Read);
        StreamReader streamReader = new StreamReader(fileStream);
        streamReader.BaseStream.Seek(0,SeekOrigin.Begin);
        string str = streamReader.ReadLine();
        while (str != null)
        {
            Console.WriteLine(str);
            str = streamReader.ReadLine();
        }
        streamReader.Close();
        fileStream.Close();
    }
}