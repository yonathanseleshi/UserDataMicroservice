using System;
using System.Linq;
using System.Collections.Generic;
using UserDataMicroserviceAPI.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace UserDataMicroserviceAPI.Repositories.Interfaces
{
    public interface ISubscriptionRepo
    {



        Task<ActionResult<Subscription>> GetSubscription(string subscriptionId);

        Task<ActionResult<IQueryable<Subscription>>> GetUserSubscriptions(string userId);

        Task<ActionResult<Subscription>> PostSubscription(Subscription subscription);

        Task<ActionResult<Subscription>> UpdateSubscription(Subscription subscription);

        void DeleteInspiration(Subscription subscription);
    }
}
