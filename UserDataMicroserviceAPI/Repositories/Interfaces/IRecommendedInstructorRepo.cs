using System;
using System.Linq;
using System.Collections.Generic;
using UserDataMicroserviceAPI.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace UserDataMicroserviceAPI.Repositories.Interfaces
{
    public interface IRecommendedInstructorRepo
    {


        Task<ActionResult<RecommendedInstructor>> GetInstructorRecommendation(ulong Id);

        Task<ActionResult<IQueryable<RecommendedInstructor>>> GetInstructorRecommendations();

        Task<ActionResult<RecommendedInstructor>> PostInstructorRecommendation(RecommendedInstructor recommendedInstructor);


        void DeleteUserRecommendation(RecommendedInstructor recommendedInstructor);
    }
}
