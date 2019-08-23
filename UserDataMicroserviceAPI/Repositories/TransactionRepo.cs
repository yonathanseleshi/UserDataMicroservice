using System;
using System.Linq;
using System.Collections.Generic;
using UserDataMicroserviceAPI.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UserDataMicroserviceAPI.Repositories.Interfaces;


namespace UserDataMicroserviceAPI.Repositories
{
    public class TransactionRepo : ITransactionRepo
    {
        public TransactionRepo()
        {
        }

        public void DeleteTransaction(Transaction transaction)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<Transaction>> GetTransaction(string transactionId)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<IQueryable<Transaction>>> GetUserTransactions(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<Transaction>> PostTransaction(Transaction socialPost)
        {
            throw new NotImplementedException();
        }
    }
}
