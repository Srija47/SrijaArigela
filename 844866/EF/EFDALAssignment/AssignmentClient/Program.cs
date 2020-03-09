using System;
using EFDALAssignment.Context;
using EFDALAssignment.Models;

namespace AssignmentClient
{
    class Program
    {
        static void Main(string[] args)
        {
            using (MyContext db = new MyContext())
            {
                //Item p = new Item() { ItemName = "Smartphone" };
                Orders q = new Orders() { ItemID = 1 };
                //db.Add(p);
                db.Add(q);
                db.SaveChanges();
            }
        }
    }
}
