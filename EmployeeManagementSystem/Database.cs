using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    public class Database
    {
        public List<Employee> EmployeeList { set; get; }
        public List<Manager> ManagerList { set; get; }
        public Database()
        {
            EmployeeList = new List<Employee>();
            ManagerList = new List<Manager>();
        }
        public void AddEmployee(Employee emp)
        {
            EmployeeList.Add(emp);
        }
        public void AddManager(Manager mng)
        {
            ManagerList.Add(mng);
            AddEmployee(mng);
        }
    }
}
