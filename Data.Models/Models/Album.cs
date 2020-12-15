using Data.Models.Abstraction;
using System.Collections.Generic;

namespace Data.Models.Models
{
    public class Album : BaseModel
    {

        public string Name { get; set; }

        public int YearReleased { get; set; }

        public ICollection<Song> Songs { get; set; }
        public ICollection<AlbumGenre> AlbumGenres { get; set; }
        public string PerformerId { get; set; }
        public Performer Performer { get; set; }
    }
}
