using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace UserDataMicroserviceAPI.Models
{
    public class Lesson
    {

        [Key]
        private Guid lessonId;

        private string courseName;

        private Guid courseId;

        private string lessonVidUrl;

        private long lessonLength;

        private bool subscriptionRequired;

        [Required]
        private Guid courseOwnerId;

        private User courseOwner;

        private DateTime createdDate;

        private DateTime updatedDate;

        private string description;


       
        
    }
}
