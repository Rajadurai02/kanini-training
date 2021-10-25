using FinalFlowerAPIApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalFlowerAPIApplication.Services
{
    public class FlowerOrderService
    {
        private readonly CompanyContext _context;

        public FlowerOrderService(CompanyContext context)
        {
            _context = context;
        }
        public List<FlowerOrder> AllFlowerOrders()
        {
            List<FlowerOrder> flowerOrders;
            flowerOrders = _context.FlowerOrders.ToList();
            return flowerOrders;
        }
        public FlowerOrder GetFlowerOrder(int id)
        {
            FlowerOrder flowerOrder = null;
            flowerOrder = _context.FlowerOrders.FirstOrDefault(p => p.ItemID == id);
            return flowerOrder;
        }
        public FlowerOrder AddFlowerOrder(FlowerOrder flowerOrder)
        {
            FlowerOrder newFlowerOrder = new FlowerOrder();
            newFlowerOrder.OrderID = flowerOrder.OrderID;
            newFlowerOrder.FlowerID = flowerOrder.FlowerID;
            newFlowerOrder.Qty = flowerOrder.Qty;
            _context.FlowerOrders.Add(newFlowerOrder);
            _context.SaveChanges();
            return newFlowerOrder;
        }
        public FlowerOrder EditFlowerOrder(int id, FlowerOrder flowerOrder)
        {
            FlowerOrder newFlowerOrder = null;
            newFlowerOrder = _context.FlowerOrders.FirstOrDefault(p => p.ItemID == id);
            newFlowerOrder.OrderID = flowerOrder.OrderID;
            newFlowerOrder.FlowerID = flowerOrder.FlowerID;
            newFlowerOrder.Qty = flowerOrder.Qty;
            _context.FlowerOrders.Update(newFlowerOrder);
            _context.SaveChanges();
            return newFlowerOrder;
        }
        public FlowerOrder RemoveFlowerOrder(int id)
        {
            FlowerOrder flowerOrder = null;
            flowerOrder = _context.FlowerOrders.FirstOrDefault(p => p.ItemID == id);
            _context.FlowerOrders.Remove(flowerOrder);
            _context.SaveChanges();
            return flowerOrder;
        }
    }
}
