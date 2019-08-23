using System;
using System.Linq;
using System.Collections.Generic;
using UserDataMicroserviceAPI.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UserDataMicroserviceAPI.Repositories.Interfaces;


namespace UserDataMicroserviceAPI.Repositories
{
    public class WalletRepo : IWalletRepo

    {
        public WalletRepo()
        {
        }

        public void DeleteInspiration(Wallet socialPost)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<Wallet>> GetWallet(string walletId)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<IQueryable<Wallet>>> GetWallets()
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<Wallet>> PostSocialPost(Wallet socialPost)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<Wallet>> UpdateSocialPost(Wallet socialPost)
        {
            throw new NotImplementedException();
        }
    }
}
