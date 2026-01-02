// class Program{
//     public static void Main(string[] args){

//         Program p = new Program();
//         p.Practice1();
//         p.Practice2();
//         p.Practice3();
//         p.Practice4();
//         p.Practice5();
//         p.Practice6();
//         p.Practice7();
//         p.Practice8();
//         p.Practice9();
//         p.Practice10();
//         p.Practice11();
//         p.Practice11();
//         p.Practice12();
//         p.Practice13();
//         p.Practice14();
//         p.Practice15();
//     }
//     void Practice1(){
//         int[] arr = new int[10];
//         for(int i=0;i<arr.Length;i++){
//             Console.Write($"Enter the Element at {i} index : ");
//             arr[i]=Convert.ToInt32(Console.ReadLine());
//         }
//         for(int i=0;i<arr.Length;i++){
//             Console.WriteLine($"Element at {i} : {arr[i]}");

//         }
//     }

//     void Practice2(){
//         Console.Write("Enter the Size of the array : ");
//         int size=Convert.ToInt32(Console.ReadLine());
//         int[] arr = new int[size];
//         for(int i=0;i<arr.Length;i++){
//             Console.Write($"Enter the Element at {i} index : ");
//             arr[i]=Convert.ToInt32(Console.ReadLine());
//         }
//         Console.WriteLine("Array in Reverse order : ");
//         int left=0;
//         int right=arr.Length-1;
//         while(left<=right){
//             int temp=arr[left];
//             arr[left]=arr[right];
//             arr[right]=temp;
//             left++;
//             right--;
//         }
//         for(int i=0;i<arr.Length;i++){
//             Console.WriteLine($"Element at {i} : {arr[i]}");
//         }
//     }


//     void Practice3(){
//         Console.Write("Enter the Size of the Array : ");
//         int size=Convert.ToInt32(Console.ReadLine());
//         int[] arr = new int[size];
//         for(int i=0;i<arr.Length;i++){
//             Console.WriteLine($"Enter the element at {i} index: ");
//             arr[i] = Convert.ToInt32(Console.ReadLine());
//         }
//         int sum = 0;
//         foreach(int i in arr){
//             sum+=i;

//         }
//         Console.WriteLine($"Sum of the array is : {sum}");
//     }

//     void Practice4(){
//         Console.Write("Enter the Size of the Array :");
//         int n = Convert.ToInt32(Console.ReadLine());

//         int[] arr1 = new int[n];
//         int[] arr2 = new int[n];

//         Console.WriteLine($"Enter the elements in the array :");
//         for (int i = 0; i < n; i++)
//         {
//             Console.Write($"element - {i} : ");
//             arr1[i] = Convert.ToInt32(Console.ReadLine());
//         }
//         for (int i = 0; i < n; i++)
//         {
//             arr2[i] = arr1[i];
//         }
//         Console.WriteLine("The elements stored in the first array are :");
//         for (int i = 0; i < n; i++){
//             Console.Write(arr1[i] + " ");
//         }

//         Console.WriteLine("\nThe elements copied into the second array are :");
//         for (int i = 0; i < n; i++){
//             Console.Write(arr2[i] + " ");
//         }
//     }
//     void Practice5(){
//         Console.Write("Enter the Size of the Array :");
//         int n = Convert.ToInt32(Console.ReadLine());

//         int[] arr = new int[n];
//         int duplicateCount = 0;

//         Console.WriteLine($"Enter the elements in the array :");
//         for (int i = 0; i < n; i++)
//         {
//             Console.Write($"element - {i} : ");
//             arr[i] = Convert.ToInt32(Console.ReadLine());
//         }

//         for (int i = 0; i < n; i++)
//         {
//             for (int j = i + 1; j < n; j++)
//             {
//                 if (arr[i] == arr[j])
//                 {
//                     duplicateCount++;
//                     break;
//                 }
//             }
//         }

//         Console.WriteLine($"Total number of duplicate elements found in the array is : {duplicateCount}");
//     }

//     void Practice6(){
//         Console.Write("Enter the Size of the Array :");
//         int n = Convert.ToInt32(Console.ReadLine());

