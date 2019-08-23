using System;

using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace UserDataMicroserviceAPI.Models
{
    public class RecommendedJob
    {



        ulong JobRecommendationID { get; set; }

        Guid UserId { get; set; }

        Guid JobId { get; set; }

        DateTime CreatedDate { get; set; }
    }
}
