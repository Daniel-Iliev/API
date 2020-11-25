using Data.Models.Abstraction;
using Data.Models.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models.Models
{
    public class Product : BaseModel
    {

        [StringLength(50, MinimumLength = 3)]
        public string ProdName { get; set; }
        [Required]
        public decimal ProdPrice { get; set; }
    }
}