//         int[] arr = new int[n];

//         Console.WriteLine($"Enter the elements in the array :");
//         for (int i = 0; i < n; i++)
//         {
//             Console.Write($"element - {i} : ");
//             arr[i] = Convert.ToInt32(Console.ReadLine());
//         }
//         Console.Write("The Unique Element Found in the Array : ");
//         for(int i=0;i<arr.Length;i++){
//             int count=0;
//             for(int j=0;j<arr.Length;j++){
//                 if(arr[i]==arr[j]){
//                     count++;
//                 }
//             }
//             if(count==1){
//                 Console.Write(arr[i]+" ");
//             }
//         }

//     }

//     void Practice7(){
//         Console.Write("Enter the Size of the Array :");
//         int n = Convert.ToInt32(Console.ReadLine());

//         int[] arr1 = new int[n];
//         int[] arr2 = new int[n];
//         int[] merged = new int[n + n];

//         Console.WriteLine($"Enter thee elements in the First array :");
//         for (int i = 0; i < n; i++)
//         {
//             Console.Write($"element - {i} : ");
//             arr1[i] = Convert.ToInt32(Console.ReadLine());
//         }

//         Console.WriteLine($"Enter the Elements in the Second Array :");
//         for (int i = 0; i < n; i++)
//         {
//             Console.Write($"element - {i} : ");
//             arr2[i] = Convert.ToInt32(Console.ReadLine());
//         }

//         int i1 = 0, i2 = 0, k = 0;

//         while (i1 < n && i2 < n)
//         {
//             if (arr1[i1] <= arr2[i2])
//                 merged[k++] = arr1[i1++];
//             else
//                 merged[k++] = arr2[i2++];
//         }

//         while (i1 < n)
//             merged[k++] = arr1[i1++];

//         while (i2 < n)
//             merged[k++] = arr2[i2++];

//         Console.WriteLine("The merged array in ascending order is :");
//         for (int i = 0; i < k; i++)
//             Console.Write(merged[i] + " ");
//         }

//     void Practice8(){
//         Console.Write("Enter the Size of the Array :");
//         int n = Convert.ToInt32(Console.ReadLine());

//         int[] arr = new int[n];
//         bool[] visited = new bool[n];

//         Console.WriteLine($"Input {n} elements in the array :");
//         for (int i = 0; i < n; i++)
//         {
//             Console.Write($"element - {i} : ");
//             arr[i] = Convert.ToInt32(Console.ReadLine());
//         }

//         Console.WriteLine("Frequency of all elements of array :");
//         for(int i=0;i<n;i++){
//             if(visited[i]){
//                 continue;
//             }
//             int count=1;
//             for(int j = i + 1; j < n; j++)
//             {
//                 if(arr[i]==arr[j]){
//                     count++;
//                     visited[j]=true;
//                 }
//             }
//             Console.WriteLine($"{arr[i]} occurs {count} times");
//         }


//     }

//     void Practice9(){
//         Console.Write("Enter the Size of the Array : ");
//         int n = Convert.ToInt32(Console.ReadLine());

//         int[] arr = new int[n];

//         Console.WriteLine($"Enter the Elements in the array : ");
//         for (int i = 0; i < n; i++)
//         {
//             Console.Write($"element - {i} : ");
//             arr[i] = Convert.ToInt32(Console.ReadLine());
//         }

//         int max = arr[0];
//         int min = arr[0];

//         for (int i = 1; i < n; i++)
//         {
//             if (arr[i] > max){
//                 max = arr[i];
//             }
//             if (arr[i] < min) {
//                 min = arr[i];
//             }
//         }

//         Console.WriteLine($"Maximum element is : {max}");
//         Console.WriteLine($"Minimum element is : {min}");
//     }

//     void Practice10(){
//         Console.Write("Enter the Size of the Array : ");
//         int n = Convert.ToInt32(Console.ReadLine());

//         int[] arr = new int[n];
//         int[] even = new int[n];
//         int[] odd = new int[n];
//         int e = 0, o = 0;

