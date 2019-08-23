using System;
using System.Linq;
using System.Collections.Generic;
using UserDataMicroserviceAPI.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UserDataMicroserviceAPI.Repositories.Interfaces;

namespace UserDataMicroserviceAPI.Repositories
{
    public class PoolRepo : IPoolRepo
    {
        public PoolRepo()
        {
        }

        public void DeletePool(Pool pool)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<Pool>> GetCoursePool(string courseId)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<Pool>> GetInspiration(string poolId)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<IQueryable<Pool>>> GetUserPools(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<Pool>> PostPool(Pool pool)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<Pool>> UpdatePool(Pool pool)
        {
            throw new NotImplementedException();
        }
    }
}
