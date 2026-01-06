using System.Collections;
using System.Collections.ObjectModel;
using System.Data.Common;
using System.Net.NetworkInformation;

internal class Program
{
    private static void Main(string[] args)
    {
        // Hashtable hashtable = new Hashtable();
        // hashtable.Add(200,"Suresh");
        // hashtable.Add(300,"John Cena");
        // hashtable.Add(400,"Roman Reigns");
        // hashtable.Add(500,"Brett Lee");
        // hashtable.Add(600,"Sachin");
        // ICollection key = hashtable.Keys;
        // foreach(var k in key)
        // {
        //     Console.WriteLine(k);
        // }
        // ICollection value = hashtable.Values;
        // Console.Write("All the values are : ");
        // foreach(var v in value)
        // {
        //     Console.Write(v+", ");
        // }
        // Console.WriteLine();
        // foreach(var key1 in key)
        // {
        //     Console.WriteLine($"Key is {key1} and value is {hashtable[key1]}");
        // }
        // Console.WriteLine("Enter the key you want to search in the hashtable : ");
        // int key2 = Convert.ToInt32(Console.ReadLine());
        // if (hashtable.ContainsKey(key2))
        // {
        //     Console.WriteLine($"Found {key2} with the value {hashtable[key2]}");
        // }
        // else
        // {
        //     Console.WriteLine("Key Not Found");
        // }


        //-------Sorted List-----------------
        // SortedList list = new SortedList();
        // list.Add(200,"Suresh");
        // list.Add(300,"John Cena");
        // list.Add(400,"Roman Reigns");
        // list.Add(500,"Brett Lee");
        // list.Add(600,"Sachin");
        // ICollection key3 = list.Keys;
        
        // foreach(var k in key3)
        // {
        //     Console.WriteLine($"Key is {k} and value is {list[k]}");
        // }

        // //accessing using index
        // Console.WriteLine($"Index of 500 is : {list.IndexOfKey(500)}");

        // Console.WriteLine("After Clearing the List: ");
        // list.Clear();
        // int count=list.Count;
        // if (count == 0)
        // {
        //     Console.WriteLine("List Elements are Cleared");
        // }


        //---------Stack------------

        // Stack stack = new Stack();
        // stack.Push("A");
        // stack.Push("B");
        // stack.Push("C");
        // stack.Push("D");
        // stack.Push("E");

        // foreach(var s in stack)
        // {
        //     Console.Write(s+" ");
        // }
        // Console.WriteLine($"\nElement at the top of the Stack is : {stack.Peek()}");
        // Console.WriteLine($"After appling pop : ");
        // stack.Pop();
        // Console.WriteLine($"Element at the top of the Stack is : {stack.Peek()}");

        // Console.WriteLine("Enter the Element to find: ");
        // char ch = Convert.ToChar(Console.ReadLine());
        // if (stack.Contains(ch))
        // {
        //     Console.WriteLine($"Element {ch} Found");
        // }
        // else
        // {
        //     Console.WriteLine("Not Found");
        // }

        //------------Queue------------------

        // Queue queue = new Queue();
        // queue.Enqueue("A");
        // queue.Enqueue("B");
        // queue.Enqueue("C");
        // queue.Enqueue("D");
        // queue.Enqueue("E");
        // foreach(var k in queue)
        // {
        //     Console.Write(k+" ");
        // }
        // Console.WriteLine("\nAfter Deleting from the Queue: ");
        // queue.Dequeue();
        // foreach(var k in queue)
        // {
        //     Console.Write(k+" ");
        // }

        //----------------------Generic------------------------------
        //Real-life logic
        // You buy a container.
        // --- Sometimes you store water
        // --- Sometimes milk
        // --- Sometimes oil
        // The container doesn’t care what you store, but you decide before using it.
        //      (Generics allow us to write a class or method where the data type is 
        //      decided when we use it, and once decided, it stays fixed and safe.)

        // Boxing is the process of converting a value type (like int) into an 
        // object type by wrapping it inside an object.
        // int x = 10;
        // object obj = x;   // BOXING
        
        // int y = (int)obj; // UNBOXING

        // ArrayList list = new ArrayList();
        // list.Add(10);      
        // list.Add(false);
        // list.Add(65.5f);
        // int x = (int)list[0]; // unboxing

        //-------------Compile Time Vs RunTime--------(var vs Dynamic)----------
        //var x = 10;
        //x = "Hello";   // compile-time error

        //dynamic y = 10;
        //y = "Hello";   // ✔ allowed
        //why no error here as x is assigned to 10 and then string is assigned to x
        //answer : This is the exact point where most people get confused, so let’s clear it cleanly and logically.
        //Console.WriteLine(y);

        //------------------Generic vs non generic Implementation--------------------------
        // AddClass addClass = new AddClass();
        // Console.WriteLine($"Sum of the Integer is : {addClass.AddInt(30,20)}");
        // Console.WriteLine($"Sum of the Float is : {addClass.AddFloat(30.10f,20.03f)}");
        // Console.WriteLine($"Sum of the String is : {addClass.AddString("Abc","Def")}");

        // //generic class
        // AddGenericClass<int> addInteger1 = new AddGenericClass<int>();
        // Console.WriteLine($"Sum of the Integer using Generic Class is : {addInteger1.AddAllType(30,20)}");

        // AddGenericClass<float> addFloat = new AddGenericClass<float>();
        // Console.WriteLine($"Sum of the float using Generic Class is : {addFloat.AddAllType(20.03f,27.20f)}");

        // AddGenericClass<string> addString = new AddGenericClass<string>();
        // Console.WriteLine($"Sum of the String using Generic Class is : {addString.AddAllType("Abc","Def")}");
        
        // List<string> employee = new List<string>();
        // employee.Add("Rajesh");
        // Employee employee1 = new Employee()
        // {
        //     Id=10,
        //     Name="Sumit"
        // };
        // Employee employee2 = new Employee()
        // {
        //     Id=20,
        //     Name="John"
        // };

        // List<Employee> employees = new List<Employee>();
        // employees.Add(employee1);
        // employees.Add(employee2);
        // foreach(var e in employees)
        // {
        //     Console.WriteLine(e);
        // }

        // Dictionary<int,string> dictionary = new Dictionary<int, string>();
        // dictionary.Add(100,"Rajesh");
        // dictionary.Add(200,"Mahesh");
        // foreach(KeyValuePair<int,string> key in dictionary)
        // {
        //     Console.WriteLine(key);
        // }

        // SortedList<string,string> pairs = new SortedList<string, string>();
        // pairs.Add("100","Abc");
        // pairs.Add("900","def");
        // pairs.Add("300","ghi");
        // Console.WriteLine("Sorted List : ");
        // foreach(KeyValuePair<string,string> p in pairs)
        // {
        //     Console.WriteLine($"Key is {p.Key} and value is {p.Value}");
        // }

        // Stack<char> stack = new Stack<char>(); //generic stack
        // stack.Push('A');
        // stack.Push('B');
        // stack.Push('C');
        
        // Console.Write("Stack: ");
        // foreach(var s in stack)
        // {
        //     Console.Write(s+" ");
        // }
        // stack.Pop();
        // Console.WriteLine();
        // Console.Write("After Popping: ");
        // foreach(var s in stack)
        // {
        //     Console.Write(s+" ");
        // }
        // Console.WriteLine();
        // Console.Write("Queue: ");
        // Queue<char> queue = new Queue<char>();
        // queue.Enqueue('A');
        // queue.Enqueue('B');
        // queue.Enqueue('C');
        // foreach(var q in queue)
        // {
        //     Console.Write(q+" ");
        // }
        // queue.Dequeue();
        // Console.WriteLine();
        // Console.Write("After Deque: ");
        // foreach(var q in queue)
        // {
        //     Console.Write(q+" ");
        // }


        //------------Custom Collection------------------
        
        MyCollection obj = new MyCollection();
        foreach(int i in obj)
        {
            Console.WriteLine(i);
        }
    }
}

class MyCollection : IEnumerable
{
    int[] data = {1,2,3};
    public IEnumerator GetEnumerator()
    {
        return data.GetEnumerator();
    }



}

