using System;
using System.Linq;
using System.Collections.Generic;
using UserDataMicroserviceAPI.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UserDataMicroserviceAPI.Repositories.Interfaces;

namespace UserDataMicroserviceAPI.Repositories
{
    public class NotificationRepo : INotificationRepo
    {
        public NotificationRepo()
        {
        }

        public void DeleteNotification(Notification notification)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<Notification>> GetNotification(string notificationId)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<IQueryable<Notification>>> GetUserNotifications(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<Notification>> PostNotification(Notification notification)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<Notification>> UpdateNotification(Notification notification)
        {
            throw new NotImplementedException();
        }
    }
}
