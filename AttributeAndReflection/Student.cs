using System;
public class Student
{
    public int RollNo{get;set;}
    public string Name{get;set;}
    public Student()
    {
        RollNo = 0;
        Name = string.Empty;
    }

    public Student(int rno,string n)
    {
        RollNo =rno;
        Name = n;
    }
    public void Display(){
        Console.WriteLine($"Roll Number : {RollNo}");
        Console.WriteLine($"Name: {Name}");
    }
}