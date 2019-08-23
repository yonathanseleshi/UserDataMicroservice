using System;
using System.Linq;
using System.Collections.Generic;
using UserDataMicroserviceAPI.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UserDataMicroserviceAPI.Repositories.Interfaces;


namespace UserDataMicroserviceAPI.Repositories
{
    public class WishlistRepo : IWishlistRepo
    {
        public WishlistRepo()
        {
        }

        public Task<ActionResult<Wishlist>> GetWishlist(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<IQueryable<Wishlist>>> GetWishlists()
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<Wishlist>> PostSocialPost(Wishlist wishlist)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<Wishlist>> UpdateSocialPost(Wishlist wishlist)
        {
            throw new NotImplementedException();
        }
    }
}
