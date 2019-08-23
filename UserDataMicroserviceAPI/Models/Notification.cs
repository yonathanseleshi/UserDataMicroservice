using System;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;


namespace UserDataMicroserviceAPI.Models
{
    public class Notification
    {
        [Key]
        [Required]
        private Guid notificationID;

        [Required]
        private Guid userID;

        private enum notificationType { Follow, Message, Like, Favorite, Comment, Enrollment, Credit, Credential }

        private string notificationMessage;

        private DateTime notifcationDateTime;

        private Guid notifierId;
    }
}
