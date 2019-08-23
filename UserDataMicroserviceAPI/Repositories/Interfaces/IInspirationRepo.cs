using System;
using System.Linq;
using System.Collections.Generic;
using UserDataMicroserviceAPI.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace UserDataMicroserviceAPI.Repositories.Interfaces
{
    public interface IInspirationRepo
    {



        Task<ActionResult<Inspiration>> GetInspiration(string inspirationId);

        Task<ActionResult<IQueryable<Inspiration>>> GetUserInspirations(string userId);

        Task<ActionResult<Inspiration>> PostInspiration(Inspiration inspiration);

        Task<ActionResult<Inspiration>> UpdateInspiration(Inspiration inspriation);

        void DeleteInspiration(Inspiration inspiration);
    }
}
