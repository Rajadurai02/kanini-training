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
    [EnableCors("Policy")]
    //[Authorize]
    public class OrderController : ControllerBase
    {
        private readonly OrderService _service;

        public OrderController(OrderService service)
        {
            _service = service;
        }
        // GET: api/<OrderController>
        [HttpGet]
        public IEnumerable<Order> Get()
        {
            return _service.AllOrders();
        }

        // GET api/<OrderController>/5
        [HttpGet("{id}")]
        public Order Get(int id)
        {
            return _service.GetOrder(id);
        }

        // POST api/<OrderController>
        [HttpPost]
        public Order Post([FromBody] Order order)
        {
            var newOrder = _service.AddOrder(order);
            return newOrder;
        }

        // PUT api/<OrderController>/5
        [HttpPut("{id}")]
        public Order Put(int id, [FromBody] Order order)
        {
            var newOrder = _service.EditOrder(id, order);
            return newOrder;
        }

        // DELETE api/<OrderController>/5
        [HttpDelete("{id}")]
        public Order Delete(int id)
        {
            var order = _service.RemoveOrder(id);
            return order;
        }
    }
}
