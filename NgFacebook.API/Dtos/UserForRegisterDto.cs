using System;
using System.ComponentModel.DataAnnotations;

namespace NgFacebook.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }
        [Required]
        [StringLength(15, MinimumLength = 4, ErrorMessage = "You must specify a password between 4 and 15 characters!")]
        public string Password { get; set; }
        [Required]
        public string EmailAddress { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastActive { get; set; }

        public UserForRegisterDto()
        {
            Created = DateTime.Now;
            LastActive = DateTime.Now;
        }

    }
}