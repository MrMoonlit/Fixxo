using FixxoApi.Models.Entities;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace FixxoApi.Models.DTOs
{
    public class SignUpModelDTO
    {
        [Required]
        [MinLength(2)]
        public string FirstName { get; set; } = null!;

        [Required]
        [MinLength(2)]
        public string LastName { get; set; } = null!;

        [Required]
        [MinLength(6)]
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$")]
        public string Email { get; set; } = null!;

        [Required]
        [MinLength(8)]
        [RegularExpression(@"^(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?=.*[^a-zA-Z0-9]).{8,}$")]
        public string Password { get; set; } = null!;


        public static implicit operator IdentityUser(SignUpModelDTO model)
        {
            return new IdentityUser
            {
                UserName = model.Email,
                Email = model.Email,
            };
        }
        
        public static implicit operator UserProfileEntity(SignUpModelDTO model)
        {
            return new UserProfileEntity
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
            };
        }
    
    }
}
