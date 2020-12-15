using Data.Models.Abstraction;

namespace Data.Models.Models
{
    public class PerformerAlbum : BaseModel
    {
        public string AlbumId { get; set; }
        public Album Album { get; set; }
        public string PerformerId { get; set; }
        public Performer Performer { get; set; }

    }
}
