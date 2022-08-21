using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models;
using BL;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace User_DB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        readonly private IBL _bl;

        public UserController(IBL bl)
        {
            _bl = bl;
        }

        // GET: api/<UserController>/username;
        [HttpGet("{username}")]
        public async Task<IActionResult> Get(string username)
        {
            User user = await _bl.getOneUserAsync(username);
            if(user != null)
            {
                return Ok(user);
            }
            else
            {
                return NoContent();
            }
        }

        // POST api/<User>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] User newUser)
        {
            User user = await _bl.createUserAsync(newUser);
            return Created("api/[controller]", user);
        }

        // PUT api/<User>/5
        [HttpPut]
        public async Task<IActionResult> Put([FromBody] User updatedUser)
        {
            User user = await _bl.updateUserAsync(updatedUser);
            return Ok(user);
        }

        // DELETE api/<User>/5
        [HttpDelete("{username}")]
        public async Task Delete(string username)
        {
            await _bl.DeleteUserAsync(username);
        }
    }
}
