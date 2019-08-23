using System;
using System.Linq;
using System.Collections.Generic;
using UserDataMicroserviceAPI.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace UserDataMicroserviceAPI.Repositories.Interfaces
{
    public interface IRecommendedUserRepo
    {


        Task<ActionResult<RecommendedUser>> GetUserRecommendation(ulong Id);

        Task<ActionResult<IQueryable<RecommendedUser>>> GetUserRecommendations();

        Task<ActionResult<RecommendedUser>> PostUserRecommendation(RecommendedUser recommendedUser);


        void DeleteUserRecommendation(RecommendedUser recommendedUser);
    }
}
