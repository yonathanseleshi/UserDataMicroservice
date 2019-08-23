using System;
using System.ComponentModel.DataAnnotations;


namespace UserDataMicroserviceAPI.Models
{
    public class InstructorSubscription
    {

        [Key]
        [Required]
        private Guid subscriptionId;

        [Required]
        private Guid instructorId;

        [Required]
        private Guid userId;

        private DateTime lastPaymentDate;




    }
}
