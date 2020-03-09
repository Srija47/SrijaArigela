using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankInstance
{
    class Program
    {
        static void Main(string[] args)
        {
            ICICI chn = new ICICI("ICICI 001", "Chennai", "Arun");
            SBI hyd = new SBI("SBI 003", "Hydearabad", "Jaya");
            chn.DisplayDetails();
            chn.getInterest();
            hyd.DisplayDetails();
            hyd.getInterest();
            hyd.GoldInterest();
            Console.ReadKey();
        }
    }
}
