using Data.Models.Abstraction;
using System.Collections.Generic;

namespace Data.Models.Models
{
    public class Performer : BaseModel
    {
        public string Name { get; set; }
        public ICollection<Song> Songs { get; set; }
        public ICollection<Album> Albums { get; set; }
    }
}
