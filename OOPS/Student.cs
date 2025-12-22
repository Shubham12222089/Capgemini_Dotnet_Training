//why we use properties?
// Properties provide a flexible mechanism to read, write, or compute the values of private fields.
// They are special methods called accessors that are used to access private fields.
// Properties can be used as if they are public data members, but they actually include special methods

// // Using getters and setters (properties)
// class Student
// {
//     private int rollNumber;
//     private string name = string.Empty;

//     private int[] marks = new int[6];

//     //using getters and setters 
//     private int RollNumber
//     {
//         get { return rollNumber; }
//         set { rollNumber = value; }
//     }

//     private string Name
//     {
//         get { return name; }
//         set { name = value; }
//     }

//     private int Total
//     {
//         get
//         {
//             int sum = 0;
//             for(int i = 0; i < marks.Length; i++)
//             {
//                 sum += marks[i];
//             }
//             return sum;
//         }
//     }



//     public void AcceptDetails()
//     {
//         Console.WriteLine("Enter the Student Details: ");
//         Console.Write("Enter the Roll Number of Student: ");
//         rollNumber = Convert.ToInt32(Console.ReadLine());
//         Console.Write("Enter the Name of the Student: ");
//         name = Console.ReadLine() ?? string.Empty;
//         Console.WriteLine("Enter the marks of the Student ");
//         for(int i = 0; i < marks.Length; i++)
//         {
//             Console.Write($"Enter the marks of Subject {i+1} : ");
//             marks[i] = Convert.ToInt32(Console.ReadLine());
//         }
//     }

//     public void ShowDetails()
//     {
//         Console.WriteLine("Student Details: ");
//         Console.WriteLine($"Roll Number of Student: {rollNumber}");
//         Console.WriteLine($"Name of the Student: {name}");
//         for(int i = 0; i < marks.Length; i++)
//         {
//             Console.WriteLine($"Marks of Subject {i+1} : {marks[i]}");
//         }


//     }
//     public void Grade()
//     {
//         int average = Total / marks.Length;
//         if(average >= 90)
//         {
//             Console.WriteLine("Grade A");
//         }
//         else if (average >= 80)
//         {
//             Console.WriteLine("Grade B");
//         }
//         else if(average >= 70)
//         {
//             Console.WriteLine("Grade C");
//         }
//         else if(average >= 60)
//         {
//             Console.WriteLine("Grade D");
//         }
//         else
//         {
//             Console.WriteLine("Fail");
//         }
//     }
// }

using System;

class Student
{
    private int rollNumber;
    private string name = string.Empty;
    private int[] marks = new int[6];

    public int RollNumber
    {
        get { return rollNumber; }
        set
        {
            rollNumber = value;
        }
    }

    public string Name
    {
        get { return name; }
        set
        {
            name = value;
        }
    }

    public int Total
    {
        get
        {
            int sum = 0;
            for (int i = 0; i < marks.Length; i++)
            {
                sum += marks[i];
            }
            return sum;
        }
        set
        {
            
        }
    }

    // Accept student details
    public void AcceptDetails()
    {
        Console.Write("Enter Roll Number: ");
        RollNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Name: ");
        Name = Console.ReadLine() ?? string.Empty;

        for (int i = 0; i < marks.Length; i++)
        {
            Console.Write($"Enter marks of Subject {i + 1}: ");
            marks[i] = Convert.ToInt32(Console.ReadLine());
        }
    }

    // Display student details
    public void ShowDetails()
    {
        Console.WriteLine("\nStudent Details");
        Console.WriteLine($"Roll Number: {RollNumber}");
        Console.WriteLine($"Name: {Name}");

        for (int i = 0; i < marks.Length; i++)
        {
            Console.WriteLine($"Subject {i + 1} Marks: {marks[i]}");
        }

        Console.WriteLine($"Total Marks: {Total}");
        Console.WriteLine($"Grade: {GetGrade()}");
    }

    // Grade logic
    private string GetGrade()
    {
        int average = Total / marks.Length;

        if (average >= 90) return "Grade A";
        if (average >= 80) return "Grade B";
        if (average >= 70) return "Grade C";
        if (average >= 60) return "Grade D";
        return "Fail";
    }
}
