using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CASESTUDY.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace CASESTUDY.Controllers
{
    public class SellerController : Controller
    {
        public readonly SellerContext _context;
        public readonly IWebHostEnvironment hostingEnvironment;
        public SellerController(SellerContext context,IWebHostEnvironment hostingEnvironment)
        {
            this._context = context;
            this.hostingEnvironment = hostingEnvironment;
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpGet]
        public ActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignUp(Seller s)
        {
            try
            {
                _context.Add(s);
                _context.SaveChanges();
                ViewBag.message = s.SName + "has got successfully registered";
                return RedirectToAction("SignIn");
            }
            catch (Exception e)
            {
                ViewBag.message = s.SName + "Registration failed ";
                return View();
            }

        }
        [HttpGet]
        public ActionResult SignIn()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignIn(Seller s)
        {
            var logUser = _context.Sellers.Where(e => e.SName == s.SName && e.Password == s.Password).ToList();
            if (logUser.Count == 0)
            {
                ViewBag.message = "Not valid User";
                return View();
            }
            else
            {
                HttpContext.Session.SetString("UName", s.SName);
                HttpContext.Session.SetString("lastLogin", DateTime.Now.ToString());
                return RedirectToAction("CreateDashBoard");
            }

        }
        public ActionResult CreateDashBoard()
        {
            if (HttpContext.Session.GetString("UName") != null)
            {
                ViewBag.uname = HttpContext.Session.GetString("UName").ToString();
                ViewBag.lldt = HttpContext.Session.GetString("lastLogin").ToString();
                if (Request.Cookies["lastLogin"] != null)
                {
                    ViewBag.lldt = Request.Cookies["lastLogin"].ToString();
                }
            }
            return View();
        }
        // GET: CookieSession
        public ActionResult LogOut()
        {
            Response.Cookies.Append("lastLogin", DateTime.Now.ToString());
            HttpContext.Session.Clear();
            return RedirectToAction("SignIn");
        }
        // GET: Buyer
        public ActionResult Index()
        {
            return View();
        }

        // GET: Buyer/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        // GET: Buyer/Create
        

        // POST: Buyer/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SellerCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = null;

                // If the Photo property on the incoming model object is not null, then the user
                // has selected an image to upload.
                if (model.Photopath != null)
                {
                    // The image must be uploaded to the images folder in wwwroot
                    // To get the path of the wwwroot folder we are using the inject
                    // HostingEnvironment service provided by ASP.NET Core
                    string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "Images");
                    // To make sure the file name is unique we are appending a new
                    // GUID value and and an underscore to the file name
                    uniqueFileName = Guid.NewGuid().ToString() + "_" + model.Photopath.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                    // Use CopyTo() method provided by IFormFile interface to
                    // copy the file to wwwroot/images folder
                    model.Photopath.CopyTo(new FileStream(filePath, FileMode.Create));
                }

                Seller newSeller = new Seller
                {
                    SName = model.SName,
                    Email = model.Email,
                    Password = model.Password,
                    CompanyName=model.CompanyName,
                    ContactNumber=model.ContactNumber,
                    Brief_abt_Company=model.Brief_abt_Company,
                    Postal_Address=model.Postal_Address,
                    GSTIN=model.GSTIN,
                    Website=model.Website,
                    // Store the file name in PhotoPath property of the employee object
                    // which gets saved to the Employees database table
                    Photopath = uniqueFileName
                };

                _context.Add(newSeller);
                _context.SaveChanges();
                return RedirectToAction("Details", new { id = newSeller.SId });
            }

            return View();
        }
        public ActionResult Details(int id)
        {

            var seller = _context.Sellers.FirstOrDefault(m => m.SId == id);
            return View(seller);
        }
        // GET: Buyer/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Buyer/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Buyer/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Buyer/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}