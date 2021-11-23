using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UsersService.Library.GlobalInterfaces;
using UsersService.Library.UserServiceModels.ProfileModels;
using UsersService.Library.UserServiceModels.UserModels;

namespace UsersService.Data.Entities
{
    public class ProfilePicEntity : IProfilePic, IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Identifier { get; set; }

        public int Height { get; set; }

        [Required]
        public string SourcePath { get; set; }

        public int Width { get; set; }

        // Navigation properties
        [ForeignKey("Id")]
        public int UserProfileId { get; set; }

        public ProfileEntity UserProfile { get; set; }
       
    }
}