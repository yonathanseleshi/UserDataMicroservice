using System;

using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace UserDataMicroserviceAPI.Models
{
    public class RecommendedLesson
    {

        ulong LessonRecommendationID { get; set; }

        Guid UserId { get; set; }

        Guid LessonId { get; set; }

        DateTime CreatedDate { get; set; }

    }
}
