using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Web;
using Employee.Models;
using Microsoft.AspNetCore.Authorization;

namespace Employee.Controllers
{
    public class EmployeeController:Controller
    {
        //IEmployeeRepository employeeRepository = new EmployeeRepository();
       private readonly IEmployeeRepository employeeRepository;//dependency injection obj
        public EmployeeController(IEmployeeRepository emRepository)
        {
            employeeRepository = emRepository;
        }
        public IActionResult Search(int? id)
        {
            int ID = (int)((id == null) ? 1 : id);
            Employee1 emp=employeeRepository.GetEmployee1(ID);
            //if (emp != null)
            //{
            //    return Content(emp.Id + "\n" + emp.Name + "\n" + emp.Email + "\n" + emp.Dept);
            //}
            //return Content("Employee does not exist");
            //ViewData["id"] = emp.Id;
            //ViewData["name"] = emp.Name;
            //ViewData["email"] = emp.Email;
            //ViewData["Dept"] = emp.Dept;
            //return View();
            //ViewBag.id = emp.Id;
            //ViewBag.name = emp.Name;
            //ViewBag.email = emp.Email;
            //ViewBag.Dept = emp.Dept;
            //return View();
            //ViewData["employee"] = emp;
            //ViewBag.employee = emp;
            //return View();
            return View(emp);
        }
        public IActionResult Index()
        {
            List<Employee1> elist = employeeRepository.DisplayDetails();
            return View(elist);
        }
        //public string Index()
        //{
        //    return "Hello from MVC Index";
        //}
        //public ViewResult AboutUs()
        //{
        //    return View();
        //}
        public ViewResult AboutEmployee()
        {
            Employee1 emp = employeeRepository.GetEmployee1(2);
            //ViewBag.projectName = "BookHive";
            EmployeeProjectViewModel ep = new EmployeeProjectViewModel();
            ep.employee = emp;
            ep.projectName = "BookHive";
            return View(emp);
        }
        public IActionResult GetAllEmployees()
        {
            List<Employee1> elist = (employeeRepository.DisplayDetails()).Where(e => e.Dept == Dept.Insurance).ToList();
            //absolute path to refer a view
            //return View("~/Views/Employee1/Index.cshtml",elist);
            return View("Index", elist);
        }
        [HttpGet]
        public IActionResult Create()
        {
            //Employee1 emp = employeeRepository.GetEmployee1(2);
            //return View(emp);
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee1 emp)
        {
            if (ModelState.IsValid)
            {
                employeeRepository.AddEmployee(emp);
                return RedirectToAction("Index");
            }
            //else
            //{
            //    return View("Fail");
            //}
            return View();
        }
        public bool IsExist(string email)
        {
            var result = (employeeRepository.DisplayDetails()).Find(r => r.Email == email);
            if (result == null)
                return true;
            else return false;
        }
        [AcceptVerbs("Get","Post")]
        //[AllowAnonymous]
        public JsonResult IsEmailExist(string email)
        {
            return IsExist(email) ? Json(true) : Json("Email exist");
        }
        public IActionResult _myPartial()
        {
            return View();
        }
        public IActionResult Fail()
        {
            return View();
        }
        public IActionResult Success()
        {
            return View();
        }
        public IActionResult List()
        {
            List<Employee1> elist = employeeRepository.DisplayDetails();
            return View(elist);
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(Employee1 emp)
        {
          bool res=  employeeRepository.AddEmployee(emp);
            //return View();
            return RedirectToAction("Index");
        }
    }
}
