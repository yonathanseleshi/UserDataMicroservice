using System;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;


namespace UserDataMicroserviceAPI.Models
{
    public class LessonPost
    {



        [Key]
        [Required]
        private Guid postId;


        [Required]
        private Guid userId;

        [Required]
        private bool paidOnly;

        [Required]
        private DateTime createdDate;



    }
}
