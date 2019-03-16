using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UserDataMicroserviceAPI.Models;

namespace UserDataMicroserviceAPI.Repositories
{
    public class UserCrudRepository : IUserCrudRepository
    {
        private readonly UserDbContext _context;

        public UserCrudRepository(UserDbContext context)
        {
            _context = context;
        }

        public async Task<ActionResult<User>> GetUser(string userid)
        {
            var user = await _context.Users.FindAsync(userid);

            return user;
        }

        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            var users = await _context.Users.ToListAsync();

            return users;
        }

        public async Task<ActionResult<User>> PostUser(User user)
        {
            _context.Users.Add(user);
            var result = await _context.SaveChangesAsync();

            if (result == 1) return new ActionResult<User>(user);

            return user;
        }

        public async Task<ActionResult<User>> CheckUsername(string username)
        {
            var user = await _context.Users.SingleOrDefaultAsync(u => u.Username == username);

            return user;
        }
    }
}