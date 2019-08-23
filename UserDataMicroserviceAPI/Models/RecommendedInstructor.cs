using System;

using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;


namespace UserDataMicroserviceAPI.Models
{
    public class RecommendedInstructor
    {


        ulong InstructorRecommendationID { get; set; }

        Guid UserId { get; set; }

        Guid InstructorId { get; set; }

        DateTime CreatedDate { get; set; }
    }
}
