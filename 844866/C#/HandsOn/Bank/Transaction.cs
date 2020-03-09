using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Account
        {
        int accno;
        double amount;
        double bal;
        string acc_name, ac_type,trans_type;
         static string bname;
            public int Accno { get => accno; set => accno = value; }
            public double Amount { get => amount; set => amount = value; }
            public string Acctype { get => ac_type; set => ac_type = value; }
            public double Balance { get => bal; set => bal = value; }
            public string Accname { get => acc_name; set => acc_name = value; }
            //static constructor 
        static Account()//use intialise static member.
        {
            bname = "SBI";
        }
            public Account(int ano, string aname, string atype,double amount)
            {
            
                this.accno = ano;
                this.acc_name = aname;
                this.ac_type = atype;
                this.bal = amount;
            }
            public void credit(int amt)
            {
                this.trans_type = "D";
                this.amount += amt;
            }
            public void Debit(int amt)
            {
                this.trans_type = "C";
                this.amount -= amt;
            }
            public void ShowData()
            {
                Console.WriteLine("Showing details of the transaction");
                Console.WriteLine("Bank Name:"+bname+"A/c No:" + this.accno + "\nA/C Name:" + this.acc_name + "\nAccount_Type:" + this.ac_type + "\nAmount:" + this.amount);
            }
        }
}
