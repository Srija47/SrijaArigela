using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using APIAssignment.Models;

namespace APIAssignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        CustomerDBContext db = new CustomerDBContext();
        [HttpGet]
       public List<Customer> GetAll()
        {
            return db.Customer.ToList();
        }
        [HttpGet]
        [Route("GetById/{Cid}")]
        public Customer GetById(int Cid)
        {
            return db.Customer.Find(Cid);
        }
        [HttpGet("{city}")]
        [Route("GetByCity/{city}")]
        public List<Customer> GetByCity(string city)
        {
             return db.Customer.Where(i => i.City==city).ToList();
        }
        [HttpPost]
        [Route("AddCustomer")]
        public void Add(Customer item)
        {
            db.Customer.Add(item);
            db.SaveChanges();
        }
        [HttpPut]
        [Route("Update/{Cid}")]
        public void Update(int Cid)
        {
            Customer p = db.Customer.Find(Cid);
            p.City= "Hyderabad";
            db.Customer.Update(p);
            db.SaveChanges();
        }
    }
}

