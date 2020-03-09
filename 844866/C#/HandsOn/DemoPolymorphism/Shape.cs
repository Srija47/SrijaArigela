using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPolymorphism
{
    class Shape
    {
        int length;
        int width;
        int breadth;
        public void draw()
        {
            Console.WriteLine("A shape can br drawn\n");
        }
        public void draw(int l)
        {
            this.length = l;
            Console.WriteLine("A square shape can be drawn\n");
        }
        public void draw(int l,int w)
        {
            this.length = l;
            this.width = w;
            Console.WriteLine("A Rectangle shape can be drawn\n");
        }
        public void draw(int l, int w,int b)
        {
            this.length = l;
            this.width = w;
            this.breadth = b;
            Console.WriteLine("A box shape can be drawn\n");
        }
        public void draw(int l, int w, int b,string name)
        {
            this.length = l;
            this.width = w;
            this.breadth = b;
            Console.WriteLine(name+" shape can be drawn\n");
        }

    }
}
