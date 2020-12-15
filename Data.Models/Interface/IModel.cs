using System.ComponentModel.DataAnnotations;

namespace Data.Models.Interface
{
    public interface IModel<T>
    {
        [Key]
        public T Id { get; set; }
    }
}
