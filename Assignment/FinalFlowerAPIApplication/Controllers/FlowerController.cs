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
    public class FlowerController : ControllerBase
    {
        private readonly FlowerService _service;

        public FlowerController(FlowerService service)
        {
            _service = service;
        }
        [HttpGet]
        public IEnumerable<Flower> Get()
        {
            var flowers = _service.AllFlowers();
            return flowers;
        }

        // GET api/<PizzaController>/5
        [HttpGet("{id}")]
        public Flower Get(int id)
        {
            var flower = _service.GetFlower(id);
            return flower;
        }
        [HttpPost]
        public Flower Post(Flower flower)
        {
            var Flower = _service.AddFlower(flower);
            return Flower;
        }
        [HttpPut("{id}")]
        public Flower Put(int id, Flower flower)
        {
            var newflower = _service.EditFlower(id, flower);
            return newflower;
        }
    }
}
