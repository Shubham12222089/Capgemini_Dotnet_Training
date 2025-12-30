// using System.Diagnostics.CodeAnalysis;

// class Program
// {
//     public static void Main(string[] args)
//     {

//         int[] arr = new int[6];
//         for(int i = 0; i < arr.Length; i++)
//         {
//             Console.Write($"Enter the value at index {i+1} : ");
//             arr[i] = Convert.ToInt32(Console.ReadLine());
//         }
//         Console.Write("arr : ");
//         foreach(int i in arr)
//         {
//             Console.Write(i+" ");

//         }
//         Console.WriteLine($"Length of the Array (arr) is : {arr.Length}");
//         int sum=0;
//         for(int i = 0; i < arr.Length; i++)
//         {
//             sum+=arr[i];
//         }
//         Console.WriteLine($"Sum of the Array(arr) is : {sum}");

//         char[] CharArray = new char[10];

//         for(int i = 0; i < CharArray.Length; i++)
//         {
//             Console.Write($"Enter the {i+1}th Emelent of the Char Array : ");
//             CharArray[i]=Convert.ToChar(Console.ReadLine());
//         }
//         Console.Write("Char Array Elements are : ");
//         foreach(char i in CharArray)
//         {
//             Console.Write(i+" ");
//         }
//     }
// }


//-----------------------------------------------
// using System.Runtime.InteropServices;

// class Program
// {
//     public static void Main(string[] args)
//     {
//         // string[] empNames = new string[6];

//         // for(int i=0;i<empNames.Length;i++)
//         // {
//         //     Console.Write($"Enter the Name of the Employee at {i+1} : ");
//         //     empNames[i]=Console.ReadLine();
//         // }
//         // Console.Write("Name of the Employees are : ");
//         // foreach(string s in empNames)
//         // {
//         //     Console.Write(s + " ");
//         // }

//         int[] arr = new int[6];
//         arr = [10,20,30,40,50,60];
//         Program p = new Program();
//         p.SumofArray(arr);

//     }
//     void SumofArray(int[] arr)
//     {
//         int sum=0;
//         for(int i = 0; i < arr.Length; i++)
//         {
//             sum+=arr[i];
//         }
//         Console.WriteLine($"Sum of the Array(arr) is : {sum}");
//     }

// }

//-------------2d Array----------------------
// using System;

// class Program
// {
//     public static void Main(string[] args)
//     {
//         int[,] arr = new int[3,3];
//         for(int i = 0; i < arr.GetLength(0); i++)
//         {
//             for(int j = 0; j < arr.GetLength(1); j++)
//             {
//                 Console.Write($"Enter the element at index {i+","+j}: ");
//                 arr[i,j] = Convert.ToInt32(Console.ReadLine());
//             }
//         }
//         Console.Write("Element of the array are : ");
//         for(int i = 0; i < arr.GetLength(0); i++)
//         {
//             for(int j = 0; j < arr.GetLength(1); j++)
//             {
//                 Console.Write(arr[i,j]+" ");
//             }
//         }

//     }
// }

//Array Practice Questions
class Program{
    public static void Main(string[] args){
        
        Program p = new Program();
        p.Practice1();
        p.Practice2();
        p.Practice3();
        p.Practice4();
        p.Practice5();
        p.Practice6();
        p.Practice7();
        p.Practice8();
        p.Practice9();
        p.Practice10();
        p.Practice11();
        p.Practice11();
        p.Practice12();
        p.Practice13();
        p.Practice14();
        p.Practice15();
    }
    void Practice1(){
        int[] arr = new int[10];
        for(int i=0;i<arr.Length;i++){
            Console.Write($"Enter the Element at {i} index : ");
            arr[i]=Convert.ToInt32(Console.ReadLine());
        }
        for(int i=0;i<arr.Length;i++){
            Console.WriteLine($"Element at {i} : {arr[i]}");

        }
    }

