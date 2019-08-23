using System;
using System.Linq;
using System.Collections.Generic;
using UserDataMicroserviceAPI.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UserDataMicroserviceAPI.Repositories.Interfaces;

namespace UserDataMicroserviceAPI.Repositories
{
    public class RelationshipRepo : IRelationshipRepo
    {
        public RelationshipRepo()
        {
        }

        public Task<ActionResult<Relationship>> CreateRelationship(Relationship relationship)
        {
            throw new NotImplementedException();
        }

        public void DeleteRelationship(Relationship relationship)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<Relationship>> GetRelationship(string relationshipId)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<IQueryable<Relationship>>> GetRelationships(string userId)
        {
            throw new NotImplementedException();
        }
    }
}
