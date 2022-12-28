using System;
using System.Threading;
namespace ServerCore;

class Program
{
    static void MainThread()
    {
        while(true)
            Console.WriteLine("Main Thread Run!!!");
    }
    static void Main(String[] args)
    {
        Thread t = new Thread(MainThread);
        t.IsBackground = true;
        t.Start();

        Console.WriteLine("Hello World");
    }
}