    void Practice2(){
        Console.Write("Enter the Size of the array : ");
        int size=Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[size];
        for(int i=0;i<arr.Length;i++){
            Console.Write($"Enter the Element at {i} index : ");
            arr[i]=Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Array in Reverse order : ");
        int left=0;
        int right=arr.Length-1;
        while(left<=right){
            int temp=arr[left];
            arr[left]=arr[right];
            arr[right]=temp;
            left++;
            right--;
        }
        for(int i=0;i<arr.Length;i++){
            Console.WriteLine($"Element at {i} : {arr[i]}");
        }
    }


    void Practice3(){
        Console.Write("Enter the Size of the Array : ");
        int size=Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[size];
        for(int i=0;i<arr.Length;i++){
            Console.WriteLine($"Enter the element at {i} index: ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        int sum = 0;
        foreach(int i in arr){
            sum+=i;

        }
        Console.WriteLine($"Sum of the array is : {sum}");
    }

    void Practice4(){
        Console.Write("Enter the Size of the Array :");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr1 = new int[n];
        int[] arr2 = new int[n];

        Console.WriteLine($"Enter the elements in the array :");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"element - {i} : ");
            arr1[i] = Convert.ToInt32(Console.ReadLine());
        }
        for (int i = 0; i < n; i++)
        {
            arr2[i] = arr1[i];
        }
        Console.WriteLine("The elements stored in the first array are :");
        for (int i = 0; i < n; i++){
            Console.Write(arr1[i] + " ");
        }

        Console.WriteLine("\nThe elements copied into the second array are :");
        for (int i = 0; i < n; i++){
            Console.Write(arr2[i] + " ");
        }
    }
    void Practice5(){
        Console.Write("Enter the Size of the Array :");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[n];
        int duplicateCount = 0;

        Console.WriteLine($"Enter the elements in the array :");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"element - {i} : ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (arr[i] == arr[j])
                {
                    duplicateCount++;
                    break;
                }
            }
        }

