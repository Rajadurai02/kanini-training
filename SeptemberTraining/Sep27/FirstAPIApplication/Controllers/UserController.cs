using FirstAPIApplication.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FirstAPIApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        static List<User> users = new List<User>()
        {
            new User(){Id=101,Name="Jim",Password="jim123"},
            new User(){Id=102,Name="Nim",Password="Nim321"}
        };
        // GET: api/<UserController>
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return users;
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public User Get(int id)
        {

            return users.FirstOrDefault(u=>u.Id == id);
        }

        // POST api/<UserController>
        [HttpPost]
        public void Post([FromBody] User user)
        {
            users.Add(user);
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] User user)
        {
            User myUser = users.FirstOrDefault(u => u.Id == id);
            myUser.Name = user.Name;
            myUser.Password = user.Password;
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            User myUser = users.FirstOrDefault(u => u.Id == id);
            users.Remove(myUser);
            //users.RemoveAt(users.FindIndex(u => u.Id == id));
        }
    }
}
