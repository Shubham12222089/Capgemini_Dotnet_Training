// See https://aka.ms/new-console-template for more information
using System;
using DemoApp1;



// class Program
// {
//     static void Main()
//     {
//         Employee emp = new Employee();
//         emp.ShowInfo();
//     }
// }

// using MyConsoleApp;
// class Program
// {
//     public static void Main()
//     {
//         int num1;
//         int num2;
//         Console.WriteLine("Enter first number:");
//         num1 = Convert.ToInt32(Console.ReadLine());
//         Console.WriteLine("Enter second number:");
//         num2 = Convert.ToInt32(Console.ReadLine());
//         Calculator calc= new Calculator(num1, num2);
//         Console.WriteLine("1. Addition\n2. Subtraction\n3. Multiplication\n4. Division");
//         Console.WriteLine("Choose an operation (1-4):");
//         int choice = Convert.ToInt32(Console.ReadLine());
//         if(choice <1 || choice >4)
//         {
//             Console.WriteLine("Invalid choice");
//             return;
//         }
//         else 
//         {
//             switch(choice)
//             {
//                 case 1:
//                     Console.WriteLine("Result: " + calc.Add());
//                     break;
//                 case 2:
//                     Console.WriteLine("Result: " + calc.Subtract());
//                     break;
//                 case 3:
//                     Console.WriteLine("Result: " + calc.Multiply());
//                     break;
//                 case 4:
//                     Console.WriteLine("Result: " + calc.Divide());
//                     break;
//             }
//         }
//     }
// }

//printing 1 to 10 using while loop
// class Program
// {
//     public static void Main()
//     {
//         int  i=1;
//         while(i<=10)
//         {
//             Console.Write($"Number is {i}\n");
//             i++;
//         }
//         int j=10;
//         while(j>=1)
//         {
//             Console.Write($"Number is {j}\n");
//             j--;
//         }
//     }
// }

//Do while Loop
// class Program
// {
//     public static void Main()
//     {
//         int i=1;
//         do
//         {
//             Console.WriteLine($"Number is {i}");
//             i++;
//         } while(i<=10);
//     }
// }


//For Loop
// class Program
// {
//     public static void Main()
//     {
//         for(int i = 1; i <= 10; i++)
//         {
//             Console.WriteLine($"Number is {i}");
//         }
//         for(int j = 10; j >= 1; j--)
//         {
//             Console.WriteLine($"Number is {j}");
//         }
//     }
// }

//Foreach Loop
// class Program
// {
//     public static void Main()
//     {
//         int[] arr = {1,2,3,4,5,6,7,8,9,10};
//         Console.WriteLine("Using for Foreach Loop");
//         foreach(int num in arr)
//         {
//             Console.WriteLine($"Number is : {num}");
//         }
//         Console.WriteLine("Using for Loop");
//         for(int i=0;i<arr.Length;i++)
//         {
//             if(arr[i]%2==0)
//             {
//                 Console.WriteLine($"{arr[i]} is Even");
//             }
//             else
//             {
//                 Console.WriteLine($"{arr[i]} is Odd");
//             }
//         }
//         Console.WriteLine("Using for While Loop");
//         int j=0;
//         while(j<arr.Length)
//         {
//             if(arr[j]%2==0)
//             {
//                 Console.WriteLine($"{arr[j]} is Even");
//             }
//             else
//             {
//                 Console.WriteLine($"{arr[j]} is Odd");
//             }
//             j++;
//         }
//     }
// }


// 1)Sample C# program to print a welcome message
// 2)Write C# program to read a number user and display it */
// 3)Write C# program to read a floating point number from user 
// 4)Write C# program to read a string from user and display 
// it on the screen 
// 5)Write C# program to perform all arithmetic operations*/
// 6)Write C# program to find the area of circle */
// 7) program to find whether the given number is Even or Odd */
// 8)program to find the greatest of 2 numbers */
// 9) program to find whether a given number is positive ,negative or zero*/
// 10 program to find the greatest of three numbers using nested if*/ 

//------------------------------------------------------------------------------
// class Program
// {
//     public static void Main()
//     {
//         Console.WriteLine("Welcome to C# Programming!");
//         Console.Write("Enter an integer number: ");
//         int number = Convert.ToInt32(Console.ReadLine());
//         Console.WriteLine($"Entered number is: {number}");
//         float floatNumber;
//         Console.Write("Enter a floating point number: ");
//         floatNumber = float.Parse(Console.ReadLine());
//         Console.WriteLine($"Entered floating point number is: {floatNumber}");
//         arithmeticOperations();
//         AreaOfCircle();
//         EvenOrOdd();
//         GreatestOfTwoNumbers();
//         PositiveNegativeOrZero();
//         GreatestOfThreeNumbers();

