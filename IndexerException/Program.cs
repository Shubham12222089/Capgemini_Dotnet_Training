using System;
class Program
{
    public static void Main(string[] args)
    {
        Employee emp = new Employee();
        emp[0] = "String 1";
        emp[1] = "String 2";
        emp[2] = "String 3";
        emp[3] = "String 4";
        emp[4] = "String 5";

        for(int i = 0; i < 5; i++)
        {
            Console.WriteLine(emp[i]);
        }
        Console.WriteLine($"Value at Third Index is {emp[3]}");
        Console.WriteLine($"Value String 4 is at Index {emp["String 4"]}");

    }
}