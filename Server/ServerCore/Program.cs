using System;
using System.Threading;
namespace ServerCore;

class Program
{
    static void TestThread()
    {
        while(true)
            Console.WriteLine("Test Thread Run!!!");
    }
    static void Main(String[] args)
    {
        Thread t = new Thread(TestThread);
        t.Name = "Test Thread";
        t.IsBackground = true;

        t.Start();

        Console.WriteLine("waiting for thread");
        t.Join();

        Console.WriteLine("exit app");
    }
}
