using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace UserDataMicroserviceAPI.Models
{
    public class Wallet
    {
        [Key]
        [Required]
        private Guid walletId;

        [Required]
        private Guid userId;

        private List<Transaction> transactions;

        private decimal balance;





    }
}
