using Data.Models.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models.Interface
{
    public interface IModel<T>
    {
        [Key]
        public T Id { get; set; }
    }
}
