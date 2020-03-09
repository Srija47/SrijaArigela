using OrderService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderService.Repositories
{
    public class OrderRepository: IOrderRepository
    {
        private readonly ShopDBContext _context;
        public OrderRepository(ShopDBContext context)
        {
            _context = context;
        }
        public List<Orders> GetAllOrders()
        {
            return _context.Orders.ToList();
        }

        public Orders GetById(string Id)
        {
            return _context.Orders.Find(Id);
        }

        public void AddOrders(Orders obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public void DeleteOrders(string id)
        {
            Orders order = _context.Orders.Find();
            _context.SaveChanges();
            _context.Remove(order);
        }

        public void UpdateOrders(Orders obj)
        {
            _context.Orders.Update(obj);
            _context.SaveChanges();
        }

    }
}