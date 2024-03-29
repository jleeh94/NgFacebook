using System;
using System.Collections.Generic;

namespace NgFacebook.API.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }        
        public DateTime Created { get; set; }
        public DateTime LastActive { get; set; }
        
    }
}