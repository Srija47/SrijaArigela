using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIDemo2.Repositories;
using APIDemo2.Models;

namespace APIDemo2.Repositories
{
    public class EmployeeRepository
    {
        //Get all Employees
        public List<Employee> GetAll()
        {
            using (EmpDBContext db = new EmpDBContext())
            {
                return db.Employee.ToList();
            }
        }
        //Get employee by id
        public Employee GetById(string id)
        {
            using (EmpDBContext db = new EmpDBContext())
            {
                return db.Employee.Find(id);

            }
        }
        //Add Employee
        public void Add(Employee item)
        {
            using (EmpDBContext db = new EmpDBContext())
            {
                db.Employee.Add(item);
                db.SaveChanges();
            }
        }
        //Delete Record
        public void Delete(string id)
        {
            using (EmpDBContext db = new EmpDBContext())
            {
                Employee e = db.Employee.Find(id);
                db.Employee.Remove(e);
                db.SaveChanges();
            }
        }
        //update record
        public void Update(Employee item)
        {
            using (EmpDBContext db = new EmpDBContext())
            {
                db.Employee.Update(item);
                db.SaveChanges();
            }
        }

    }

}
