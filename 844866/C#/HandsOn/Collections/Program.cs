using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
          /* var i = 5;
            i = 20;
            dynamic x;
            x = 67;
            x = "abc";
            */
            //Array List
            ArrayList al = new ArrayList(); 
                al.Add(5);
                al.Add("Sri");
                al.Add(2.33);
                al.Add('d');
                al.Remove(2.33);
            foreach (var val in al) 
                Console.WriteLine(val);
            // Queue type of collection
            Queue qlist = new Queue();
            qlist.Enqueue(1);
            qlist.Enqueue("Arun");
            qlist.Enqueue('c');
            Console.WriteLine(qlist.Dequeue());
            foreach (var val in qlist)
                Console.WriteLine(val);
            //stack type of collection
            Stack slist = new Stack();
            slist.Push(23);
            slist.Push("Hello");
            slist.Push(23.123);
            Console.WriteLine(slist.Pop());
            Console.WriteLine(slist.Peek());
            foreach (var s in slist)
                Console.WriteLine(s);
            // Hash Table 
            Hashtable ht = new Hashtable();
            ht.Add(1, "CTS");
            ht.Add('a', 1000);
            ht.Add("A",30);
            foreach (var val in ht.Keys)
            {
                Console.WriteLine(val);
                Console.WriteLine(ht[val]);
            }
            // List for the generic type
            List<int> list = new List<int>();
                list.Add(10);
            list.Add('A');
                list.Add(34);
            foreach(int val in list)
            {
                Console.WriteLine(val);
            }
            //Queue in generic
            Queue<string> gqlist = new Queue<string>();
            gqlist.Enqueue("1");
            gqlist.Enqueue("Arun");
            gqlist.Enqueue("c");
            Console.WriteLine( gqlist.Dequeue());
            foreach (var val in gqlist)
                Console.WriteLine(val);
            //stack generic type of collection
            Stack<float> gslist = new Stack<float>();
            gslist.Push(23);
            gslist.Push(12.345f);
            gslist.Push(23.123f);
            Console.WriteLine(gslist.Pop());
            Console.WriteLine(gslist.Peek());
            foreach (var s in gslist)
                Console.WriteLine(s);
            // generic Hash Table 
            HashSet<int> hs = new HashSet<int>();
            hs.Add(100);
            hs.Add(23);
            hs.Add(1000);
            hs.Add(30);
            foreach (var val in hs)
            {
                Console.WriteLine(val);
            }
            // Dictionary generic form of collection
            Dictionary<int, string> dt = new Dictionary<int, string>();
            dt.Add(1,"Raj");
            dt.Add(2, "Sri");
            dt.Add(3, "Radha");
            foreach(KeyValuePair<int,string> kl in dt)
            {
                Console.WriteLine(kl.Key);
                Console.WriteLine(kl.Value);
            }
            Console.WriteLine("Enter Number of Employees You Have to enter");
            int count;
            count = int.Parse(Console.ReadLine());
            Dictionary<string, float> ES= new Dictionary<string, float>();
            for (int i = 0; i <count; i++)
            {
                String name = Console.ReadLine();
                float salary = float.Parse(Console.ReadLine());
                ES.Add(name, salary);
            }
            foreach(KeyValuePair<string,float> s1 in ES)
            {
               Console.WriteLine(s1.Key);
               Console.WriteLine(s1.Value);
            }
            float max = 0;
            /*
            for (int i = 0; i < count; i++)
            {
            if (ES.Values.ElementAt(i) > max)
              max = ES.Values.ElementAt(i);
            }
            */
           String hname="";
           foreach(KeyValuePair<string,float> s2 in ES)
           {
              if(s2.Value>max)
              {
                   max = s2.Value;
                   hname = s2.Key;
              }
           }
            Console.WriteLine("Highest Paid Employee:" + hname);
            Console.ReadLine();
        }
    }
}
