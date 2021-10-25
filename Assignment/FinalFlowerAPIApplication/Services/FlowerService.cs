using FinalFlowerAPIApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalFlowerAPIApplication.Services
{
    public class FlowerService
    {
        private readonly CompanyContext _context;

        public FlowerService(CompanyContext context)
        {
            _context = context;
        }
        public List<Flower> AllFlowers()
        {
            List<Flower> flowers;
            flowers = _context.Flowers.ToList();
            return flowers;
        }
        public Flower GetFlower(int id)
        {
            Flower flower = null;
            flower = _context.Flowers.FirstOrDefault(p => p.FlowerID == id);
            return flower;
        }
        public Flower AddFlower(Flower flower)
        {
            Flower newFlower = new Flower();
            newFlower.FlowerName = flower.FlowerName;
            newFlower.FlowerDesc = flower.FlowerDesc;
            newFlower.FlowerPrice = flower.FlowerPrice;
            newFlower.FlowerQty = flower.FlowerQty;
            newFlower.FlowerPath = flower.FlowerPath;
            _context.Flowers.Add(newFlower);
            _context.SaveChanges();
            return newFlower;
        }
        public Flower EditFlower(int id, Flower flower)
        {
            Flower newFlower = null;
            newFlower = _context.Flowers.FirstOrDefault(p => p.FlowerID == id);
            newFlower.FlowerName = flower.FlowerName;
            newFlower.FlowerDesc = flower.FlowerDesc;
            newFlower.FlowerPrice = flower.FlowerPrice;
            newFlower.FlowerQty = flower.FlowerQty;
            newFlower.FlowerPath = flower.FlowerPath;
            _context.Flowers.Update(newFlower);
            _context.SaveChanges();
            return newFlower;
        }
        public Flower RemoveFlower(int id)
        {
            Flower flower = null;
            flower = _context.Flowers.FirstOrDefault(p => p.FlowerID == id);
            _context.Flowers.Remove(flower);
            _context.SaveChanges();
            return flower;
        }
    }
}
