using System;
using System.Linq;
using System.Collections.Generic;
using UserDataMicroserviceAPI.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UserDataMicroserviceAPI.Repositories.Interfaces;

namespace UserDataMicroserviceAPI.Repositories
{
    public class ChatRepo : IChatRepo
    {
        public ChatRepo()
        {
        }

        public Task<ActionResult<Chat>> CreateChat(Chat chat)
        {
            throw new NotImplementedException();
        }

        public void DeleteChat(Chat course)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<Chat>> GetChat(string chatId)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<IQueryable<Chat>>> GetChats()
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<IQueryable<Chat>>> GetUserChats(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<Chat>> UpdateChat(Chat user)
        {
            throw new NotImplementedException();
        }
    }
}
