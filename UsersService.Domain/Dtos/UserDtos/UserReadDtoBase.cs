using UsersService.Domain.Dtos.ProfileDtos;

namespace UsersService.Domain.Dtos.UserDtos
{
    public class UserReadDtoBase
    {
        public int Id { get; set; }
        public string Identifier { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public AddressReadDto Address { get; set; }
        public UserProfileReadDto UserProfile { get; set; }
    }
}