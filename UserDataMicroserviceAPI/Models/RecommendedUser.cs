using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace UserDataMicroserviceAPI.Models
{
    public class RecommendedUser
    {


        ulong UserRecommendationID { get; set; }

        Guid UserId { get; set; }

        Guid RecommendedUserId { get; set; }

        DateTime CreatedDate { get; set; }
    }
}
