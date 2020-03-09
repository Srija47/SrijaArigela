using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Account ac = new Account();
            Console.WriteLine("Enter the Account Number:");
            int accno = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Account Holder Name:");
            string acc_name = Console.ReadLine();
            Console.WriteLine("Enter the Account Type:");
            string ac_type = Console.ReadLine();
            Console.WriteLine("Enter the Initial Amount:");
            double amount = double.Parse( Console.ReadLine());
            Account ac1 = new Account(accno, acc_name, ac_type,amount);
            Console.WriteLine("Enter Transaction Type:");
            string trans_type = Console.ReadLine();
            if(trans_type=="d"|| trans_type == "D")
            {
                Console.WriteLine("Enter Amount to deposit:");
                int c = int.Parse(Console.ReadLine());
                ac.credit(c);
            }
            else if(trans_type == "w" || trans_type == "W")
            {
                Console.WriteLine("Enter Amount to WithDraw:");
                int d = int.Parse(Console.ReadLine());
                ac.Debit(d);
            }
            else
            {
                Console.WriteLine("Invalid Inputs\n");
            }
            Console.ReadLine();

        }
    }
}
