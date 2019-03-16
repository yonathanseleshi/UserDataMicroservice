using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;

namespace UserDataMicroserviceAPI.Models
{
    public class User
    {

        [Required] 
        [Key] 
        private Guid userId;

        [Required]
        [MaxLength(35)]
        [MinLength(1)]
        private string firstName;

        [Required]
        [MaxLength(35)]
        [MinLength(1)]
        private string lastName;

        [EmailAddress] 
        [Required]
        private string email;

        
        [Required]
        [MinLength(4), MaxLength(30)]
        private string username;

        private string password;

        private string bio;


        private DateTime regsitrationDate;

        private DateTime lastUpdated;

        
        
        
        
        public User()
        {
            
           
        }


        public User(Guid userId, string firstName, string lastName, string email, string username, string password, string bio, DateTime regsitrationDate, DateTime lastUpdated)
        {
            this.userId = userId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.username = username;
            this.password = GeneratePasswordHash(password);
            this.bio = bio;
            this.regsitrationDate = regsitrationDate;
            this.lastUpdated = lastUpdated;
        }
        
        
        
        public Guid UserId
        {
            get => userId;
            set => userId = value;
        }

        public string FirstName
        {
            get => firstName;
            set => firstName = value;
        }

        public string LastName
        {
            get => lastName;
            set => lastName = value;
        }

        public string Email
        {
            get => email;
            set => email = value;
        }

        public string Username
        {
            get => username;
            set => username = value;
        }

        public string Password
        {
            get => password;
            set => password = GeneratePasswordHash(value);
        }

        public string Bio
        {
            get => bio;
            set => bio = value;
        }

        public DateTime RegsitrationDate
        {
            get => regsitrationDate;
            set => regsitrationDate = value;
        }

        public DateTime LastUpdated
        {
            get => lastUpdated;
            set => lastUpdated = value;
        }


        private string GeneratePasswordHash(string userPassword)
        {

            

            PasswordHasher<User> hashPass = new PasswordHasher<User>();

            string newPass = hashPass.HashPassword(this, userPassword);
            
      

            return newPass;
        }

    }
}