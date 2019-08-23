using System;
using System.Linq;
using System.Collections.Generic;
using UserDataMicroserviceAPI.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace UserDataMicroserviceAPI.Repositories.Interfaces
{
    public interface IInstructorSubscriptionRepo
    {



        Task<ActionResult<InstructorSubscription>> GetInstructorSubscription(string instructorSubscriptionId);

        Task<ActionResult<IQueryable<InstructorSubscription>>> GetUserInstructorSubscriptions(string userId);

        Task<ActionResult<InstructorSubscription>> PostInstructorSubscription(InstructorSubscription inspiration);

        Task<ActionResult<InstructorSubscription>> UpdateInstructorSubscription(InstructorSubscription inspriation);

        void DeleteInstructorSubscription(InstructorSubscription inspiration);


    }
}
