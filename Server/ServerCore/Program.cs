using System;
using System.Threading;
namespace ServerCore;

class Program
{
    static void TestThread(object state)
    {
        for (int i = 0; i < 5; i++) {
            Console.WriteLine("Test Thread Run!!!");
        }
    }
    static void Main(String[] args)
    {
        ThreadPool.QueueUserWorkItem(TestThread);

        while (true) { }
        //Thread t = new Thread(TestThread);
        //t.Name = "Test Thread";
        //t.IsBackground = true;

        //t.Start();

        //Console.WriteLine("waiting for thread");
        //t.Join();

        //Console.WriteLine("exit app");
    }
}