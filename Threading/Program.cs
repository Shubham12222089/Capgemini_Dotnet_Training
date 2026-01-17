// using System;
// using System.Threading;

// class Program
// {
//     static void Print()
//     {
//         Console.WriteLine("Hello from thread");
//     }

//     static void Main()
//     {
//         Thread t = new Thread(Print);
//         t.Start();   // starts new thread
//     }
// }

//---------------Join----------------
// using System;
// using System.Threading;

// class Program
// {
//     static void Work()
//     {
//         Console.WriteLine("Thread started");
//         Thread.Sleep(2000); // simulate work
//         Console.WriteLine("Thread finished");
//     }

//     static void Main()
//     {
//         Thread t = new Thread(Work);
//         t.Start();

//         t.Join(); // Main thread waits here

//         Console.WriteLine("Main thread continues");
//     }
// }

//--------------Priority-------------
// using System;
// using System.Threading;

// class Program
// {
//     static void Task(string name)
//     {
//         for (int i = 1; i <= 5; i++)
//         {
//             Console.WriteLine($"{name} running");
//         }
//     }

//     static void Main()
//     {
//         Thread high = new Thread(() => Task("High Priority"));
//         Thread low  = new Thread(() => Task("Low Priority"));

//         high.Priority = ThreadPriority.Highest;
//         low.Priority  = ThreadPriority.Lowest;

//         high.Start();
//         low.Start();
//     }
// }


//----------Lock-----------------
using System;
using System.Threading;

class Program
{
    static int count = 0;
    static object lockObj = new object();

    static void Increment()
    {
        for (int i = 0; i < 1000; i++)
        {
            lock (lockObj)
            {
                count++;
            }
        }
    }

    static void Main()
    {
        Thread t1 = new Thread(Increment);
        Thread t2 = new Thread(Increment);

        t1.Start();
        t2.Start();

        t1.Join();
        t2.Join();

        Console.WriteLine("Final Count: " + count);
    }
}


