﻿using System;
using System.ComponentModel.DataAnnotations;

namespace UserDataMicroserviceAPI.Models
{
    public class Subscription
    {

        [Key]
        [Required]
        private Guid subscriptionId;

        [Required]
        private Guid subscriberId;

        private DateTime lastPurchaseDate;






    }
}
