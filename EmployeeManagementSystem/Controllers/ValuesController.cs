using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        Database d = new Database();

        public void DatabaseCreation()
        {
            Employee e1 = new Employee("E1", "Ashish", 50000, 26, "Flights", "SDE");
            d.AddEmployee(e1);
            Employee e2 = new Employee("E2", "Bunty", 40000, 23, "Flights", "SDE");
            d.AddEmployee(e2);
            Employee e3 = new Employee("E3", "Chandan", 45000, 25, "Enablment", "SDE");
            d.AddEmployee(e3);
            Employee e4 = new Employee("E4", "Rakesh", 60000, 27, "Flights", "SDE");
            d.AddEmployee(e4);
            Employee e5 = new Employee("E5", "Ankit", 40000, 24, "Enablement", "SDE");
            d.AddEmployee(e5);
            Employee e6 = new Employee("E6", "Mukesh", 55000, 25, "GCE", "SDE");
            d.AddEmployee(e6);
            List<Employee> List1 = new List<Employee>();
            List<Employee> List2 = new List<Employee>();
            List<Employee> List3 = new List<Employee>();
            List1.Add(e6);
            List2.Add(e1);
            List2.Add(e2);
            List2.Add(e4);
            List3.Add(e3);
            List3.Add(e5);
            Manager m1 = new Manager("M1", "Pankaj", 80000, 25, "GCE", "IM", List1);
            d.AddManager(m1);
            Manager m2 = new Manager("M2", "Pramod", 80000, 25, "Flights", "IM", List2);
            d.AddManager(m2);
            Manager m3 = new Manager("M3", "Animesh", 80000, 25, "Enablment", "IM", List3);
            d.AddManager(m3);           
        }
        [HttpGet("{item}/{id}")]
        public ActionResult<string> Get(string item, string id)
        {
            DatabaseCreation();
            if(item.ToLower()=="manager")
            {
                for(int i=0;i<9;i++)
                {
                    if(id==)
                }
            }
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
