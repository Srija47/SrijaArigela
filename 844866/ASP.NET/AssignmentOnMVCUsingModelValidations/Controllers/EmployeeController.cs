using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AssignmentOnMVCUsingModelValidations.Models;
using AssignmentOnMVCUsingModelValidations.Repositories;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AssignmentOnMVCUsingModelValidations.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Designation = new SelectList(new string[] { "FSE", "PAT", "Analyst Trainee", "HR" });
            ViewBag.ProjectName = new SelectList(new string[] { "Java", ".net", "Python" });
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee item)
        {
            EmployeeRepository repository = new EmployeeRepository();
            repository.Add(item);
            return RedirectToAction("Login");
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(int eid, string pwd)
        {
            EmployeeRepository repository = new EmployeeRepository();
            Employee employee = repository.Validate(eid, pwd);
            if (employee != null)
            {
                return RedirectToAction("Details", employee);
            }
            else
            {
                ViewData["err"] = "Invalid Credentials";
                return View();
            }

        }
        public IActionResult Details(Employee item)
        {
            return View(item);
        }
        public IActionResult Greet(int eid)
        {
            return View();
        }
    }
}
