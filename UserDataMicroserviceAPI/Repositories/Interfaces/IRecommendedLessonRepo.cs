using System;
using System.Linq;
using System.Collections.Generic;
using UserDataMicroserviceAPI.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace UserDataMicroserviceAPI.Repositories.Interfaces
{
    public interface IRecommendedLesson
    {

        Task<ActionResult<RecommendedLesson>> GetLessonRecommendation(ulong Id);

        Task<ActionResult<IQueryable<RecommendedLesson>>> GetLessonRecommendations();

        Task<ActionResult<RecommendedLesson>> PostLessonRecommendation(RecommendedLesson recommendedLesson);


        void DeleteLessonRecommendation(RecommendedLesson recommendedLesson);

    }
}
