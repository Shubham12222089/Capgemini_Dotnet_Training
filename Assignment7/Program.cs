using System.Collections;
using System.Runtime.CompilerServices;

class Program
{
    public static void Main(string[] args)
    {
        //---------------Task 1--------------------
        Console.WriteLine("Enter the Number of Products : ");
        int product = Convert.ToInt32(Console.ReadLine());
        if (product <= 1)
        {
            Console.WriteLine("Invalid Number of Products");
            return;
        }
        int[] Products = new int[product];
        Console.WriteLine("Array is dynamically created.");
        Console.WriteLine();
        for(int i = 0; i < product; i++)
        {
            Console.Write($"Enter the {i+1} Product : ");
            int temp=Convert.ToInt32(Console.ReadLine());
            if (temp < 1)
            {
                Console.WriteLine("Invalid Input. Please Retry");
            }
            else{
                Products[i] = temp;
            }
        }

        int average=0;
        foreach(int i in Products)
        {
            average+=i;
        }
        average = average/Products.Length;
        Console.WriteLine($"Average is : {average}");

        //Sort
        Console.Write("Before Sorting : ");
        for(int i = 0; i < Products.Length; i++)
        {
            Console.Write(Products[i]+" ");
        }
        Array.Sort(Products);
        Console.WriteLine();
        Console.Write("After Sorting : ");
        for(int i = 0; i < Products.Length; i++)
        {
            Console.Write(Products[i]+" ");
        }

        //Replacing prices below Average with 0
        for (int i = 0; i < Products.Length; i++)
        {
            if (Products[i] < average)
            {
                Products[i] = 0;
            }
        }
        Console.WriteLine();
        Console.Write("After Replacing prices below Average with 0 : ");
        for(int i = 0; i < Products.Length; i++)
        {
            Console.Write(Products[i]+" ");
        }
        Console.WriteLine();
        Console.WriteLine("After Resizing : ");
        int OldSize = Products.Length;
        Array.Resize(ref Products,Products.Length+5);

        for(int i = OldSize; i < Products.Length; i++)
        {
            Products[i] = average;
        }

        for(int i = 0; i < Products.Length; i++)
        {
            Console.WriteLine($"Element at Index {i} is : {Products[i]}");
        }


        //---------------Task 2--------------------

        Console.WriteLine("Enter the Number of Branches : ");
        int branches = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the Number of Months : ");
        int months = Convert.ToInt32(Console.ReadLine());

        int[,] sales = new int[branches,months];
        for (int i = 0; i < branches; i++)
        {
            Console.WriteLine($"\nEnter sales for Branch {i + 1}:");
            for (int j = 0; j < months; j++)
            {
                Console.Write($"Month {j + 1}: ");
                sales[i, j] = int.Parse(Console.ReadLine());
            }
        }

        int highest = sales[0,0];
        Console.WriteLine();
        Console.WriteLine("Branch Total Sales: ");
        for(int i = 0; i < branches; i++)
        {
            int totalSales=0;
            for(int j = 0; j < months; j++)
            {
                totalSales += sales[i,j];
                if(highest < sales[i, j])
                {
                    highest = sales[i,j];
                }
            }
            Console.WriteLine($"Branch {i + 1}: {totalSales}");
        }
        Console.WriteLine($"\nHighest Monthly Sale Across All Branches: {highest}");

        //---------------Task 3--------------------

        int[][] Jagged = new int[branches][];
        for(int i = 0; i < branches; i++)
        {
            int count=0;
            for(int j = 0; j < months; j++)
            {
                if (sales[i, j] >= average)
                {
                    count++;
                }
            }
            Jagged[i] = new int[count];
            int index=0;
            for (int j = 0; j < months; j++)
                if (sales[i, j] >= average)
                    Jagged[i][index++] = sales[i, j];

        }   
        Console.WriteLine("Jagged Array Output:");
        for (int i = 0; i < Jagged.Length; i++)
        {
            Console.Write($"Branch {i + 1}: ");
            if (Jagged[i].Length == 0)
                Console.Write("No qualifying sales");
            else
                foreach (int v in Jagged[i])
                    Console.Write(v + " ");
            Console.WriteLine();
        }

        //---------------Task 4--------------------
        Console.WriteLine();

        Console.Write("Enter Number of Customer Transactions: ");
        int transactionCount = Convert.ToInt32(Console.ReadLine());

        List<int> customerList = new List<int>();

        for (int i = 0; i < transactionCount; i++)
        {
            Console.Write($"Enter Customer ID {i + 1}: ");
            customerList.Add(Convert.ToInt32(Console.ReadLine()));
        }

        int originalCount = customerList.Count;

        HashSet<int> uniqueCustomers = new HashSet<int>(customerList);
        List<int> cleanedCustomerList = new List<int>(uniqueCustomers);

        Console.WriteLine("Cleaned Customer List:");
        foreach (int id in cleanedCustomerList)
        {
            Console.Write(id + " ");
        }

        Console.WriteLine();
        Console.WriteLine($"Duplicate Entries Removed: {originalCount - cleanedCustomerList.Count}");

        //---------------Task 5--------------------
        Console.WriteLine();

        Console.Write("Enter Number of Financial Transactions: ");
        int financeCount = Convert.ToInt32(Console.ReadLine());

        Dictionary<int, double> transactionMap = new Dictionary<int, double>();

        for (int i = 0; i < financeCount; i++)
        {
            Console.Write("Enter Transaction ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            if (transactionMap.ContainsKey(id))
            {
                Console.WriteLine("Duplicate Transaction ID Not Allowed");
                i--;
                continue;
            }

            Console.Write("Enter Amount: ");
            double amount = Convert.ToDouble(Console.ReadLine());

            transactionMap.Add(id, amount);
        }

        SortedList<int, double> highValueTransactions = new SortedList<int, double>();

        foreach (KeyValuePair<int, double> item in transactionMap)
        {
            if (item.Value >= average)
            {
                highValueTransactions.Add(item.Key, item.Value);
            }
        }

        Console.WriteLine("High Value Transactions (Sorted):");
        foreach (KeyValuePair<int, double> item in highValueTransactions)
        {
            Console.WriteLine($"Transaction ID: {item.Key}, Amount: {item.Value}");
        }

        //---------------Task 6--------------------
        Console.WriteLine();

        Console.Write("Enter Number of Operations: ");
        int operationCount = Convert.ToInt32(Console.ReadLine());

        Queue<string> processQueue = new Queue<string>();
        Stack<string> undoStack = new Stack<string>();

        for (int i = 0; i < operationCount; i++)
        {
            Console.Write($"Enter Operation {i + 1}: ");
            string operation = Console.ReadLine();

            processQueue.Enqueue(operation);
            undoStack.Push(operation);
        }

        Console.WriteLine("Processed Operations:");
        while (processQueue.Count > 0)
        {
            Console.WriteLine(processQueue.Dequeue());
        }

        Console.WriteLine("Undone Operations:");
        for (int i = 0; i < 2 && undoStack.Count > 0; i++)
        {
            Console.WriteLine(undoStack.Pop());
        }

        //---------------Task 7--------------------
        Console.WriteLine();

        Console.Write("Enter Number of Users: ");
        int userCount = Convert.ToInt32(Console.ReadLine());

        Hashtable userRoles = new Hashtable();
        ArrayList mixedData = new ArrayList();

        for (int i = 0; i < userCount; i++)
        {
            Console.Write("Enter Username: ");
            string username = Console.ReadLine();

            Console.Write("Enter Role: ");
            string role = Console.ReadLine();

            userRoles[username] = role;
            mixedData.Add(username);
            mixedData.Add(role);
        }

        Console.WriteLine("Hashtable Data:");
        foreach (DictionaryEntry entry in userRoles)
        {
            Console.WriteLine($"{entry.Key} : {entry.Value}");
        }

        Console.WriteLine("ArrayList Data (Mixed Types):");
        foreach (object obj in mixedData)
        {
            Console.WriteLine(obj);
        }


    }

}

