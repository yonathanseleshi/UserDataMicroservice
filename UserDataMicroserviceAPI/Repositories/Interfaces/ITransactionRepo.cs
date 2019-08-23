using System;
using System.Linq;
using System.Collections.Generic;
using UserDataMicroserviceAPI.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace UserDataMicroserviceAPI.Repositories.Interfaces
{
    public interface ITransactionRepo
    {

        Task<ActionResult<Transaction>> GetTransaction(string transactionId);

        Task<ActionResult<IQueryable<Transaction>>> GetUserTransactions(string userId);

        Task<ActionResult<Transaction>> PostTransaction(Transaction socialPost);

        

        void DeleteTransaction(Transaction transaction);
    }
}
