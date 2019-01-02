using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using OQS.Models;

namespace OQS.APIcontroller
{
    public class EmployeeController : ApiController
    {
        // GET api/employee
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET api/employee/5
        [HttpGet]
        public IEnumerable<Employee> GetEmployee()
        {
            Employee employee = new Employee();
            List<Employee> employees = new List<Employee>();
          
                employee.CompanyCode = "BIZ001";
                employee.CompnayName = "Bizense";
                employee.DepartmentCode = "DevOpps001";
                employee.DepartmentName = "Devlopment";
                employee.EmployeeCode = "EMP001";
                employee.EmployeeName = "Ganesh Vahinde";

            employees.Add(employee);
            return employees;
        }

        // POST api/employee
        public void Post([FromBody]string value)
        {
        }

        // PUT api/employee/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/employee/5
        public void Delete(int id)
        {
        }
    }
}
