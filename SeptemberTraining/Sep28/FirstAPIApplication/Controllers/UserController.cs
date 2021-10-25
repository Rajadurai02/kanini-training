﻿using FirstAPIApplication.Models;
using FirstAPIApplication.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FirstAPIApplication.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("MyPolicy")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserService _service;

        public UserController(UserService userSevice)
        {
            _service = userSevice;
        }
        // POST api/<UserController>
        [HttpPost]
        public async Task<ActionResult<UserDTO>> Post([FromBody] UserDTO user)
        {
            var userDTO = _service.Register(user);
            if (userDTO != null)
                return userDTO;
            else
            {
                return BadRequest("Not able to register");
            }
            
        }

        [Route("Login")]
        [HttpPost]
        public async Task<ActionResult<UserDTO>> Put([FromBody] UserDTO user)
        {
            var userDTO = _service.Login(user);
            if (userDTO != null)
                return Ok(userDTO);
            else
                return BadRequest("Not able to Login");
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }
    }
}
