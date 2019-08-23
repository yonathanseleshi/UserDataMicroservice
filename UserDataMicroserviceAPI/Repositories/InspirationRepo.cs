using System;
using System.Linq;
using System.Collections.Generic;
using UserDataMicroserviceAPI.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UserDataMicroserviceAPI.Repositories.Interfaces;


namespace UserDataMicroserviceAPI.Repositories
{
    public class InspirationRepo : IInspirationRepo
    {
        public InspirationRepo()
        {
        }

        public void DeleteInspiration(Inspiration inspiration)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<Inspiration>> GetInspiration(string inspirationId)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<IQueryable<Inspiration>>> GetUserInspirations(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<Inspiration>> PostInspiration(Inspiration inspiration)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<Inspiration>> UpdateInspiration(Inspiration inspriation)
        {
            throw new NotImplementedException();
        }
    }
}
