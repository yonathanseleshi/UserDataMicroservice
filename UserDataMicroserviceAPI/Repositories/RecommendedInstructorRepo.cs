using System;
using System.Linq;
using System.Collections.Generic;
using UserDataMicroserviceAPI.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UserDataMicroserviceAPI.Repositories.Interfaces;


namespace UserDataMicroserviceAPI.Repositories
{
    public class RecommendedInstructorRepo : IRecommendedInstructorRepo
    {
        public RecommendedInstructorRepo()
        {
        }

        public void DeleteUserRecommendation(RecommendedInstructor recommendedInstructor)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<RecommendedInstructor>> GetInstructorRecommendation(ulong Id)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<IQueryable<RecommendedInstructor>>> GetInstructorRecommendations()
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<RecommendedInstructor>> PostInstructorRecommendation(RecommendedInstructor recommendedInstructor)
        {
            throw new NotImplementedException();
        }
    }
}
