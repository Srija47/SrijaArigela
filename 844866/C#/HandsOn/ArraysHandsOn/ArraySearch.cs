using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysHandsOn
{
    class ArraySearch
    {
        static void Main()
        {
            string[] names = new string[8]
            {
              "Rohan",
              "Smiley",
              "Jeson",
              "Monica",
              "Sachin",
              "David",
              "Kalyan",
              "Jessy"
            };
            int flag = 0;
            Console.WriteLine("Enter a Name:");
            string s = Console.ReadLine();

            foreach(string i in names)
            {
                if (s == i)
                {
                    flag = 1;
                    break;
                }
                    
            }
            if (flag == 0)
            {
                Console.WriteLine("Name Not Exits");
            }
            else
            { 
                Console.WriteLine("Name Exists");
            }
            Console.ReadKey();
        }
    }
}
