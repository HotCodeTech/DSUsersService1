using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersService.Library.GlobalInterfaces;
using UsersService.Library.UserServiceModels.UserModels;

namespace UsersService.Data.Entities
{
    public class AddressEntity : IAddress, IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Identifier { get; set; }

        [StringLength(10)]
        public string Apartment { get; set; }

        [StringLength(20)]
        [Required]
        public string City { get; set; }

        [StringLength(20)]
        [Required]
        public string State { get; set; }
        
        [StringLength(50)]
        [Required]
        public string Street { get; set; }

        [StringLength(5)]
        [Required]
        public string Zipcode { get; set; }


        // Naviagation Properties.
        [ForeignKey("Id")]
        public int UserId { get; set; }
        public UserEntity User { get; set; }
    }
}
