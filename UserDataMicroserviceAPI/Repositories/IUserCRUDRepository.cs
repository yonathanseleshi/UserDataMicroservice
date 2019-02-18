using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UserDataMicroserviceAPI.Models;

namespace UserDataMicroserviceAPI.Repositories
{
    public interface IUserCrudRepository
    {

        Task<ActionResult<User>> GetUser(long userid);

        Task<ActionResult<IEnumerable<User>>> GetUsers();

        Task<ActionResult<User>> PostUser(User user);

        Task<ActionResult<User>> CheckUsername(string username);

    }
}
