using Data.Models.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models.Models
{
    public class Order : BaseModel
    {
        public string BuyerId { get; set; }
        public Buyer Buyer { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
