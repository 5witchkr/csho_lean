using System;
using System.Threading;
namespace ServerCore;

class Program
{
    static void MainThread()
    {
        Console.WriteLine("Main Thread Run!!!");
    }
    static void Main(String[] args)
    {
        Thread t = new Thread(MainThread);

        t.Start();

        Console.WriteLine("Hello World");

    }
}
