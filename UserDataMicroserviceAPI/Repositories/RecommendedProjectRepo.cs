using System;
using System.Linq;
using System.Collections.Generic;
using UserDataMicroserviceAPI.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UserDataMicroserviceAPI.Repositories.Interfaces;


namespace UserDataMicroserviceAPI.Repositories
{
    public class RecommendedProjectRepo : IRecommendedProjectRepo
    {
        public RecommendedProjectRepo()
        {
        }

        public void DeleteUserRecommendation(RecommendedProject recommendedUser)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<RecommendedProject>> GetUserRecommendation(ulong Id)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<IQueryable<RecommendedProject>>> GetUserRecommendations()
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<RecommendedProject>> PostUserRecommendation(RecommendedProject recommendedProject)
        {
            throw new NotImplementedException();
        }
    }
}
