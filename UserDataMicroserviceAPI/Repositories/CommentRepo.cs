using System;
using System.Linq;
using System.Collections.Generic;
using UserDataMicroserviceAPI.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UserDataMicroserviceAPI.Repositories.Interfaces;

namespace UserDataMicroserviceAPI.Repositories
{
    public class CommentRepo : ICommentRepo
    {
        public CommentRepo()
        {
        }

        public Task<ActionResult<Comment>> CreateComment(Comment comment)
        {
            throw new NotImplementedException();
        }

        public void DeleteComment(Comment comment)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<Comment>> GetComment(string commentId)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<IQueryable<Comment>>> GetComments(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<Comment>> UpdateComment(Comment commentId)
        {
            throw new NotImplementedException();
        }
    }
}
