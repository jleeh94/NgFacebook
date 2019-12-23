using System;
using System.ComponentModel.DataAnnotations;

namespace NgFacebook.API.Dtos
{
    public class UserForDetailedDto
    {
        [Required]
        public string Username { get; set; }
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

        public UserForDetailedDto()
        {
            Created = DateTime.Now;
            LastActive = DateTime.Now;
        }

    }
}