using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectCollection
{
    class Employee
    {
        public string name;
        public string empId;
        public int salary;
        public Employee()
        {

        }
        public Employee(string name, string empId, int salary)
        {
            this.name = name;
            this.empId = empId;
            this.salary = salary;
        }
        public override string ToString()
        {
            return this.name + " \n" + this.empId + "\n " + this.salary + "";
        }
        public override bool Equals(object obj)
        {
            Employee temp = (Employee)obj;
            if (this.empId == temp.empId && this.name == temp.name)
                return true;
            else
                return false;
        }
    }
}
