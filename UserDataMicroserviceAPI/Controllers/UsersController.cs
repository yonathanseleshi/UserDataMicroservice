using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UserDataMicroserviceAPI.Models;
using UserDataMicroserviceAPI.Repositories;

namespace UserDataMicroserviceAPI.Controllers
{
    [Route("api/[controller]")]
    public class UsersController : Controller
    {

        private IUserCrudRepository _crudRepository;

        public UsersController(IUserCrudRepository crudRepository)
        {

            _crudRepository = crudRepository;


        }

        // GET: api/<controller>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            var users = await _crudRepository.GetUsers();

            return users;
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(long id)
        {
            var user = await _crudRepository.GetUser(id);
            if (user == null)
            {
                return NotFound();

            }

            return Ok(user);
        }

        // GET api/<controller>/username
        [HttpGet("username/{username}")]
        public async Task<ActionResult<User>> GetUsername(string username)
        {
            var user = await _crudRepository.CheckUsername(username);
            
            if (user == null)
            {
                return NotFound();

            }

            return Ok(user);
        }

        // POST api/<controller>
        [HttpPost]
        public async Task<ActionResult<User>> PostUser(User user)
        {
            var userID = new Guid();
            var createdAt = DateTime.UtcNow;
            user.UserId = userID;
            user.ProfileCreated = createdAt;
            user.LastUpdated = createdAt;


            if (TryValidateModel(user))
            {
             var result = await _crudRepository.PostUser(user);

            }
            else
            {
                return BadRequest(User);
            }

            return CreatedAtAction(nameof(GetUser), new {id = user.UserId}, user);


        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