//         Console.WriteLine($"Enter the elements in the array :");
//         for (int i = 0; i < n; i++)
//         {
//             Console.Write($"element - {i} : ");
//             arr[i] = Convert.ToInt32(Console.ReadLine());
//         }

//         for (int i = 0; i < n; i++)
//         {
//             if (arr[i] % 2 == 0)
//                 even[e++] = arr[i];
//             else
//                 odd[o++] = arr[i];
//         }

//         Console.WriteLine("The Even elements are:");
//         for (int i = 0; i < e; i++){
//             Console.Write(even[i] + " ");
//         }
//         Console.Write("\nThe Odd elements are :");
//         for (int i = 0; i < o; i++){
//             Console.Write(odd[i] + " ");
//         }
//     }
//     void Practice11(){
//         Console.WriteLine("\nEnter the Size of the Array : ");
//         int n = Convert.ToInt32(Console.ReadLine());

//         int[] arr = new int[n];

//         Console.WriteLine($"Enter the elements in the array :");
//         for (int i = 0; i < n; i++)
//         {
//             Console.Write($"element - {i} : ");
//             arr[i] = Convert.ToInt32(Console.ReadLine());
//         }

//         for (int i = 0; i < n - 1; i++)
//         {
//             for (int j = i + 1; j < n; j++)
//             {
//                 if (arr[i] > arr[j])
//                 {
//                     int temp = arr[i];
//                     arr[i] = arr[j];
//                     arr[j] = temp;
//                 }
//             }
//         }

//         Console.WriteLine("Elements of array in sorted ascending order:");
//         for (int i = 0; i < n; i++){
//             Console.Write(arr[i] + " ");
//         }
//     }
//     void Practice12(){
//         Console.Write("\nEnter the size of the Array : ");
//         int n = Convert.ToInt32(Console.ReadLine());

//         int[] arr = new int[n];

//         Console.WriteLine($"Enter the elements in the array :");
//         for (int i = 0; i < n; i++)
//         {
//             Console.Write($"element - {i} : ");
//             arr[i] = Convert.ToInt32(Console.ReadLine());
//         }

//         // Sorting (descending)
//         for (int i = 0; i < n - 1; i++)
//         {
//             for (int j = i + 1; j < n; j++)
//             {
//                 if (arr[i] < arr[j])
//                 {
//                     int temp = arr[i];
//                     arr[i] = arr[j];
//                     arr[j] = temp;
//                 }
//             }
//         }

//         Console.WriteLine("Elements of the array in sorted descending order:");
//         for (int i = 0; i < n; i++)
//             Console.Write(arr[i] + " ");
//     }

//     void Practice13()
//     {
//         Console.Write("\nEnter the size of array : ");
//         int n = Convert.ToInt32(Console.ReadLine());

//         int[] arr = new int[n + 1];

//         Console.WriteLine($"Input {n} elements in the array in ascending order:");
//         for (int i = 0; i < n; i++)
//         {
//             Console.Write($"element - {i} : ");
//             arr[i] = Convert.ToInt32(Console.ReadLine());
//         }

//         Console.Write("Input the value to be inserted : ");
//         int value = Convert.ToInt32(Console.ReadLine());

//         int pos = n;
//         for (int i = 0; i < n; i++)
//         {
//             if (value < arr[i])
//             {
//                 pos = i;
//                 break;
//             }
//         }

//         for (int i = n; i > pos; i--)
//             arr[i] = arr[i - 1];

//         arr[pos] = value;

//         Console.WriteLine("The exist array list is :");
//         for (int i = 0; i < n; i++)
//             Console.Write(arr[i] + " ");

//         Console.WriteLine("\nAfter Insert the list is :");
//         for (int i = 0; i <= n; i++)
//             Console.Write(arr[i] + " ");
//     }

//     void Practice14()
//     {
//         Console.Write("\nEnter the size of array : ");
//         int n = Convert.ToInt32(Console.ReadLine());

//         int[] arr = new int[n + 1];

//         Console.WriteLine($"Input {n} elements in the array:");
//         for (int i = 0; i < n; i++)
//         {
//             Console.Write($"element - {i} : ");
//             arr[i] = Convert.ToInt32(Console.ReadLine());
//         }

