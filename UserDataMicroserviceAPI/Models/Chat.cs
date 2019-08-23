using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace UserDataMicroserviceAPI.Models
{
    public class Chat
    {
        [Key]
        private Guid chatId;

        private List<User> chatUsers;

        private Guid chatOwnerId;

        private DateTime lastMessageTime;




    }
}
