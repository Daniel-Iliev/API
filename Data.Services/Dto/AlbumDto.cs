using System;
using System.Collections.Generic;

namespace Data.Services.Dto
{
    public class AlbumDto
    {
        public string Name { get; set; }
        public int YearReleased { get; set; }
        public List<string> Genres { get; set; }
        public List<string> Songs { get; set; }
        public string Performer { get; set; }
        public string AddedOn { get; set; }

    }
}
