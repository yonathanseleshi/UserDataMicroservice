using System;
using System.Linq;
using System.Collections.Generic;
using UserDataMicroserviceAPI.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace UserDataMicroserviceAPI.Repositories.Interfaces
{
    public interface IFavoriteRepo
    {

        Task<ActionResult<Favorite>> GetFavorite(string favoriteId);

        Task<ActionResult<IQueryable<Favorite>>> GetUserFavorites(string userId);

        Task<ActionResult<Favorite>> PostFavorite(Favorite favorite);

        Task<ActionResult<Favorite>> UpdateFavorite(Favorite favorite);

        void DeleteFavorite(Favorite favorite);
    }
}
