using Data.Models.Abstraction;
using System.Collections.Generic;

namespace Data.Models.Models
{
    public class Song : BaseModel
    {
        public string Name { get; set; }
        public ICollection<Favourite> Favourites { get; set; }
        public string AlbumId { get; set; }
        public Album Album { get; set; }
        public string PerformerId { get; set; }
        public Performer Performer { get; set; }
    }
}

