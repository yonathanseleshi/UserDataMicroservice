using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UserDataMicroserviceAPI.Models;

namespace UserDataMicroserviceAPI.Repositories.Interfaces
{
    public interface IChatRepo
    {

        Task<ActionResult<Chat>> GetChat(string chatId);

        Task<ActionResult<IQueryable<Chat>>> GetChats();

        Task<ActionResult<IQueryable<Chat>>> GetUserChats(string userId); 

        Task<ActionResult<Chat>> CreateChat(Chat chat);




        Task<ActionResult<Chat>> UpdateChat(Chat user);

        void DeleteChat(Chat course);


    }
}
