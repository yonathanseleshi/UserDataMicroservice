using System;
using System.Linq;
using System.Collections.Generic;
using UserDataMicroserviceAPI.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace UserDataMicroserviceAPI.Repositories.Interfaces
{
    public interface IPoolRepo
    {



        Task<ActionResult<Pool>> GetInspiration(string poolId);

        Task<ActionResult<IQueryable<Pool>>> GetUserPools(string userId);

        

        Task<ActionResult<Pool>> GetCoursePool(string courseId);
        
        Task<ActionResult<Pool>> PostPool(Pool pool);

        Task<ActionResult<Pool>> UpdatePool(Pool pool);

        void DeletePool(Pool pool);

    }
}
