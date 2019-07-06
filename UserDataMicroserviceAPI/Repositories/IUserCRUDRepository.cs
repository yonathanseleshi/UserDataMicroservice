using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UserDataMicroserviceAPI.Models;

namespace UserDataMicroserviceAPI.Repositories
{
    public interface IUserCrudRepository
    {
        Task<ActionResult<User>> GetUser(string userid);

        Task<ActionResult<IEnumerable<User>>> GetUsers();

        Task<ActionResult<User>> PostUser(User user);

        Task<ActionResult<User>> CheckUsername(string username);

        Task<ActionResult<User>> UpdateUser(User user);
        
        void DeleteUser(User user);

    }
}