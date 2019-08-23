using System;
using System.Linq;
using System.Collections.Generic;
using UserDataMicroserviceAPI.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UserDataMicroserviceAPI.Repositories.Interfaces;

namespace UserDataMicroserviceAPI.Repositories
{
    public class RecommendedUserRepo :  IRecommendedUserRepo
    {
        public RecommendedUserRepo()
        {
        }

        public void DeleteUserRecommendation(RecommendedUser recommendedUser)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<RecommendedUser>> GetUserRecommendation(ulong Id)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<IQueryable<RecommendedUser>>> GetUserRecommendations()
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<RecommendedUser>> PostUserRecommendation(RecommendedUser recommendedUser)
        {
            throw new NotImplementedException();
        }
    }
}
