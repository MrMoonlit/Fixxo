using _01_AspNetMVC.models.DTO;
using System.ComponentModel.DataAnnotations;

namespace _01_AspNetMVC.ViewModels
{
    public class LoginFormViewModel
    {
        [Required(ErrorMessage = "Field is required")]
        [EmailAddress]
        public string Email { get; set; } = null!;

        [Required(ErrorMessage = "Filed is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;

        public static implicit operator LoginDTO(LoginFormViewModel model)
        {
            return new LoginDTO
            {
                Email = model.Email,
                Password = model.Password,
            };
        }
    }
}
