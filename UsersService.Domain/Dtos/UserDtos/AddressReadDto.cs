namespace UsersService.Domain.Dtos.UserDtos
{
    public class AddressReadDto
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public string Apartment { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
    }
}