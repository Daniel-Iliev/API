using Data.Models.Abstraction;
using Data.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models.Models
{
    public class Product : BaseModel
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

    }
}