//         Console.Write("Input the value to be inserted : ");
//         int value = Convert.ToInt32(Console.ReadLine());

//         Console.Write("Input the Position, where the value to be inserted : ");
//         int pos = Convert.ToInt32(Console.ReadLine());

//         Console.WriteLine("The current list of the array :");
//         for (int i = 0; i < n; i++)
//             Console.Write(arr[i] + " ");

//         for (int i = n; i > pos - 1; i--)
//             arr[i] = arr[i - 1];

//         arr[pos - 1] = value;

//         Console.WriteLine("\nAfter Insert the element the new list is :");
//         for (int i = 0; i <= n; i++)
//             Console.Write(arr[i] + " ");
//     }

//     void Practice15(){
//         Console.Write("\nEnter the size of array : ");
//         int n = Convert.ToInt32(Console.ReadLine());

//         int[] arr = new int[n];

//         Console.WriteLine($"Input {n} elements in the array:");
//         for (int i = 0; i < n; i++)
//         {
//             Console.Write($"element - {i} : ");
//             arr[i] = Convert.ToInt32(Console.ReadLine());
//         }

//         Console.Write("Input the position where to delete: ");
//         int pos = Convert.ToInt32(Console.ReadLine());

//         for (int i = pos - 1; i < n - 1; i++)
//             arr[i] = arr[i + 1];

//         Console.WriteLine("The new list is :");
//         for (int i = 0; i < n - 1; i++)
//             Console.Write(arr[i] + " ");
//     }
// }

class Assignment{
// 44)program to read a string and display it on the screen*/
    public void ReadString()
    {
        Console.Write("Enter the String : ");
        string str = Console.ReadLine();
        Console.WriteLine($"Enterd String is : {str}");
    }

    // 45)program to read 10 strings and display them on the screen*/
    public void TenString()
    {
        Console.Write("Enter the Number of String you want to enter : ");
        int n = Convert.ToInt32(Console.ReadLine());
        string[] arr = new string[n];
        for(int i = 0; i < n; i++)
        {
            Console.Write($"Enter the string Element at index {i}: ");
            arr[i]=Console.ReadLine();
        }
        Console.WriteLine($"String are : ");
        for(int i = 0; i < n; i++)
        {
            
            Console.WriteLine(arr[i]);
        }
    }

    // 46a)program to accept 2x2 matrices and display in matrix*/
    public void Matrix()
    {
        int[,] arr2 = new int[2,2];
        for(int i = 0; i < arr2.GetLength(0); i++)
        {
            for(int j = 0; j < arr2.GetLength(1); j++)
            {
                Console.Write($"Enter the Element at Index {i},{j} : ");
                arr2[i,j]=Convert.ToInt32(Console.ReadLine());
            }
        }
        for(int i = 0; i < arr2.GetLength(0); i++)
        {
            for(int j = 0; j < arr2.GetLength(1); j++)
            {
                Console.WriteLine($"Element at Index {i},{j} : {arr2[i,j]}");
            }
        }
    }

