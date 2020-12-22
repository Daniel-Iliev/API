using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Services.Dto
{
    public class PerformerDto
    {
        public string  Name { get; set; }
        public List<string> Albums { get; set; }
        public List<string> Songs { get; set; }
        public string AddedOn { get; set; }
    }
}
