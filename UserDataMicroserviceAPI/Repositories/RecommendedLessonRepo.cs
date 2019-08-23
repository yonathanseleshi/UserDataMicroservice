using System;
using System.Linq;
using System.Collections.Generic;
using UserDataMicroserviceAPI.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UserDataMicroserviceAPI.Repositories.Interfaces;

namespace UserDataMicroserviceAPI.Repositories
{
    public class RecommendedLessonRepo : IRecommendedLesson
    {
        public RecommendedLessonRepo()
        {
        }

        public void DeleteLessonRecommendation(RecommendedLesson recommendedLesson)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<RecommendedLesson>> GetLessonRecommendation(ulong Id)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<IQueryable<RecommendedLesson>>> GetLessonRecommendations()
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<RecommendedLesson>> PostLessonRecommendation(RecommendedLesson recommendedLesson)
        {
            throw new NotImplementedException();
        }
    }
}
