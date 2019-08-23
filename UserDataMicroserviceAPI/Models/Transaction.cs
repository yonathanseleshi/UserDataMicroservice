using System;
using System.ComponentModel.DataAnnotations;

namespace UserDataMicroserviceAPI.Models
{
    public class Transaction
    {

        private Guid transactionId;

        private Guid walletId;

        private DateTime transactionDate;

        private decimal amount;

        private enum transactionType { CourseEnrollment, SubscriptionPayment,
            PoolCredit, AdPurchase, Contribution, MoneyTransfer, LoanCredit, LoanPayment}


    }
}
