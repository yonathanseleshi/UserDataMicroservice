using System;
using System.Linq;
using System.Collections.Generic;
using UserDataMicroserviceAPI.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace UserDataMicroserviceAPI.Repositories.Interfaces
{
    public interface IRecommendedProjectRepo
    {


        Task<ActionResult<RecommendedProject>> GetUserRecommendation(ulong Id);

        Task<ActionResult<IQueryable<RecommendedProject>>> GetUserRecommendations();

        Task<ActionResult<RecommendedProject>> PostUserRecommendation(RecommendedProject recommendedProject);


        void DeleteUserRecommendation(RecommendedProject recommendedUser);


    }
}
