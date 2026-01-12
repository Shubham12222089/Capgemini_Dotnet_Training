using System;
using System.Text.Json;
using System.Xml.Serialization;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
}

class Program
{
    static void Main()
    {
        Student s = new Student { Id = 1, Name = "Shubham" };

        string json = JsonSerializer.Serialize(s);
        
        Console.WriteLine(json);

        Student s1 = new Student { Id = 2, Name = "Rahul" };

        XmlSerializer xml = new XmlSerializer(typeof(Student));
        using FileStream fs = new FileStream("student.xml", FileMode.Create);
        xml.Serialize(fs, s1);

        Console.WriteLine("XML Serialized");
    }
}
