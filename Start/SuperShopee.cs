using System;

class Demo
{
    static void Main()
    {
        int num1;
        int num2;
        int numResult;

	//Taking Input Below
		Console.Write("Enter the First Number: ");
		num1=Int32.Parse(Console.ReadLine());
		Console.Write("Enter the Second Number: ");	
		num2=Int32.Parse(Console.ReadLine());

		//Bussiness Logic
		int disc = (num1+num2)*10/100;
		numResult=(num1+num2)-disc; //payable by the customer

		//print
		//Console.Write("The Sum of {0} and {1} is {2}",num1,num2,numResult);
		//console.readLine();
		Console.WriteLine("LPU Shope");
		Console.WriteLine("Price of Product 1 : {0}",num1);
		Console.WriteLine("Price of Product 2 : {0}",num2);
		Console.WriteLine("Total Price of Product : {0}",(num1+num2));
		Console.WriteLine("  Discounted Price of Product : {0}",disc);
		Console.WriteLine("Payable amount after Discount : {0}",numResult);
    }
}