using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UsersService.Library.GlobalInterfaces;
using UsersService.Library.UserServiceModels.BusinessModels;

namespace UsersService.Data.Entities
{
    [Index(nameof(Name), nameof(PhoneNumber), IsUnique = true)]
    public class BusinessEntity : IBusiness<BusinessAddressEntity, BusinessProfileEntity>, IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public string Identifier { get; set; }

        public BusinessAddressEntity Address { get; set; }

        [Required]
        [StringLength(100)]
        public string Email { get; set; }

        [Required]
        [StringLength(12)]
        public string PhoneNumber { get; set; }
        
        public BusinessProfileEntity BusinessProfile { get; set; }
        
    }
}
