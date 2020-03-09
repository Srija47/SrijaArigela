using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnConditional_Statements
{
    class Program
    {
       public static String EvenorOdd(int i )
            {
                if (i % 2 == 0)
                {
                    return "Even"; 
                }
                else
                {
                    return "Odd";
                }
            }
        public static int Max(int i,int j, int k)
        {
            if (i > j)
            {
                if (i > k)
                    return i;
                else 
                    return j;
            }
            else
            {
                if(j>k)

                    return j;
                else 
                    return k;
            }
        }
         
        public static string Result(double m1,double m2,double m3,double m4,double m5)
        {
            double avg = (m1 + m2 + m3 + m4 + m5)/5;
            if (avg >= 70)
                return "Distiction";
            else if (avg >= 60 && avg < 70)
                return "FirstClass With" + avg +"%";
            else if (avg >= 50 && avg < 60)
                return "SecondClass With" + avg + "%";
            else
                return "Fail";
        }
        static void Main(string[] args)
            {
            //Console.WriteLine("Enter number:");
            //int i = int.Parse(Console.ReadLine());
            //String result= EvenorOdd(i);
            //Console.WriteLine("Enter numbers:");
            //Console.WriteLine(result);
            //Console.WriteLine(Max(12, 23, 19));
            //int i = int.Parse(Console.ReadLine());
            //int j = int.Parse(Console.ReadLine());
            //int k = int.Parse(Console.ReadLine());
            //Console.WriteLine(Max(i,j,k));
            Console.WriteLine(Result(87.5, 56.6, 49.5, 89, 90));
            double m1 = Convert.ToDouble(Console.ReadLine());
            double m2 = Convert.ToDouble(Console.ReadLine());
            double m3 = Convert.ToDouble(Console.ReadLine());
            double m4 = Convert.ToDouble(Console.ReadLine());
            double m5 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Result(m1,m2,m3,m4,m5));
            Console.ReadKey();
        }
    }
}
