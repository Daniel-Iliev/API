using Data.Models.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models.Models
{
    public class User : BaseModel
    {
        public string Name { get; set; }
        public string Email { get; set; }


    }
}
