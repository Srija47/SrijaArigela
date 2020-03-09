using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace DemoThreading
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadClass tObj = new ThreadClass();
            Console.WriteLine("Main Starts");
            Thread th = new Thread(tObj.countEven);
            Thread th1 = new Thread(tObj.countOdd);
            //to set priority assign thread priority
            th.Priority = ThreadPriority.Lowest;
            th1.Priority = ThreadPriority.Highest;
            th.Start();
            th1.Start();
            //th.Suspend();
            //Console.WriteLine("Thread got Suspended");
            //th.Resume();
            if (!th1.IsAlive)
                th.Interrupt();
            Console.WriteLine("Main Ends");
            Console.ReadKey();
        }
    }
}
