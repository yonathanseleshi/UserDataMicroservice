using System;
using System.Linq;
using System.Collections.Generic;
using UserDataMicroserviceAPI.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace UserDataMicroserviceAPI.Repositories.Interfaces
{
    public interface IRecommendedSchoolRepo
    {


        Task<ActionResult<RecommendedSchool>> GetUserRecommendation(ulong Id);

        Task<ActionResult<IQueryable<RecommendedSchool>>> GetSchoolRecommendations();

        Task<ActionResult<RecommendedSchool>> PostSchoolRecommendation(RecommendedSchool recommendedSchool);


        void DeleteSchoolRecommendation(RecommendedSchool recommendedUser);

    }
}