//     }
//     public static void arithmeticOperations()
//     {
//         Console.Write("Enter the firt Number: ");
//         int num1=Convert.ToInt32(Console.ReadLine());
//         Console.Write("Enter the second Number: ");
//         int num2=Convert.ToInt32(Console.ReadLine());
//         Console.WriteLine($"Addition: {num1+num2}");
//         Console.WriteLine($"Subtraction: {num1-num2}");
//         Console.WriteLine($"Multiplication: {num1*num2}");
//     }
//     public static void AreaOfCircle()
//     {
//         Console.Write("Enter the radius of the circle: ");
//         double radius = Convert.ToDouble(Console.ReadLine());
//         double area = 3.14 * radius * radius;
//         Console.WriteLine($"Area of the circle is: {area}");
//     }
//     public static void EvenOrOdd()
//     {
//         Console.Write("Enter the Number: ");
//         int num = Convert.ToInt32(Console.ReadLine());
//         if(num%2==0)
//         {
//             Console.WriteLine($"{num} is Even");
//         }
//         else
//         {
//             Console.WriteLine($"{num} is Odd");
//         }
    
//     }

//     public static void GreatestOfTwoNumbers()
//     {
//         Console.Write("Enter the first Number: ");
//         int num1 = Convert.ToInt32(Console.ReadLine());
//         Console.Write("Enter the second Number: ");
//         int num2 = Convert.ToInt32(Console.ReadLine());
//         if(num1>num2)
//         {
//             Console.WriteLine($"{num1} is Greater");
//         }
//         else if(num2>num1)
//         {
//             Console.WriteLine($"{num2} is Greater");
//         }
//         else
//         {
//             Console.WriteLine("Both numbers are equal");
//         }
//     }

//     public static void PositiveNegativeOrZero()
//     {
//         Console.Write("Enter the Number: ");
//         int num = Convert.ToInt32(Console.ReadLine());
//         if(num>0)
//         {
//             Console.WriteLine($"{num} is Positive");
//         }
//         else if(num<0)
//         {
//             Console.WriteLine($"{num} is Negative");
//         }
//         else
//         {
//             Console.WriteLine("The number is Zero");
//         }
//     }

//     public static void GreatestOfThreeNumbers()
//     {
//         Console.Write("Enter the first Number: ");
//         int num1 = Convert.ToInt32(Console.ReadLine());
//         Console.Write("Enter the second Number: ");
//         int num2 = Convert.ToInt32(Console.ReadLine());
//         Console.Write("Enter the third Number: ");
//         int num3 = Convert.ToInt32(Console.ReadLine());
//         if(num1>=num2 && num1>=num3)
//         {
//             Console.WriteLine($"{num1} is Greatest");
//         }
//         else if(num2>=num1 && num2>=num3)
//         {
//             Console.WriteLine($"{num2} is Greatest");
//         }
//         else
//         {
//             Console.WriteLine($"{num3} is Greatest");
//         }
//     }

// }

//------------------------------------------------------------------------------
// 17)Write C#  program to print numbers from 1 to n(user input) 
// using while loop*/
// 18)Write C#  program to print even numbers from 1 to n(user input) 
// 19)Write C#  program to find the sum  of numbers from 1 to n
// (user input) 
// using while loop*/

// 20)Write C#  program to print multiplication table of 
// given number */

// 21) Write C#  program to calculate the power of a given number */

// 22)Write C#  program to generate fibbonacci 
// series(0 1 1 2 3 5 8 13 21 34 55...)
// upto n(user input)*/

// 23)Write C#  program to find whether the given number is Armstrong or
//  not


// 24)program to print armstrong numbers from n1 to n2


// 25) program to check whether the number is prime or 
// not */

/*12) program to read student num,name,mark of six subject and 
calculate total and average and print result and division */

/*13)program to read eno,ename,basic salary and calculate  
pf,hra,da,net salary and gross salary and print eno,ename,basic 
salary,
gross salary and net salary*/

// 26)program to print numbers from 1 to 5(R to L)

//    1
//    12
//    123
//    1234
//    12345

// 27)
// program to print the output as following 

//      *
//     **
//    *
//   **
//  ***

// */

// 28)program to read student details (no, name,marks)using do 
// while loop by accepting details till user enter y as an 
// input */

//29) C# Program to Print Odd Numbers in a Given Range

//31 C# Program to Print All the Multiples of 17 which are Less than 100
//Write the source code of the C# Program to Print all the Multiples of 17 which are Less than 100. The C# program should successfully compiled and executed with Microsoft Visual

