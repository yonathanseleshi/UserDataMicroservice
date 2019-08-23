using System;
using System.Linq;
using System.Collections.Generic;
using UserDataMicroserviceAPI.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace UserDataMicroserviceAPI.Repositories.Interfaces
{
    public interface ICommentRepo
    {
        Task<ActionResult<Comment>> GetComment(string commentId);

        Task<ActionResult<IQueryable<Comment>>> GetComments(string userId);

        Task<ActionResult<Comment>> CreateComment(Comment comment);




        Task<ActionResult<Comment>> UpdateComment(Comment commentId);

        void DeleteComment(Comment comment);


    }
}
