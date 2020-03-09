using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoIndexer
{
    class Car
    {
        int year;
        string[] name = new string[4];
        public int Year { get => year; set => year = value; }
       // public string[] Name { get => name; set => name = value; }
       public string this[int x] { get => name[x]; set => name[x] = value; }
       
        public void display()
        {
            foreach (string val in name)
                Console.WriteLine(val);
        }

    }
}
