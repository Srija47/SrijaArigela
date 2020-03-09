using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CASESTUDY.Models;
using Microsoft.EntityFrameworkCore;

namespace CaseStudy.Controllers
{
    public class BuyerController : Controller
    {
        public readonly BuyerContext _context;
        public BuyerController(BuyerContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public ActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignUp(Buyer b)
        {
            try
            {
                _context.Add(b);
                _context.SaveChanges();
                ViewBag.message = b.Username + "has got successfully registered";
                return RedirectToAction("SignIn");
            }
            catch (Exception e)
            {
                ViewBag.message = b.Username + "Registration failed ";
                return View();
            }

        }
        [HttpGet]
        public ActionResult SignIn()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignIn(Buyer b)
        {
            var logUser = _context.Buyers.Where(e => e.Username == b.Username && e.Password == b.Password).ToList();
            if (logUser.Count == 0)
            {
                ViewBag.message = "Not valid User";
                return View();
            }
            else
            {//to store session values
                HttpContext.Session.SetString("UName", b.Username);
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
        public ActionResult LogOut()
        {
            Response.Cookies.Append("lastLogin", DateTime.Now.ToString());
            HttpContext.Session.Clear();
            return RedirectToAction("SignIn");
        }
        // GET: CookieSession
        public async Task<IActionResult> Index()
        {
            return View(await _context.Buyers.ToListAsync());
        }

        // GET: CookieSession/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var buyer = await _context.Buyers
                .FirstOrDefaultAsync(m => m.BId == id);
            if (buyer == null)
            {
                return NotFound();
            }

            return View(buyer);
        }

        // GET: CookieSession/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CookieSession/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CookieSession/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var buyer = await _context.Buyers.FindAsync(id);
            if (buyer == null)
            {
                return NotFound();
            }
            return View(buyer);
        }
        // POST: CookieSession/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Bid,UserName,Password,Email,MobileNo")] Buyer buyer)
        {
            if (id != buyer.BId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(buyer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BuyerExists(buyer.BId))

                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(buyer);
        }

        // GET: CookieSession/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var buyer = await _context.Buyers
                .FirstOrDefaultAsync(m => m.BId == id);
            if (buyer == null)
            {
                return NotFound();
            }

            return View(buyer);
        }
        // POST: CookieSession/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var buyer = await _context.Buyers.FindAsync(id);
            _context.Buyers.Remove(buyer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        private bool BuyerExists(int id)
        {
            return _context.Buyers.Any(e => e.BId == id);
        }
    }
}