using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnIterativeStatements
{
    class Program
    {
        public static void Greet(string name)
        {
            int flag = 1;
            while(flag<=10)
            {
                Console.WriteLine("Hello " + name);
                flag++;
            }
        }
        public static void DisplayNaturalNos(int i)
        {
            int flag = 1;
            while(flag<=i)
            {
                Console.Write(flag + " ");
                flag++;
            }
        }
        public static void DisplayWholeNos(int i)
        {
            int flag = 0;
            do
            {
                Console.Write(flag + "\t");
                flag++;
            } while (flag <= i);
        }
        public static int ReturnFactorial(int n)
        {
            int fact = 1;
            for(int i=1;i<=n;i++)
             {
                fact = fact * i;
             }

            // int i = 1;
            //for (; i <= n; i++)
            // {
            //     fact = fact * i;
            // }

           // int i = 1;
            //for (; i <= n;)
            //{
             //   fact = fact * i;
              //  i++;
           // }

           // int i = 1;
            //for (; ; )
            //{
              //  if (i <= n)
              //  {
               //     fact = fact * i;
              //      i++;
              //  }
             //   else
                 //   break;//terminating loop
           // }
           return fact;
        }
        public static void DisplayEven(int n)
        {
            for(int j=1;j<=n;j++)
            {
                if(j%2==1)
                    continue;
                Console.Write(j + "\t");
            }
        }
        public static string CheckVowel(char ch)
        {
            string result = null;
            switch(ch)
            {
                case 'a':
                    result = "Vowel";
                    break;
                case 'e':
                    result = "Vowel";
                    break;
                case 'i':
                    result = "Vowel";
                    break;
                case 'o':
                    result = "Vowel";
                    break;
                case 'u':
                    result = "Vowel";
                    break;
                default: 
                    result = "Invalid Input";
                    break;
            }
            return result;

        }
        public static void Menu(int c)
        {
            Console.WriteLine("Enter Your Choice : ");
            int ch = int.Parse(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    if (c % 2 == 0)
                        Console.WriteLine("Even");
                    else
                        Console.WriteLine("Odd");
                    break;
                case 2:
                    for(int i=1;i<=c;i++)
                    {
                        Console.Write(i + "\t");
                    }
                    break;
                case 3:
                    for(int i=1;i<=20;i++)
                    {
                        int j;
                        j= c* i;
                        Console.WriteLine( c+ " * " +i+ " = " +j);
                    }
                    break;
                case 4:
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
        }
        static void Main(string[] args)
        {
            //Greet("Naani");
            //DisplayNaturalNos(100);
            // DisplayWholeNos(40);
            //Console.WriteLine(ReturnFactorial(5));
            // Console.WriteLine(CheckVowel('o'));
            //Console.WriteLine(CheckVowel('0'));
            //Console.WriteLine(CheckVowel('J'));
            //DisplayEven(100);
            Console.WriteLine("Please Enter your No : \t");
            int c = int.Parse(Console.ReadLine());
           Console.WriteLine(" 1.Even/Odd\n 2. Natural Numbers\n 3.Multiplication Table\n 4.Exit\n");
            Menu(c);
            Console.ReadKey();
        }
    }
}
