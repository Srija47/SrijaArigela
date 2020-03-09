using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine(num / 2);
                try
                {
                    int[] a = new int[] { 1, 2, 3 };
                    Console.WriteLine(a[3]);
                }
                catch(IndexOutOfRangeException e)
                {
                    Console.WriteLine(e.Message + " " + e.Source + " " + e.StackTrace);
                }
            }
            
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message+ " " +e.Source+ " "+e.StackTrace);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message + " " + e.Source + " " + e.StackTrace);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + " " + e.Source + " " + e.StackTrace);
            }
            finally
            {
            Console.WriteLine("Program ended");
            }
            Console.ReadLine();
        }
    }
}
