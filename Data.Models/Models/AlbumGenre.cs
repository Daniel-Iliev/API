﻿using Data.Models.Abstraction;

namespace Data.Models.Models
{
    public class AlbumGenre : BaseRelationModel
    {
        public string AlbumId { get; set; }
        public Album Album { get; set; }
        public string GenreId { get; set; }
        public Genre Genre { get; set; }
    }
}
