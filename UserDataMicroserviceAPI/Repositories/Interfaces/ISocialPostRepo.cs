using System;
using System.Linq;
using System.Collections.Generic;
using UserDataMicroserviceAPI.Models;

using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace UserDataMicroserviceAPI.Repositories.Interfaces
{
    public interface ISocialPostRepo
    {


        Task<ActionResult<SocialPost>> GetSocialPost(string socialPostId);

        Task<ActionResult<IQueryable<SocialPost>>> GetUserSocialPosts(string userId);

        Task<ActionResult<SocialPost>> PostSocialPost(SocialPost socialPost);

        Task<ActionResult<SocialPost>> UpdateSocialPost(SocialPost socialPost);

        void DeleteInspiration(SocialPost socialPost);

    }
}
