using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Diviya_MVC.Controllers
{
    public class Employee1Controller : Controller
    {
        public ActionResult Index1()
        {
            EmployeeBusinessLayer employeeBusinessLayer =
                new EmployeeBusinessLayer();

            List<Employee> employees = employeeBusinessLayer.Employees.ToList();
            return View(employees);
        }
    }
}