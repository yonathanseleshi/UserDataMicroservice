using System;
using System.Linq;
using System.Collections.Generic;
using UserDataMicroserviceAPI.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UserDataMicroserviceAPI.Repositories.Interfaces;

namespace UserDataMicroserviceAPI.Repositories
{
    public class RecommendedJobRepo : IRecommendedJobRepo
    {
        public RecommendedJobRepo()
        {
        }

        public void DeleteLessonRecommendation(RecommendedJob recommendedJob)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<RecommendedJob>> GetJobRecommendation(ulong Id)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<IQueryable<RecommendedJob>>> GetJobRecommendations()
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<RecommendedJob>> PostJobRecommendation(RecommendedJob recommendedJob)
        {
            throw new NotImplementedException();
        }
    }
}
