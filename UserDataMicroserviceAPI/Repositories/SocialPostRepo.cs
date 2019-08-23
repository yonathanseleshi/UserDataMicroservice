using System;
using System.Linq;
using System.Collections.Generic;
using UserDataMicroserviceAPI.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UserDataMicroserviceAPI.Repositories.Interfaces;


namespace UserDataMicroserviceAPI.Repositories
{
    public class SocialPostRepo : ISocialPostRepo
    {
        public SocialPostRepo()
        {
        }

        public void DeleteInspiration(SocialPost socialPost)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<SocialPost>> GetSocialPost(string socialPostId)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<IQueryable<SocialPost>>> GetUserSocialPosts(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<SocialPost>> PostSocialPost(SocialPost socialPost)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<SocialPost>> UpdateSocialPost(SocialPost socialPost)
        {
            throw new NotImplementedException();
        }
    }
}
