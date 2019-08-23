using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace UserDataMicroserviceAPI.Models
{
    public class RecommendedProject
    {




        ulong ProjectRecommendationID { get; set; }

        Guid UserId { get; set; }

        Guid ProjectId { get; set; }

        DateTime CreatedDate { get; set; }
    }
}
