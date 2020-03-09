using System;
using EFCOREDBFirst.Models;

namespace EFCOREDBFirstClient
{
    class Program
    {
        static void Main(string[] args)
        {
            using (PracticeDBContext db = new PracticeDBContext())
            {
                Product p = new Product() { Name = "Dotnet" };
                db.Add(p);
                //db.Remove(p);
                db.SaveChanges();
            }
        }
    }
}

