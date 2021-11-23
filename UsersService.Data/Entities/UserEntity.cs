using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UsersService.Library.GlobalInterfaces;
using UsersService.Library.UserServiceModels.UserModels;

namespace UsersService.Data.Entities
{
    [Index(nameof(Email), nameof(PhoneNumber), IsUnique = true)]
    public class UserEntity : IUser<AddressEntity, ProfileEntity>,IEntity, IUserEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Identifier { get; set; }

        [Required]
        [StringLength(100)]
        public string Email { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [StringLength(12)]
        public string PhoneNumber { get; set; }
        public AddressEntity Address { get; set; }
        public ProfileEntity UserProfile { get; set; }
        public int UserCategory { get; set; }
    }
}
