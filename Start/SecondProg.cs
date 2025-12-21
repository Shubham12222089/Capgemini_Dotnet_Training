using System;

class AddProg
{
    static void Main()
    {
        int num1=100;
        int num2=200;
        int numResult;

	//Taking Input Below
	Console.Write("Enter the First Number: ");
	num1=Int32.Parse(Console.ReadLine());
	Console.Write("Enter the Second Number: ");	
	num2=Int32.Parse(Console.ReadLine());
	
	//Bussiness Logic
	numResult=num1+num2;

	//print
	Console.Write("The Sum of {0} and {1} is {2}",num1,num2,numResult);
	//console.readLine();
    }
}