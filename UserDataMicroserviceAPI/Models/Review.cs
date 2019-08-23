using System;
using System.ComponentModel.DataAnnotations;


namespace UserDataMicroserviceAPI.Models
{
    public class Review
    {


        [Key]
        [Required]
        private Guid reviewId;


        [Required]
        private Guid userId;


        [Required]
        private Guid CourseId;



        private int rating;


        private string reviewComment;

        private DateTime createdDate;




        
    }
}
