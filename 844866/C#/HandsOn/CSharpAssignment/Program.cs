using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment
{
    class Program
    {
        public static void Display(int a, int b)
       {
            for(int i=a+1;i<=b-1;i++)
            {
                Console.Write(i+"\t");
            }

        }
        public static void EvenOrOdd(int c)
        {
            if (c % 2 == 0)
                Console.WriteLine( "Even");
            else
                Console.WriteLine( "Odd");
        }
        public static void CountEvenOrOdd(int d,int e)
        {
            int c1 = 0, c2=0 ;
            for (int i = d; i <=e;i++)
            {
                if (i == 0)
                    break;
                else if (i % 2 == 0)
                    c1++;
                else
                    c2++;
             }
            Console.WriteLine("No of Even Nos" + c1);
            Console.WriteLine("No of Even Nos" + c2);
        }

        public static void Squares(int f)
        {
            int i = 0;
            while (i <= f)
            {
                int j = i * i;
                Console.Write(+j + "\t");
                i++;
            }
        }
        public static int Factorial(int number)
        {
            int i=1;
            int fact = 1;
            do
            {
                fact = fact * i;
                i++;
            } while (i <= number);
            return fact;
        }
        public static void Fibonacci(int num)
        {
            int f1 = 0, f2 = 1, f3;
            Console.Write(f1 + "" + f2 + "");
            for(int i=0;i<=num;i++)
            {
                f3 = f1 + f2;
                f1 = f2;
                f2 = f3;
                Console.Write(+f3 + "\t" + " ");
            }
        }
        public static void Multiplication(int h)
        {
            int j;
            for(int i=1;i<=20;i++)
            {
                j = h * i;
                Console.WriteLine(+h + " * " + i + " = " + j);
            }
        }
        public static void DivisibleBySeven(int j,int k)
        {
            for(int i=j;i<=k;i++)
            {
                if (i % 7 == 0)
                    Console.WriteLine(i);
            }
        }
        public static void DisplayStringLength(string str)
        {
            int l = 0;
            foreach (char ch in str)
            {
                l += 1;
            }
            Console.Write(l);
        }
        static void Main(string[] args) 
        {
            Console.WriteLine("Welcome to the world of C#");
            string name = Console.ReadLine();
            Console.WriteLine("Hi!" +  name + "\nWelcome to the World of C#");
            Console.WriteLine("\nGive two Numbers to display all numbers in between them.\n");
           int a = int.Parse(Console.ReadLine());
           int b = int.Parse(Console.ReadLine());
           Display(a, b);
            //Even or odd
           Console.WriteLine("\nGive a Number to check given number is Even OR Odd.\n");
           int c = int.Parse(Console.ReadLine());
           EvenOrOdd(c);
            Console.WriteLine("\nGive a Number to count Number of Even and Number of Odd.\n");
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());
            CountEvenOrOdd(d,e);
            Console.WriteLine("\nPrint Square series of Natural Numbers\n");
            int f = int.Parse(Console.ReadLine());
            Squares(f);
            Console.WriteLine("\nFactorial of a Given Number\n");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(Factorial(number));
            Console.WriteLine("\nFibonacci Series of a Given Number\n");
            int num = int.Parse(Console.ReadLine());
            Fibonacci(number);
            Console.WriteLine("\nMultiplication Table of a Given Number\n");
            int h = int.Parse(Console.ReadLine());
            Multiplication(h);
            Console.WriteLine("\nCheck Whether the Given Number is divisible by 7\n");
            int j = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            DivisibleBySeven(j,k);
            Console.WriteLine("\nDisplay Length of the given word\n");
            string str =Console.ReadLine();
            DisplayStringLength(str);
            Console.ReadKey();

        }
    }
}
