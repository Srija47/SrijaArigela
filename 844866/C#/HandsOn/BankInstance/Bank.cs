using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankInstance
{
    interface Loan
    {
        void getInterest();
    }
    interface GLoan:Loan
    {
        void GoldInterest();
    }
    interface Dmt
    {
        void DisplayDmt();
    }
    public abstract class Bank
    {
        protected string bname;
        protected string location;
        public Bank(string bname,string location)
        {
            this.bname = bname;
            this.location = location;
        }
    }
    public class SBI : Bank,Loan,GLoan
    {
        string bManager;
        public SBI(string bname,string location,string bmgr):base(bname,location)
        {
            this.bManager = bmgr;
        }
        public void GoldInterest()
        {
            Console.WriteLine("SBI Gold Loan Interest is 7.2%");
        }
        public void getInterest()
        {
            Console.WriteLine("SBI Loan Interest is 12%");
        }
        public void DisplayDetails()
        {
            Console.WriteLine(this.bname+"  "+this.location +"  " + this.bManager+ "  ");
        }
    }
    public class ICICI:Bank,Dmt
    {
        string bHead;
        public ICICI(string bname, string location, string bhead) : base(bname, location)
        {
            this.bHead = bhead;
        }
        public void getInterest()
        {
            Console.WriteLine("ICICI Loan Interest is 22%");
        }
        public void DisplayDmt()
        {
            Console.WriteLine("ICICI can start demat accounts");
        }
        public void DisplayDetails()
        {
            Console.WriteLine(this.bname + "  " + this.location + "  " + this.bHead + "  ");
        }
    }
}

