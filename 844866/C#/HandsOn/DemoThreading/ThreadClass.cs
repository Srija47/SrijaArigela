using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace DemoThreading
{
    class ThreadClass
    {
        public void countEven()
        {
            for(int i=0;i<100;i+=2)
            {
                Console.WriteLine(i);
                if (i == 50) 
                    Thread.Sleep(30000);
            }
        }
        public void countOdd()
        {
            for (int i = 1; i < 100; i += 2 )
            {
                Console.WriteLine(i);
            }
        }
    }
    class ThreadClass
    {
        syncClass sd = new syncClass();
        public void countEven()
        {
            //lock(this)
            //Monitor.Enter(this)
            sd.Display(10);
            //Monitor.Exit(this)
        }
        public void countOdd()
        {
            //lock(this)
            //Monitor.Enter(this)
            sd.Display(20);
            //Monitor.Exit(this)
        }
    }
}
