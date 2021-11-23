using System.ComponentModel.DataAnnotations;
using UsersService.Domain.Dtos.ProfileDtos;

namespace UsersService.Domain.Dtos.UserDtos
{
    public class UserUpdateDtoBase
    {
        [Required(ErrorMessage = "Id of user to update is required.")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Unique entity identifier is required.")]
        public string Identifier { get; set; }

        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        [Required(ErrorMessage = "Email is required.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "First name is required.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Phone number is required.")]
        [Phone(ErrorMessage = "Please enter a valid phone number")]
        public string PhoneNumber { get; set; }
        public AddressUpdateDto Address { get; set; }
        public UserProfileUpdateDto UserProfile { get; set; }

    }
}