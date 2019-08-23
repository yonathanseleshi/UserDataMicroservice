using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace UserDataMicroserviceAPI.Models
{
    public class RecommendedSchool
    {


        ulong SchoolRecommendationID { get; set; }

        Guid UserId { get; set; }

        Guid CourseId { get; set; }

        DateTime CreatedDate { get; set; }
    }
}
