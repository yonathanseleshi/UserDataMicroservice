using System;
using System.Linq;
using System.Collections.Generic;
using UserDataMicroserviceAPI.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace UserDataMicroserviceAPI.Repositories.Interfaces
{
    public interface IRecommendedCourseRepo
    {


        Task<ActionResult<RecommendedCourse>> GetCourseRecommendation(ulong Id);

        Task<ActionResult<IQueryable<RecommendedCourse>>> GetCourseRecommendations();

        Task<ActionResult<RecommendedCourse>> PostSocialPostRecommendation(RecommendedCourse recommendedCourse);


        void DeleteCourseRecommendation(RecommendedCourse recommendation);
    }
}
