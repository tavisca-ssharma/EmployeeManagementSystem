using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    public class Employee
    {
        public string id { set; get; }
        public string name { set; get; }
        public long salary { set; get; }
        public int age { set; get; }
        public string department { set; get; }
        public string designation { set; get; }
        
        public Employee(string Id, string Name, long Salary, int Age, string Department, string Designation)
        {
            Id = id;
            Name = name;
            Salary = salary;
            Age = age;
            Department = department;
            Designation = designation;

        }
         public string GetEmployeeDetails()
        {
            return $"Id : {id}, Name : {name}, Salary : {salary}, Age : {age}, Department : {department}, Designation : {designation} ";
        }
    }
}
