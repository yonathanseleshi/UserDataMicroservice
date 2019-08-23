using System;
using System.Linq;
using System.Collections.Generic;
using UserDataMicroserviceAPI.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UserDataMicroserviceAPI.Repositories.Interfaces;


namespace UserDataMicroserviceAPI.Repositories
{
    public class RecommendedCourseRepo : IRecommendedCourseRepo
    {
        public RecommendedCourseRepo()
        {
        }

        public void DeleteCourseRecommendation(RecommendedCourse recommendation)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<RecommendedCourse>> GetCourseRecommendation(ulong Id)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<IQueryable<RecommendedCourse>>> GetCourseRecommendations()
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<RecommendedCourse>> PostSocialPostRecommendation(RecommendedCourse recommendedCourse)
        {
            throw new NotImplementedException();
        }
    }
}