//==================================================================
// 32) Sum of Digits Program in C#
//Write the  source code of the C# Program to Get a Number and Display the Sum of the Digits.


class Program
{
    public static void Main()
    {
        int n;
        Console.Write("Enter the value of n: ");
        n = Convert.ToInt32(Console.ReadLine());
        for(int i=1;i<=n;i++)
        {
            Console.WriteLine($"Number is : {i}");
        }
        Console.WriteLine("===================================================");
        Console.WriteLine("Even Number Upto N");
        EvenNumbersUptoN();
        Console.WriteLine("===================================================");
        Console.WriteLine("Sum of the Numbers Upto N");
        SumOfNumbersUptoN();
        Console.WriteLine("===================================================");
        Console.WriteLine("Multiplication Table");
        MultiplicationTable();
        Console.WriteLine("===================================================");
        Console.WriteLine("Power of Number");
        PoweOfNumber();
        Console.WriteLine("===================================================");
        Console.WriteLine("Fibbonacci Series");
        FibbonacciSeries();
        Console.WriteLine("===================================================");
        Console.WriteLine("Armstrong Number");
        ArmstrongNumber();
        Console.WriteLine("===================================================");
        Console.WriteLine("Prime Number");
        PrimeOrNot();
        Console.WriteLine("===================================================");
        Console.WriteLine("Armstrong Numbers in a Range");
        PrintArmstrongNumbersInRange();
        Console.WriteLine("===================================================");
        Console.WriteLine("Student Result");
        StudentResult();
        Console.WriteLine("===================================================");
        Console.WriteLine("Salary Details");
        Salary sal = new Salary();
        sal.salaryDetails();
        Console.WriteLine("===================================================");
        Console.WriteLine("Student Details using Do While Loop");
        StudentDetailsDoWhile();
        Console.WriteLine("===================================================");
        Console.WriteLine("Multiples of 17 less than 100");
        MultipleOf17();
        Console.WriteLine("===================================================");
        Console.WriteLine("Sum of Digits");
        SumofDigits();

    }
    public static void EvenNumbersUptoN()
    {
        int n;
        Console.Write("Enter the value of n: ");
        n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Even numbers from 1 to {n} are:");
        for(int i=1;i<=n;i++)
        {
            if(i%2==0)
            {
                Console.WriteLine(i);
            }
        }
    }

    public static void SumOfNumbersUptoN()
    {
        int n;
        Console.Write("Enter the value of n: ");
        n = Convert.ToInt32(Console.ReadLine());
        int sum=0;
        for(int i=1;i<=n;i++)
        {
            sum+=i;
        }
        Console.WriteLine($"Sum of numbers from 1 to {n} is: {sum}");
    }

    public static void MultiplicationTable()
    {
        int num;
        Console.Write("Enter the number : ");
        num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Multiplication table of {num} is:");
        for(int i=1;i<=10;i++)
        {
            Console.WriteLine($"{num} x {i} = {num*i}");
        }
    }

    public static void PoweOfNumber()
    {
        int baseNum, exp;
        Console.Write("Enter the base number: ");
        baseNum = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the exponent: ");
        exp = Convert.ToInt32(Console.ReadLine());
        int result = 1;
        for(int i=1;i<=exp;i++)
        {
            result *= baseNum;
        }
        Console.WriteLine($"Result is : {result}");
    }

    public static void FibbonacciSeries()
    {
        int a=0;
        int b=1;
        int n;
        Console.Write("Enter the Number till you want to generate Fibbonacci series: ");
        n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Fibbonacci Series: ");
        for(int i=1;i<=n;i++)
        {
            Console.WriteLine(a);
            int next = a + b;
            a = b;
            b = next;
        }
    }

    public static void ArmstrongNumber()
    {
        int num;
        int sum, temp, remainder, digits=0;
        Console.Write("Enter the Number: ");
        num = Convert.ToInt32(Console.ReadLine());
        temp = num;
        while(temp!=0)
        {
            digits++;
            temp /= 10;
        }
        temp = num;
        sum = 0;
        while(temp!=0)
        {
            remainder = temp % 10;
            sum += (int)Math.Pow(remainder, digits);
            temp /= 10;
        }
        if(sum == num)
        {
            Console.WriteLine($"{num} is an Armstrong Number");
        }
        else
        {
            Console.WriteLine($"{num} is not an Armstrong Number");
        }
    }

