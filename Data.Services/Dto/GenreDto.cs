using Data.Models.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.Services.Dto
{
    public class GenreDto
    {
        public string Name { get; set; }
        
        public List<string> Albums { get; set; }
    }
}
