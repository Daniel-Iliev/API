using Data.Models.Abstraction;
using System.Collections.Generic;

namespace Data.Models.Models
{
    public class Genre : BaseModel
    {
        public string Name { get; set; }
        public ICollection<AlbumGenre> AlbumGenres { get; set; }
    }
}