    public static void PrimeOrNot()
    {
        int n;
        Console.Write("Enter the Number: ");
        n = Convert.ToInt32(Console.ReadLine());
        bool isPrime = true;
        if (n <= 1)
        {
            isPrime=false;
        }
        else
        {
            for(int i=2; i <= Math.Sqrt(n);i++)
            {
                if(n%i==0)
                {
                    isPrime=false;
                    break;
                }
            }
        }
        if(isPrime)
        {
            Console.WriteLine($"{n} is a Prime Number");
        }
        else
        {
            Console.WriteLine($"{n} is not a Prime Number");
        }
    }

    public static void PrintArmstrongNumbersInRange()
    {
        int n1, n2;
        Console.Write("Enter the starting number of the range: ");
        n1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the ending number of the range: ");
        n2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Armstrong numbers between {n1} and {n2} are:");
        for(int num=n1; num<=n2; num++)
        {
            int sum=0, temp=num, digits=0, remainder;
            while(temp!=0)
            {
                digits++;
                temp /= 10;
            }
            temp = num;
            while(temp!=0)
            {
                remainder = temp % 10;
                sum += (int)Math.Pow(remainder, digits);
                temp /= 10;
            }
            if(sum == num)
            {
                Console.WriteLine(num);
            }
        }
    }
    public static void StudentResult()
    {
        string name;
        int num;
        int[] marks = new int[6];
        Console.Write("Enter the Student Name : ");
        name = Console.ReadLine();
        for(int i=0;i<marks.Length;i++)
        {
            Console.Write($"Enter the marks of Subject {i+1}: ");
            marks[i] = Convert.ToInt32(Console.ReadLine());
        }
        int total = 0;
        for(int i=0;i<marks.Length;i++)
        {
            total += marks[i];
        }
        double average = total / marks.Length;
        Console.WriteLine($"Total Marks: {total}");
        Console.WriteLine($"Average Marks: {average}");
        if(average >= 60)
        {
            Console.WriteLine("Division: First");
        }
        else if(average >= 50)
        {
            Console.WriteLine("Division: Second");
        }
        else if(average >= 40)
        {
            Console.WriteLine("Division: Third");
        }
        else
        {
            Console.WriteLine("Result: Fail");
        }
    }

    // public static void PatterRightToLeft()
    // {
    //     int n;
    //     Console.Write("Enter the number: ");
    //     n = Convert.ToInt32(Console.ReadLine());

    //     for (int i = 1; i <= n; i++)
    //     {
	// 		int t=1;
    //         for (int j = 1; j <= i; j++)
    //         {
    //             Console.Write(t);
	// 			t++;
    //         }
    //         Console.WriteLine();
    //     }

    // }

    public static void StudentDetailsDoWhile()
    {
        string choice;
        do
        {
            int eno;
            string ename;
            int[] marks = new int[3];
            Console.Write("Enter Employee Number: ");
            eno = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Employee Name: ");
            ename = Console.ReadLine();
            for(int i=0;i<marks.Length;i++)
            {
                Console.Write($"Enter the marks of Subject {i+1}: ");
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }
            int total = 0;
            for(int i=0;i<marks.Length;i++)
            {
                total += marks[i];
            }
            double average = total / marks.Length;
            Console.WriteLine($"Employee Number: {eno}");
            Console.WriteLine($"Employee Name: {ename}");
            Console.WriteLine($"Total Marks: {total}");
            Console.WriteLine($"Average Marks: {average}");
            Console.Write("Do you want to enter details for another employee? (y/n): ");
            choice = Console.ReadLine();
        } while(choice.ToLower() == "y");
    }

    public static void MultipleOf17()
    {
        for(int i=17;i<100;i++)
        {
            if(i%17==0)
            {
                Console.WriteLine(i);
            }
        }
    }

    public static void SumofDigits()
    {
        int n;
        Console.Write("Enter the Number: ");
        n = Convert.ToInt32(Console.ReadLine());
        int sum=0;
        while(n!=0)
        {
            sum+=n%10;
            n/=10;
        }
        Console.WriteLine($"Sum of Digits is: {sum}");
    }

    
}
class Salary
{
    public void salaryDetails()
    {
        int eno;
        string ename;
        int salary;
        Console.Write("Enter Employee Number: ");
        eno = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Employee Name: ");
        ename = Console.ReadLine();
        Console.Write("Enter Basic Salary: ");
        salary = Convert.ToInt32(Console.ReadLine());
        double pf = salary * 0.12;
        double hra = salary * 0.20;
        double da = salary * 0.10;
        double grossSalary = salary + hra + da;
        double netSalary = grossSalary - pf;
        Console.WriteLine($"Employee Number: {eno}");
        Console.WriteLine($"Employee Name: {ename}");
        Console.WriteLine($"Basic Salary: {salary}");
        Console.WriteLine($"Gross Salary: {grossSalary}");
        Console.WriteLine($"Net Salary: {netSalary}");
    }
}