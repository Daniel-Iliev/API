using Data.Models.Abstraction;

namespace Data.Models.Models
{
    public class Favourite : BaseModel
    {
        public string SongId { get; set; }
        public Song Song { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }

    }
}
