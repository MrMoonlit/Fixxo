using _01_AspNetMVC.models.DTO;
using System.ComponentModel.DataAnnotations;

namespace _01_AspNetMVC.ViewModels
{
    public class ContactFormViewModel
    {
        [Required(ErrorMessage = "You must enter your name")]
        public string Name { get; set; } = null!;

        [Required(ErrorMessage = "You must enter a valid email address")]
        [MinLength(5)]
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Invalid email")]
        [EmailAddress]
        public string Email { get; set; } = null!;

        [Required(ErrorMessage = "Don't forget to write your message")]
        public string Comment { get; set; } = null!;

        public string ConfirmationMsg { get; set; } = "";


        public static implicit operator CustomerCommentDTO(ContactFormViewModel model)
        {
            return new CustomerCommentDTO
            {
                Name = model.Name,
                Email = model.Email,
                Comment = model.Comment,
            };
        }

    }
}
