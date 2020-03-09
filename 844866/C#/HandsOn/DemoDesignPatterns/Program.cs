using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //Singleton fromEmployee = new Singleton();//first object created
            Singleton fromEmployee = Singleton.GetInstance;
            fromEmployee.printDetails("Hi");
            // Singleton fromStudent= new Singleton();
            Singleton fromStudent= Singleton.GetInstance;
            fromStudent.printDetails("Welcome");
            Console.ReadKey();
        }
    }
}
