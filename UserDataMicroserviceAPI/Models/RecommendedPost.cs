using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace UserDataMicroserviceAPI.Models
{
    public class RecommendedPost
    {



        ulong SocialPostRecommendationID { get; set; }

        Guid UserId { get; set; }

        Guid SocialPost {get; set; }

        DateTime CreatedDate { get; set; }


    }
}
