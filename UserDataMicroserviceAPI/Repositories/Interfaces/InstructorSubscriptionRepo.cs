using System;
using System.Linq;
using System.Collections.Generic;
using UserDataMicroserviceAPI.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UserDataMicroserviceAPI.Repositories.Interfaces;


namespace UserDataMicroserviceAPI.Repositories.Interfaces
{
    public class InstructorSubscriptionRepo : IInstructorSubscriptionRepo
    {
        public InstructorSubscriptionRepo()
        {
        }

        public void DeleteInstructorSubscription(InstructorSubscription inspiration)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<InstructorSubscription>> GetInstructorSubscription(string instructorSubscriptionId)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<IQueryable<InstructorSubscription>>> GetUserInstructorSubscriptions(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<InstructorSubscription>> PostInstructorSubscription(InstructorSubscription inspiration)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<InstructorSubscription>> UpdateInstructorSubscription(InstructorSubscription inspriation)
        {
            throw new NotImplementedException();
        }
    }
}
