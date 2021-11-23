using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersService.Domain.Dtos.BusinessDtos
{
    public class BusinessProfileCreateDto
    {
        public BusinessProfilePicCreateDto ProfilePic { get; set; }

        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        [Required(ErrorMessage = "Email is required.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(20, ErrorMessage = "Password must be between 6 and 20 characters.", MinimumLength = 6)]
        [DataType(DataType.Password, ErrorMessage = "Password must be 6 characters or more.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm Password is required")]
        [Compare("Password", ErrorMessage = "Password mismatch. Try again.")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "A username is required")]
        [StringLength(50, ErrorMessage = " User Name must be between 4 and 50 characters", MinimumLength = 4)]
        public string BusinessProfileName { get; set; }
    }
}
