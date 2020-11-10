using Data.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models.Abstraction
{
    public abstract class BaseModel : IModel<string>, IEntryInfo
    {
        public BaseModel()
        {
            Id = Guid.NewGuid().ToString();
        }
        public string Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
