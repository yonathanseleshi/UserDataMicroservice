using System;
using System.Linq;
using System.Collections.Generic;
using UserDataMicroserviceAPI.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace UserDataMicroserviceAPI.Repositories.Interfaces
{
    public interface IRecommendedPostRepo
    {



        Task<ActionResult<RecommendedPost>> GetPostRecommendation(ulong Id);

        Task<ActionResult<IQueryable<RecommendedPost>>> GetPostRecommendations();

        Task<ActionResult<RecommendedPost>> PostSocialPostRecommendation(RecommendedPost recommendedPost);

        
        void DeleteCourseRecommendation(RecommendedPost recommendation);


    }
}
