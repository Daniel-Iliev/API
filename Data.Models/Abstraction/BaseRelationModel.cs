using Data.Models.Interface;
using System;

namespace Data.Models.Abstraction
{
    public abstract class BaseRelationModel : IModel<string>
    {
        public BaseRelationModel()
        {
            Id = Guid.NewGuid().ToString();
        }
        public string Id { get; set; }
       
    }
}
