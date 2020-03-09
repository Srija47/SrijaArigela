using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HandsOnMVCUsingModelValidations.Models;
using HandsOnMVCUsingModelValidations.Repositories;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HandsOnMVCUsingModelValidations.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Country=new SelectList(new string[] { "","India", "China", "UK", "US" });
            return View();
        }
        [HttpPost]
        public IActionResult Create(User item)
        {
            UserRepository repository = new UserRepository();
            repository.Add(item);
            //return RedirectToAction("Login");
            if (ModelState.IsValid)
            {
                return RedirectToAction("Login");
            }
            else
                return View();
        }
       
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string uname,string pwd)
        {
            UserRepository repository = new UserRepository();
            User user = repository.Validate(uname,pwd);
            if(user!=null)
            {
                return RedirectToAction("Details",user);
            }
            else
            {
                ViewData["err"] = "Invalid Credentials";
                return View();
            }
            
        }
        public IActionResult Details(User item)
        {
            return View(item);
        }
        ////public IActionResult Details([Bind(include:"Name")]User item)
        ////{
        ////    return View(item);
        ////}
        public IActionResult Greet(int id)
        {
            return View();
        }
    }
}