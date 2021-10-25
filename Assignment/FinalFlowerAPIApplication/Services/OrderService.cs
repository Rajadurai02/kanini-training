using FinalFlowerAPIApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalFlowerAPIApplication.Services
{
    public class OrderService
    {
        private readonly CompanyContext _context;

        public OrderService(CompanyContext context)
        {
            _context = context;
        }
        public List<Order> AllOrders()
        {
            List<Order> orders;
            orders = _context.Orders.ToList();
            return orders;
        }
        public Order GetOrder(int id)
        {
            Order order = null;
            order = _context.Orders.FirstOrDefault(p => p.OrderID == id);
            return order;
        }
        public Order AddOrder(Order order)
        {
            Order newOrder = new Order();
            newOrder.UserEmail = order.UserEmail;
            newOrder.TotalAmount = order.TotalAmount;
            _context.Orders.Add(newOrder);
            _context.SaveChanges();
            return newOrder;
        }
        public Order EditOrder(int id, Order order)
        {
            Order newOrder = null;
            newOrder = _context.Orders.FirstOrDefault(p => p.OrderID == id);
            newOrder.UserEmail = order.UserEmail;
            newOrder.TotalAmount = order.TotalAmount;
            _context.Orders.Update(newOrder);
            _context.SaveChanges();
            return newOrder;
        }
        public Order RemoveOrder(int id)
        {
            Order order = null;
            order = _context.Orders.FirstOrDefault(p => p.OrderID == id);
            _context.Orders.Remove(order);
            _context.SaveChanges();
            return order;
        }
    }
}
