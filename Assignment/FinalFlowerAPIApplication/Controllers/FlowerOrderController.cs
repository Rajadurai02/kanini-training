using FinalFlowerAPIApplication.Models;
using FinalFlowerAPIApplication.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FinalFlowerAPIApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[EnableCors("MyPolicy")]
    [Authorize]
    public class FlowerOrderController : ControllerBase
    {
        private readonly FlowerOrderService _service;

        public FlowerOrderController(FlowerOrderService service)
        {
            _service = service;
        }
        // GET: api/<OrderController>
        [HttpGet]
        public IEnumerable<FlowerOrder> Get()
        {
            return _service.AllFlowerOrders();
        }

        // GET api/<OrderController>/5
        [HttpGet("{id}")]
        public FlowerOrder Get(int id)
        {
            return _service.GetFlowerOrder(id);
        }

        // POST api/<OrderController>
        [HttpPost]
        public FlowerOrder Post([FromBody] FlowerOrder order)
        {
            var newOrder = _service.AddFlowerOrder(order);
            return newOrder;
        }

        // PUT api/<OrderController>/5
        [HttpPut("{id}")]
        public FlowerOrder Put(int id, [FromBody] FlowerOrder order)
        {
            var newOrder = _service.EditFlowerOrder(id, order);
            return newOrder;
        }

        // DELETE api/<OrderController>/5
        [HttpDelete("{id}")]
        public FlowerOrder Delete(int id)
        {
            var order = _service.RemoveFlowerOrder(id);
            return order;
        }
    }
}
