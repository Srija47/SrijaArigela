using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignList
{
    class Employee
    {
        public int empId;
        public string empName;
        public string empdes;

        public Employee(int empId, string empName, string empdes)
        {
            this.empId = empId;
            this.empName = empName;
            this.empdes = empdes;
        }
        public override string ToString()
        {
            return "TraineeName:" + this.empName + " \n" + "TraineeId:" + this.empId + "\n " + "Employee Designation:" + this.empdes + "";
        }
        public override bool Equals(object obj)
        {
            Employee temp = (Employee)obj;
            if (this.empId == temp.empId)
                return true;
            else
                return false;
        }
    }
}
