using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Models.Interface
{
    public interface IEntryInfo
    {
        public DateTime CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public DateTime? DeletedAt { get; set; }

    }
}
