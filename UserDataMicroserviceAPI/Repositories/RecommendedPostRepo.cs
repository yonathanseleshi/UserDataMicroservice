using System;
using System.Linq;
using System.Collections.Generic;
using UserDataMicroserviceAPI.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UserDataMicroserviceAPI.Repositories.Interfaces;


namespace UserDataMicroserviceAPI.Repositories
{
    public class RecommendedPostRepo : IRecommendedPostRepo
    {
        public RecommendedPostRepo()
        {
        }

        public void DeleteCourseRecommendation(RecommendedPost recommendation)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<RecommendedPost>> GetPostRecommendation(ulong Id)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<IQueryable<RecommendedPost>>> GetPostRecommendations()
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<RecommendedPost>> PostSocialPostRecommendation(RecommendedPost recommendedPost)
        {
            throw new NotImplementedException();
        }
    }
}
