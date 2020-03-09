using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            float f = 2.3f;
            double d = 8.999;
            char ch = 'a';
            object o = i;
            object o1 = d;
            object o2 = f;
            object o3 = ch;
            //unboxing
            object ob = 12;
            int k = (int)ob;
            object ob1 = 12.3;
            double d1 = (double)ob1;
            object ob2 = 'a';
            char ch1 = (char)ob2;
            object ob3 = "abc";
            string s = ob3.ToString();
            //convert int to string
            s = i.ToString();
            s = d1.ToString();



        }
    }
}
