using System;
using System.Linq;
using System.Collections.Generic;
using UserDataMicroserviceAPI.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace UserDataMicroserviceAPI.Repositories.Interfaces
{
    public interface IWalletRepo
    {


        Task<ActionResult<Wallet>> GetWallet(string walletId);

        Task<ActionResult<IQueryable<Wallet>>> GetWallets();

        Task<ActionResult<Wallet>> PostSocialPost(Wallet socialPost);

        Task<ActionResult<Wallet>> UpdateSocialPost(Wallet socialPost);

        void DeleteInspiration(Wallet socialPost);
    }
}
