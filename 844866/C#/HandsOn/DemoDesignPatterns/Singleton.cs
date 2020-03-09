using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDesignPatterns
{
    sealed class Singleton
    {
        static int count = 0;
        static Singleton Instance=null;//memeory not alloted so object does not exist
        public static Singleton GetInstance
        {
            get
            {
                //instance is null memory will be alloted
                if (Instance == null) return new Singleton();
                else return Instance;// existing Instance ref returned.
            }
        }
        private Singleton()//constructor private
        {
            count++;
            Console.WriteLine(count);
        }
        public void printDetails(string s)
        {
            Console.WriteLine("Printing "+ s);
        }
    }
}
