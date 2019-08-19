using System;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;


namespace UserDataMicroserviceAPI.Models
{
    public class SocialPost
    {

        [Key]
        [Required]
        private Guid postId;

        [Required]
        private Guid userId;

        private DateTime createdDate;

        private string postText;




    }
}
