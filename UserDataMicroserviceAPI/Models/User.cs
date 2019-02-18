using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Threading.Tasks;


namespace UserDataMicroserviceAPI.Models
{
    public class User
    {

        public User()
        {

        }

        [Required]
        [Key]
        public Guid UserId { get; set; }
        [Required]
        [MaxLength(35), MinLength(1)]
        public String FirstName { get; set; }
        [Required]
        [MaxLength(35), MinLength(1)]
        public String LastName { get; set; }
        [EmailAddress]
        public String Email { get; set; }
        [Required]
        public String Username { get; set; }
        public String Bio { get; set; }
        public DateTime ProfileCreated { get; set; }
        public DateTime LastUpdated { get; set; }


    }
}
