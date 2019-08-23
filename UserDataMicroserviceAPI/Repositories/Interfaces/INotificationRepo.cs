using System;
using System.Linq;
using System.Collections.Generic;
using UserDataMicroserviceAPI.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace UserDataMicroserviceAPI.Repositories.Interfaces
{
    public interface INotificationRepo
    {



        Task<ActionResult<Notification>> GetNotification(string notificationId);

        Task<ActionResult<IQueryable<Notification>>> GetUserNotifications(string userId);

        Task<ActionResult<Notification>> PostNotification(Notification notification);

        Task<ActionResult<Notification>> UpdateNotification(Notification notification);

        void DeleteNotification(Notification notification);
    }
}