    // 46b)program to add 2 matrices*/
    public void AdditionOfMatrix()
    {
        int rows, cols;

        Console.Write("Enter number of rows: ");
        rows = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter number of columns: ");
        cols = Convert.ToInt32(Console.ReadLine());

        int[,] matrix1 = new int[rows, cols];
        int[,] matrix2 = new int[rows, cols];
        int[,] sum = new int[rows, cols];

        Console.WriteLine("\nEnter elements of first matrix:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"element [{i},{j}] : ");
                matrix1[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine("\nEnter elements of second matrix:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"element [{i},{j}] : ");
                matrix2[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        // Matrix addition
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                sum[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }

        Console.WriteLine("\nSum of the two matrices:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(sum[i, j] + " ");
            }
            Console.WriteLine();
        }
    }


    // 47)program to find the largest and smallest element in the 
    // array*/
    public void MinMax()
    {
        Console.Write("Enter the Size of the Array : ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr3 = new int[n];
        for(int i = 0; i < n; i++)
        {
            Console.Write($"Enter the Element at index {i}: ");
            arr3[i]=Convert.ToInt32(Console.ReadLine());
        }
        int max=arr3[0];
        for(int i = 1; i < arr3.Length; i++)
        {
            if (max < arr3[i])
            {
                max=arr3[i];
            }
        }
        Console.WriteLine($"Maximum in the array is : {max}");
        Console.WriteLine($"Minimum in the array is : {arr3.Min()}");
    }

    // 48) matrix multiplication 2 by 2 */


    // 49)transpose of a matrix i.e swaping elements between row and column*/
    public void TransposeOfMatrix()
    {
        int rows, cols;

        Console.Write("Enter number of rows: ");
        rows = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter number of columns: ");
        cols = Convert.ToInt32(Console.ReadLine());

        int[,] matrix1 = new int[rows, cols];
        int[,] transpose = new int[cols, rows];

        Console.WriteLine("\nEnter elements of matrix:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"element [{i},{j}] : ");
                matrix1[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.WriteLine("\nMatrix Before Transpose: ");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix1[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("\nMatrix After Transpose: ");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                transpose[j,i]=matrix1[i,j];
            }
        }
        for (int i = 0; i < cols; i++)
        {
            for (int j = 0; j < rows; j++)
            {
                Console.Write(transpose[i, j] + " ");
            }
            Console.WriteLine();
        }

    }

    // 50) program to find whether the given matrix is diagonal 
    // matrix or not */
    public void DiagonalMatrix()
    {
        int rows, cols;

        Console.Write("Enter number of rows: ");
        rows = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter number of columns: ");
        cols = Convert.ToInt32(Console.ReadLine());

        // Diagonal matrix must be square
        if (rows != cols)
        {
            Console.WriteLine("The matrix is NOT a diagonal matrix.");
            return;
        }

        int[,] matrix = new int[rows, cols];
        bool isDiagonal = true;

        Console.WriteLine("\nEnter elements of the matrix:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"element [{i},{j}] : ");
                matrix[i, j] = Convert.ToInt32(Console.ReadLine());

                // Check diagonal condition
                if (i != j && matrix[i, j] != 0)
                {
                    isDiagonal = false;
                }
            }
        }

        if (isDiagonal)
            Console.WriteLine("\nThe matrix is a diagonal matrix.");
        else
            Console.WriteLine("\nThe matrix is NOT a diagonal matrix.");
    }

    // 51) program to find whether the given matrix is diagonal 
    // matrix or not */

    // 52) program to reverse the contents of a string using string function */
    public void StringReverse()
    {
        Console.Write("Enter the String : ");
        string str = Console.ReadLine();
        Console.WriteLine($"String is : {str}");
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        string reversed = new string(charArray);
        Console.WriteLine($"Reversed String is : {reversed}");

    }

    // 53) program to reverse the contents of a string without using 
    // string function */
    public void StringReverse2()
    {
        Console.Write("Enter the String : ");
        string str = Console.ReadLine();
        Console.WriteLine($"String is : {str}");
        int left=0;
        int right=str.Length-1;
        char[] charArray = str.ToCharArray();
        
        while (left < right)
        {
            char temp = charArray[left];
            charArray[left] = charArray[right];
            charArray[right] = temp;
            left++;
            right--;
        }
        string reversed=new string(charArray);
        Console.WriteLine($"Reversed String is : {reversed}");
    }


    // 54)program to convert from lowerletter to upperletter and vise versa
    //  lowerletter-32=UPPERLETTER;
    //  UPPERLETTER+32=lowerletter;
    // */
    public void Upper1()
    {
        Console.Write("Enter the String : ");
        string str = Console.ReadLine();
        Console.WriteLine($"String from lowerCase to UpperCase : {str.ToUpper()}");
        Console.WriteLine($"String from UpperCase to lowerCase : {str.ToLower()}");
    }


    // 55)/* program to convert a string to uppercase and lowercase without 
    // using string functions
    // HINT:
    // lowerletter-32=UPPERLETTER;
    // UPPERLETTER+32=lowerletter;

    //  */
    public void Upper2()
    {
        Console.Write("Enter the String : ");
        string str = Console.ReadLine();
        string upper="";
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] >= 'a' && str[i] <= 'z')
            {
                // Convert lowercase to uppercase
                upper += (char)(str[i] - 32);
            }
            else
            {
                // Keep other characters unchanged
                upper += str[i];
            }
        }
        Console.WriteLine($"String from lowerCase to UpperCase : {upper}");
        string lower="";
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] >= 'A' && str[i] <= 'Z')
            {
                // Convert lowercase to uppercase
                lower += (char)(str[i] + 32);
            }
            else
            {
                // Keep other characters unchanged
                lower += str[i];
            }
        }
        Console.WriteLine($"String from UpperCase to lowerCase : {lower}");
    }

    // 56)program to compare 2 strings  using standard library functions*/
    public void CompareString1()
    {
        Console.Write("Enter the First String : ");
        string str1 = Console.ReadLine();
        Console.Write("Enter the Second String : ");
        string str2 = Console.ReadLine();
        if (str1.Equals(str2))
        {
            Console.WriteLine($"{str1} and {str2} are Equal");
        }
        else
        {
            Console.WriteLine($"{str1} and {str2} are not Equal");
        }
    }


    // 57)program to compare 2 strings without using standard library functions*/

    public void CompareStrings2()
    {
        Console.Write("Enter first string: ");
        string s1 = Console.ReadLine();

        Console.Write("Enter second string: ");
        string s2 = Console.ReadLine();

        bool isEqual = true;

        if (s1.Length != s2.Length)
        {
            isEqual = false;
        }
        else
        {
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] != s2[i])
                {
                    isEqual = false;
                    break;
                }
            }
        }

        if (isEqual)
            Console.WriteLine("Strings are equal");
        else
            Console.WriteLine("Strings are not equal");
    }

    // 58)program to concatenate 2 strings  using standard library functions*/
    public void ConcatUsingLibrary()
    {
        Console.Write("Enter first string: ");
        string s1 = Console.ReadLine();

        Console.Write("Enter second string: ");
        string s2 = Console.ReadLine();

        string result = string.Concat(s1, s2);

        Console.WriteLine("Concatenated String: " + result);
    }


    // 59)program to concatenate 2 strings without using standard 
    // library functions*/

    public void ConcatWithoutLibrary()
    {
        Console.Write("Enter first string: ");
        string s1 = Console.ReadLine();

        Console.Write("Enter second string: ");
        string s2 = Console.ReadLine();

        string result = "";

        for (int i = 0; i < s1.Length; i++)
            result += s1[i];

        for (int i = 0; i < s2.Length; i++)
            result += s2[i];

        Console.WriteLine("Concatenated String: " + result);
    }


    // 60)program  to search a string in main string */
    public void SearchString()
    {
        Console.Write("Enter main string: ");
        string mainStr = Console.ReadLine();

        Console.Write("Enter string to search: ");
        string searchStr = Console.ReadLine();

        bool found = false;

        for (int i = 0; i <= mainStr.Length - searchStr.Length; i++)
        {
            int j;
            for (j = 0; j < searchStr.Length; j++)
            {
                if (mainStr[i + j] != searchStr[j])
                    break;
            }

            if (j == searchStr.Length)
            {
                found = true;
                break;
            }
        }

        if (found)
            Console.WriteLine("String found");
        else
            Console.WriteLine("String not found");
    }

}

class Program{
    public static void Main(string[] args)
    {
        Assignment assignment = new Assignment();
        assignment.ReadString();
        assignment.TenString();
        assignment.Matrix();
        assignment.MinMax();
        assignment.AdditionOfMatrix();
        assignment.TransposeOfMatrix();
        assignment.DiagonalMatrix();
        assignment.StringReverse();
        assignment.StringReverse2();
        assignment.Upper1();
        assignment.Upper2();
        assignment.CompareString1();
        assignment.CompareStrings2();
        assignment.ConcatUsingLibrary();
        assignment.ConcatWithoutLibrary();
        assignment.SearchString();
    }
}