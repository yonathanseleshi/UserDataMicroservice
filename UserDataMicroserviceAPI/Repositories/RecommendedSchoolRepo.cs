using System;
using System.Linq;
using System.Collections.Generic;
using UserDataMicroserviceAPI.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UserDataMicroserviceAPI.Repositories.Interfaces;

namespace UserDataMicroserviceAPI.Repositories
{
    public class RecommendedSchoolRepo : IRecommendedSchoolRepo
    {
        public RecommendedSchoolRepo()
        {
        }

        public void DeleteSchoolRecommendation(RecommendedSchool recommendedUser)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<IQueryable<RecommendedSchool>>> GetSchoolRecommendations()
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<RecommendedSchool>> GetUserRecommendation(ulong Id)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<RecommendedSchool>> PostSchoolRecommendation(RecommendedSchool recommendedSchool)
        {
            throw new NotImplementedException();
        }
    }
}
