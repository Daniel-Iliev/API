using Data.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Services.Dto
{
    public class GenreDto
    {
        public string Name { get; set; }
        public List<Album> Albums { get; set; }
    }
}
