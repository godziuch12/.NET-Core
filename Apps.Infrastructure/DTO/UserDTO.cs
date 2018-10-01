using System;

namespace Apps.Infrastructure.DTO
{
    public class UserDTO
    {
        public Guid Id {get; set;}
        public string Email {get; set;}
        public string Username {get; set;}
        public string FulName {get; set;}
    }
}