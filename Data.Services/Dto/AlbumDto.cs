using System.Collections.Generic;

namespace Data.Services.Dto
{
    public class AlbumDto
    {
        public string Name { get; set; }
        public int YearReleased { get; set; }
        public List<string> Genres { get; set; }
        public int SongsCount { get; set; }

    }
}
