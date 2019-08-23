using System;
using System.Linq;
using System.Collections.Generic;
using UserDataMicroserviceAPI.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UserDataMicroserviceAPI.Repositories.Interfaces;


namespace UserDataMicroserviceAPI.Repositories
{
    public class SubscriptionRepo : ISubscriptionRepo
    {
        public SubscriptionRepo()
        {
        }

        public void DeleteInspiration(Subscription subscription)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<Subscription>> GetSubscription(string subscriptionId)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<IQueryable<Subscription>>> GetUserSubscriptions(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<Subscription>> PostSubscription(Subscription subscription)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<Subscription>> UpdateSubscription(Subscription subscription)
        {
            throw new NotImplementedException();
        }
    }
}
