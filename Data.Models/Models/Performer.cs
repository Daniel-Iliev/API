﻿using Data.Models.Abstraction;
using System.Collections.Generic;

namespace Data.Models.Models
{
    public class Performer : BaseModel
    {
        public string Name { get; set; }
        public ICollection<PerformerAlbum> PerformerAlbums { get; set; }
    }
}
