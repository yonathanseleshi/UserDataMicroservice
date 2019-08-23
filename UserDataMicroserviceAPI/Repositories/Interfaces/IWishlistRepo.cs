using System;
using System.Linq;
using System.Collections.Generic;
using UserDataMicroserviceAPI.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace UserDataMicroserviceAPI.Repositories.Interfaces
{
    public interface IWishlistRepo
    {

        Task<ActionResult<Wishlist>> GetWishlist(string userId);

        Task<ActionResult<IQueryable<Wishlist>>> GetWishlists();

        Task<ActionResult<Wishlist>> PostSocialPost(Wishlist wishlist);

        Task<ActionResult<Wishlist>> UpdateSocialPost(Wishlist wishlist);



    }
}
