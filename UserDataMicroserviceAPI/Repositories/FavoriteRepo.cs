using System;
using System.Linq;
using System.Collections.Generic;
using UserDataMicroserviceAPI.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UserDataMicroserviceAPI.Repositories.Interfaces;


namespace UserDataMicroserviceAPI.Repositories
{
    public class FavoriteRepo : IFavoriteRepo
    {
        public FavoriteRepo()
        {
        }

        public void DeleteFavorite(Favorite favorite)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<Favorite>> GetFavorite(string favoriteId)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<IQueryable<Favorite>>> GetUserFavorites(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<Favorite>> PostFavorite(Favorite favorite)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<Favorite>> UpdateFavorite(Favorite favorite)
        {
            throw new NotImplementedException();
        }
    }
}
