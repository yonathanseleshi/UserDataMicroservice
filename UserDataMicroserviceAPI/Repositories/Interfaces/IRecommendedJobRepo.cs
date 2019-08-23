using System;
using System.Linq;
using System.Collections.Generic;
using UserDataMicroserviceAPI.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace UserDataMicroserviceAPI.Repositories.Interfaces
{
    public interface IRecommendedJobRepo
    {



        Task<ActionResult<RecommendedJob>> GetJobRecommendation(ulong Id);

        Task<ActionResult<IQueryable<RecommendedJob>>> GetJobRecommendations();

        Task<ActionResult<RecommendedJob>> PostJobRecommendation(RecommendedJob recommendedJob);


        void DeleteLessonRecommendation(RecommendedJob recommendedJob);
    }
}
