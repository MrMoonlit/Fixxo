using _01_AspNetMVC.models.DTO;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace _01_AspNetMVC.ViewModels
{
    public class RegisterFormViewModel
    {
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "This field is required")]
        [MinLength(2, ErrorMessage = "Must contain atleast 2 characters")]
        public string FirstName { get; set; } = null!;

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "This field is required")]
        [MinLength(2, ErrorMessage = "Must contain atleast 2 characters")]
        public string LastName { get; set; } = null!;

        [Display(Name = "Email")]
        [EmailAddress]
        [Required(ErrorMessage = "This field is required")]
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Not a valid email")]
        public string Email { get; set; } = null!;

        [Display(Name = "Password")]
        [Required(ErrorMessage = "This field is required")]
        [RegularExpression(@"^(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?=.*[^a-zA-Z0-9]).{8,}$", ErrorMessage = "Not a valid password")]
        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;

        [Required(ErrorMessage = "This field is required")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare(nameof(Password), ErrorMessage = "The passwords don't match")]
        public string ConfirmPassword { get; set; } = null!;
        
        public static implicit operator RegisterUserDTO(RegisterFormViewModel model)
        {
            return new RegisterUserDTO
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                Password = model.Password,
            };
        }
    }
}
