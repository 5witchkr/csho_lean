using System;
using System.Threading;
namespace ServerCore
{

    class Program
    {
        static bool _stop = false;

        static void ThreadMain()
        {
            Console.WriteLine("Start thread");

            while (_stop == false)
            {
                //wait
            }

            Console.WriteLine("Stop thread");
        }

        static void Main(String[] args)
        {
            Task t = new Task(ThreadMain);
            t.Start();

            Thread.Sleep(1000);

            _stop = true;

            Console.WriteLine("call Stop");
            Console.WriteLine("wait Stop");

            t.Wait();
            Console.WriteLine("done Stop");
        }
    }
}