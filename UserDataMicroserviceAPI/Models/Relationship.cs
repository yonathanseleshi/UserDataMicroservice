using System;
namespace UserDataMicroserviceAPI.Models
{
    public class Relationship
    {
       
        private Guid relationshipId;

        private Guid userId;

        private Guid followerId;

        private User following;

        private User follower;


        private DateTime followDate;

       
    }
}
