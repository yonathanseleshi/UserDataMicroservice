using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UserDataMicroserviceAPI.Models;
using UserDataMicroserviceAPI.Repositories;

namespace UserDataMicroserviceAPI.Controllers
{
    [Route("api/[controller]")]
    public class UsersController : Controller
    {
        private readonly IUserCrudRepository _crudRepository;
        
        private readonly UserDbContext _context;

        public UsersController(IUserCrudRepository crudRepository, UserDbContext context)
        {
            _crudRepository = crudRepository;
            _context = context;
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
        public async Task<ActionResult<User>> GetUser(string id)
        {
            var user = await _crudRepository.GetUser(id);
            if (user == null) return NotFound();

            return Ok(user);
        }

        // GET api/<controller>/username
        [HttpGet("username/{username}")]
        public async Task<ActionResult<User>> GetUsername(string username)
        {
            var user = await _crudRepository.CheckUsername(username);

            if (user == null) return NotFound();

            return Ok(user);
        }

        // POST api/<controller>
        [HttpPost]
        public async Task<ActionResult<User>> PostUser(User user)
        {
            
            User newUser = new User();
            string password = user.Password;
            var userId = new Guid();
            var createdAt = DateTime.UtcNow;
            newUser.UserId = userId;
            newUser.RegsitrationDate = createdAt;
            newUser.LastUpdated = createdAt;
            newUser.FirstName = user.FirstName;
            newUser.LastName = user.LastName;
            newUser.Password = password;
            newUser.Email = user.Email;
            newUser.Username = user.Username;
            newUser.Bio = user.Bio;
         


            if (TryValidateModel(newUser))
            {
                var result = await _crudRepository.PostUser(newUser);
            }
            else
            {
                return BadRequest(newUser);
            }

            return CreatedAtAction(nameof(GetUser), new {id = newUser.UserId}, newUser);
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(string id, User user)
        {
            
            if (id != user.UserId.ToString())
            {
                return BadRequest();
            }

           await _crudRepository.UpdateUser(user);
           
           return CreatedAtAction(nameof(GetUser), new {id = user.UserId}, user);

        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            
            var user = await _context.Users.FindAsync(id);

            if (user == null)
            {
                return NotFound();
            }
            
            _crudRepository.DeleteUser(user);

            return Accepted();
        }
    }
}