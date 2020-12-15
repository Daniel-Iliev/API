using Data.Models.Abstraction;
using System;
using System.Collections.Generic;

namespace Data.AppDBContext.Repositories.Interfaces
{
    public interface IRepository<T> where T : BaseModel
    {
        IEnumerable<T> GetAll(Func<T, bool> func = null);
        void Add(T entity);
        void Remove(T entity);
        void Remove(string id);
        T Find(string id);
        void Update(T entity);
        int CommitChanges();

    }
}
