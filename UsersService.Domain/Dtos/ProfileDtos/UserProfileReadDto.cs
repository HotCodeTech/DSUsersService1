namespace UsersService.Domain.Dtos.ProfileDtos
{
    public class UserProfileReadDto
    {
        public int Id { get; set; }
        public ProfilePicReadDto ProfilePic { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
    }
}