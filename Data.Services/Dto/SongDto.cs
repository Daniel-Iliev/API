using System;
using System.Collections.Generic;

namespace Data.Services.Dto
{
    public class SongDto
    {
        public string Name { get; set; }
        public string AlbumName { get; set; }
        public int YearReleased { get; set; }
        public string  PerformerName { get; set; }
        public List<string> Genres { get; set; }
        public string AddedOn { get; set; }
        public int Favourited { get; set; }
    }
}
