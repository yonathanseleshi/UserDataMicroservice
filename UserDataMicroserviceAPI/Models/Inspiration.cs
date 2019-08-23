using System;
using System.ComponentModel.DataAnnotations;


namespace UserDataMicroserviceAPI.Models
{
    public class Inspiration
    {

        [Key]
        private Guid inspirationId;

        private Guid userId;

        private Guid postId;

        private DateTime createdDate;



    }
}
