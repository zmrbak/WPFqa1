using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFQ017
{
    //公司
    public class Company
    {
        public String Name { get; set; }
        public List<Department> Departments { set; get; }
    }

    //部门
    public class Department
    {
        public String Name { get; set; }
        public List<Employee> Employees { set; get; }
    }

    //员工
    public class Employee
    {
        public String Name { get; set; }
    }
}