        Console.WriteLine($"Total number of duplicate elements found in the array is : {duplicateCount}");
    }

    void Practice6(){
        Console.Write("Enter the Size of the Array :");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[n];

        Console.WriteLine($"Enter the elements in the array :");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"element - {i} : ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.Write("The Unique Element Found in the Array : ");
        for(int i=0;i<arr.Length;i++){
            int count=0;
            for(int j=0;j<arr.Length;j++){
                if(arr[i]==arr[j]){
                    count++;
                }
            }
            if(count==1){
                Console.Write(arr[i]+" ");
            }
        }
    
    }


    void Practice7(){
        Console.Write("Enter the Size of the Array :");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr1 = new int[n];
        int[] arr2 = new int[n];
        int[] merged = new int[n + n];

        Console.WriteLine($"Enter thee elements in the First array :");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"element - {i} : ");
            arr1[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine($"Enter the Elements in the Second Array :");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"element - {i} : ");
            arr2[i] = Convert.ToInt32(Console.ReadLine());
        }

        int i1 = 0, i2 = 0, k = 0;

        while (i1 < n && i2 < n)
        {
            if (arr1[i1] <= arr2[i2])
                merged[k++] = arr1[i1++];
            else
                merged[k++] = arr2[i2++];
        }

        while (i1 < n)
            merged[k++] = arr1[i1++];

        while (i2 < n)
            merged[k++] = arr2[i2++];

        Console.WriteLine("The merged array in ascending order is :");
        for (int i = 0; i < k; i++)
            Console.Write(merged[i] + " ");
        }

    void Practice8(){
        Console.Write("Enter the Size of the Array :");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[n];
        bool[] visited = new bool[n];

        Console.WriteLine($"Input {n} elements in the array :");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"element - {i} : ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Frequency of all elements of array :");
        for(int i=0;i<n;i++){
            if(visited[i]){
                continue;
            }
            int count=1;
            for(int j = i + 1; j < n; j++)
            {
                if(arr[i]==arr[j]){
                    count++;
                    visited[j]=true;
                }
            }
            Console.WriteLine($"{arr[i]} occurs {count} times");
        }

        
    }

    void Practice9(){
        Console.Write("Enter the Size of the Array : ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[n];

        Console.WriteLine($"Enter the Elements in the array : ");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"element - {i} : ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        int max = arr[0];
        int min = arr[0];

        for (int i = 1; i < n; i++)
        {
            if (arr[i] > max){
                max = arr[i];
            }
            if (arr[i] < min) {
                min = arr[i];
            }
        }

        Console.WriteLine($"Maximum element is : {max}");
        Console.WriteLine($"Minimum element is : {min}");
    }
    
    void Practice10(){
        Console.Write("Enter the Size of the Array : ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[n];
        int[] even = new int[n];
        int[] odd = new int[n];
        int e = 0, o = 0;

        Console.WriteLine($"Enter the elements in the array :");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"element - {i} : ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = 0; i < n; i++)
        {
            if (arr[i] % 2 == 0)
                even[e++] = arr[i];
            else
                odd[o++] = arr[i];
        }

        Console.WriteLine("The Even elements are:");
        for (int i = 0; i < e; i++){
            Console.Write(even[i] + " ");
        }
        Console.Write("\nThe Odd elements are :");
        for (int i = 0; i < o; i++){
            Console.Write(odd[i] + " ");
        }
    }
    void Practice11(){
        Console.WriteLine("\nEnter the Size of the Array : ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[n];

        Console.WriteLine($"Enter the elements in the array :");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"element - {i} : ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (arr[i] > arr[j])
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
        }

        Console.WriteLine("Elements of array in sorted ascending order:");
        for (int i = 0; i < n; i++){
            Console.Write(arr[i] + " ");
        }
    }
    void Practice12(){
        Console.Write("\nEnter the size of the Array : ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[n];

        Console.WriteLine($"Enter the elements in the array :");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"element - {i} : ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Sorting (descending)
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (arr[i] < arr[j])
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
        }

        Console.WriteLine("Elements of the array in sorted descending order:");
        for (int i = 0; i < n; i++)
            Console.Write(arr[i] + " ");
    }

    void Practice13()
    {
        Console.Write("\nEnter the size of array : ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[n + 1];

        Console.WriteLine($"Input {n} elements in the array in ascending order:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"element - {i} : ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.Write("Input the value to be inserted : ");
        int value = Convert.ToInt32(Console.ReadLine());

        int pos = n;
        for (int i = 0; i < n; i++)
        {
            if (value < arr[i])
            {
                pos = i;
                break;
            }
        }

        for (int i = n; i > pos; i--)
            arr[i] = arr[i - 1];

        arr[pos] = value;

        Console.WriteLine("The exist array list is :");
        for (int i = 0; i < n; i++)
            Console.Write(arr[i] + " ");

        Console.WriteLine("\nAfter Insert the list is :");
        for (int i = 0; i <= n; i++)
            Console.Write(arr[i] + " ");
    }

    void Practice14()
    {
        Console.Write("\nEnter the size of array : ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[n + 1];

        Console.WriteLine($"Input {n} elements in the array:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"element - {i} : ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.Write("Input the value to be inserted : ");
        int value = Convert.ToInt32(Console.ReadLine());

        Console.Write("Input the Position, where the value to be inserted : ");
        int pos = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("The current list of the array :");
        for (int i = 0; i < n; i++)
            Console.Write(arr[i] + " ");

        for (int i = n; i > pos - 1; i--)
            arr[i] = arr[i - 1];

        arr[pos - 1] = value;

        Console.WriteLine("\nAfter Insert the element the new list is :");
        for (int i = 0; i <= n; i++)
            Console.Write(arr[i] + " ");
    }

    void Practice15(){
        Console.Write("\nEnter the size of array : ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[n];

        Console.WriteLine($"Input {n} elements in the array:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"element - {i} : ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.Write("Input the position where to delete: ");
        int pos = Convert.ToInt32(Console.ReadLine());

        for (int i = pos - 1; i < n - 1; i++)
            arr[i] = arr[i + 1];

        Console.WriteLine("The new list is :");
        for (int i = 0; i < n - 1; i++)
            Console.Write(arr[i] + " ");
    }
}

