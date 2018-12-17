using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OQS.Models;

namespace OQS.Controllers
{
    public class EmployeeController : Controller
    {
        //
        // GET: /Employee/

        public ActionResult Index()
        {
            return View();
        }
        public Employee GetEmployee()
        {
            Employee employee = new Employee();
            employee.CompanyCode = "BIZ001";
            employee.CompnayName = "Bizense";
            employee.DepartmentCode = "DevOpps001";
            employee.DepartmentName = "Devlopment";
            employee.EmployeeCode = "EMP001";
            employee.EmployeeName = "Ganesh Vahinde";

            return employee;
        }

    }
}
