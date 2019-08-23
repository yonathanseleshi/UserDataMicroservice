using System;
using System.Linq;
using System.Collections.Generic;
using UserDataMicroserviceAPI.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace UserDataMicroserviceAPI.Repositories.Interfaces
{
    public interface IRelationshipRepo
    {

        Task<ActionResult<Relationship>> GetRelationship(string relationshipId);

        Task<ActionResult<IQueryable<Relationship>>> GetRelationships(string userId);

        Task<ActionResult<Relationship>> CreateRelationship(Relationship relationship);




        

        void DeleteRelationship(Relationship relationship);
    }
}
