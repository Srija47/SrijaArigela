using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoString
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string str = "Welcome";
            Console.WriteLine(str.Length+ "" +str.Replace("e","k")+" "+str.ToLower()+" " +str.ToUpper());
            Console.WriteLine(str.Contains("lc"));
            Console.WriteLine(String.Compare("Hello","hello"));
            Console.WriteLine(str.Insert(5,"hello"));
            Console.WriteLine(str.TrimStart('w'));
            Console.WriteLine(str.TrimEnd('m'));
            string str2 = "WELCOME";
            Console.WriteLine(str.Equals(str2,StringComparison.InvariantCultureIgnoreCase));
            string s1 = "cts";
            string s = "welcome";
            string str4 = String.Empty;
            // int i = s.IndexOfAny(c);
            //Console.WriteLine(i);
            //Console.WriteLine(n);
            s = s.Remove(3);
            Console.WriteLine(s);
            s = s.Replace('e','d');
            Console.WriteLine(s);
            s = string.Concat(s, "CTS");
            Console.WriteLine(s);
            string input = Console.ReadLine();
            string[] data = input.Split(' ', '/');
            int[] num2 = Array.ConvertAll(data,Convert.ToInt32 );
            int[] num = new int[data.Length];
            for(int j=0;j<data.Length;j++)
            {
                num[j] = Convert.ToInt32(data[0]);
            }
            foreach (string val in data)
            { Console.WriteLine(val); }

            foreach (int val in num2)
            { Console.WriteLine(val); }
            int k = 90;
            double d = 2.345;
            Console.WriteLine(k.ToString() + " " + d.ToString());
            DateTime dt = DateTime.Now;
            Console.WriteLine(dt.ToString("dddd/MMMM/yyyy")+" "+dt.ToString("dddd/MM/yyyy") + " "+dt.ToString("MMM/dd/yyyy \t HH:mm:ss") + " ");
            */
            int[] ix = new int[] { 1, 2, 3, 4 };
            foreach (int i in ix)
            {
                Console.WriteLine(i);
            }
            Employee[] eArray = new Employee[3] { new Employee("arun", "100", 20000) , 
                                                new Employee("Raj", "200", 40000),
                                                new Employee("renu", "300", 60000)   };
            foreach(Employee e in eArray)
            {
                Console.WriteLine(e.ToString());
            }
            List<Employee> elist = new List<Employee>();
                elist.Add(new Employee("arun", "100", 20000));
            elist.Add(new Employee("Raj", "200", 40000));
            elist.Add(new Employee("renu", "300", 60000));
            foreach (Employee e in elist)
            {
                Console.WriteLine(e.ToString());
            }
            Employee e1=new Employee("Rani", "1200", 450000);
            Employee e2 = new Employee("Rani", "19200", 450000);
            if (e1.Equals(e2))
            {
                Console.WriteLine("Both are same Employee");
            }
            else
                Console.WriteLine("Not Same");
            Console.ReadLine();   
        }
    }
}
