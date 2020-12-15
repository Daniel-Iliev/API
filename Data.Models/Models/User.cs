using Data.Models.Abstraction;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Data.Models.Models
{
    public class User : BaseModel
    {
        [Required]
        [StringLength(20)]
        public string Username { get; set; }
        [Required]
        [StringLength(16,MinimumLength =4) ]
        public string Password { get; set; }
        [Required]
        public string Email { get; set; }
        public ICollection<Favourite> Favourites { get; set; }
    }
}
