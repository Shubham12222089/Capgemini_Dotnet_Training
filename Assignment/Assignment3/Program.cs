using System;

class Program
{
    public static void Main(string[] args)
    {
        // Console.WriteLine("=========Assignment 1=============");
        // Student defaultStudent = new Student();
        // Console.WriteLine("Default Student:");
        // Console.WriteLine("Name: " + defaultStudent.Name);
        // Console.WriteLine("Age: " + defaultStudent.Age);
        // Console.WriteLine("Grade: " + defaultStudent.Grade);

        // Student student1 = new Student("Xyz", 20, "A");
        // Console.WriteLine("Parameterized Student:");
        // Console.WriteLine("Name: " + student1.Name);
        // Console.WriteLine("Age: " + student1.Age);
        // Console.WriteLine("Grade: " + student1.Grade);

        // Console.WriteLine("=========Assignment 2=============");
        // Console.Write("Enter the Car's Make: ");
        // string make=Console.ReadLine();
        // Console.Write("Enter the Car's Model: ");
        // string model=Console.ReadLine();
        // Console.Write("Enter the Car's Year: ");
        // int year = Convert.ToInt32(Console.ReadLine());

        // Car car = new Car(make,model,year);
        // car.DisplayDetails();
        // car.DisplayAge();

        // Console.WriteLine("=========Assignment 3=============");
        // Person p = new Person();
        // Console.Write("Enter the Person's Name: ");
        // p.Name = Console.ReadLine();
        // Console.Write("Enter the Person's Age: ");
        // p.Age = Convert.ToInt32(Console.ReadLine());
        // Console.Write("Enter the Person's Address: ");
        // p.Address = Console.ReadLine();

        // Console.WriteLine("Person's Information:");
        // Console.WriteLine($"Name: {p.Name}");
        // Console.WriteLine($"Age: {p.Age}");
        // Console.WriteLine($"Address: {p.Address}");


        Console.WriteLine("=========Assignment 4=============");
        Console.Write("Enter the String Input: ");
        string input = Console.ReadLine();
        Console.Write("Enter the Choice (1/2/3): ");
        int choice = Convert.ToInt32(Console.ReadLine());

        StringConverter converter = new StringConverter();

        if (choice == 1)
        {
            Console.WriteLine(converter.ConvertString(input));
        }
        else if (choice == 2)
        {
            Console.WriteLine(converter.ConvertString(input, true));
        }
        else if (choice == 3)
        {
            Console.WriteLine(converter.ConvertString(input, 1));
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }


    }
}
class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Grade { get; set; }

    public Student()
    {
        Name = "Abc";
        Age = 21;
        Grade = "C";
    }
    public Student(string name,int age,string grade)
    {
        this.Name=name;
        this.Age=age;
        this.Grade=grade;
    }
}

class Car
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }

    public Car(string make,string model,int year)
    {
        this.Make=make;
        this.Model=model;
        this.Year=year;
    }
    public void DisplayDetails()
    {
        Console.WriteLine("Car Details:");
        Console.WriteLine($"Make: {Make}");
        Console.WriteLine($"Model: {Model}");
        Console.WriteLine($"Year: {Year}");
    }
    public void DisplayAge()
    {
        int age = 2025-Year;
        Console.WriteLine($"Car Age: {age} years");
    }
}

class Person
{
    private string name;
    private int age;
    private string address;
    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            name=value;
        }
    }
    public int Age
    {
        get
        {
            return age;
        }
        set
        {
            age=value;
        }
    }
    public string Address
    {
        get
        {
            return address;
        }
        set
        {
            address=value;
        }
    }

}

public class StringConverter
{
    public string ConvertString(string input)
    {
        return input.ToUpper();
    }
    public string ConvertString(string input,bool toLower)
    {
        return input.ToLower();
    }
    public string ConvertString(string input,int toTitleCase)
    {
        string[] word = input.ToLower().Split(' ');
        for(int i = 0; i < word.Length; i++)
        {
            if (word[i].Length > 0)
            {
                word[i] = char.ToUpper(word[i][0]) + word[i].Substring(1);
            }
        }
        return string.Join(" ", word);
    }
}