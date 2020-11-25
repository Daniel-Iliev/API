using Data.AppDBContext.Repositories.Interfaces;
using Data.Models.Abstraction;
using Data.Models.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.AppDBContext.Repositories
{
    public class UnitOfWork:IUnitOfWork
    {
        private Dictionary<Type, object> repositories;
        private DbContext Context;
        public UnitOfWork(DbContext context)
        {
            Context = context;
            repositories = new Dictionary<Type, object>();
        }
        public IRepository<User> Users
        {
            get
            {
                return this.CreateInstance<User>();
            }
        }
        public IRepository<Product> Products
        {
            get
            {
                return this.CreateInstance<Product>();
            }
        }

        public IRepository<Buyer> Buyers => throw new NotImplementedException();

        public IRepository<Order> Orders => throw new NotImplementedException();
        public IRepository<Album> Albums => throw new NotImplementedException();
        public IRepository<Performer> Performers => throw new NotImplementedException();
        private IRepository<T> CreateInstance<T>() where T : BaseModel, new()
        {
            if (!this.repositories.ContainsKey(typeof(T)))
            {
                var type = typeof(Repository<T>);
                this.repositories.Add(typeof(T), Activator.CreateInstance(type, this.Context));
            }
            return (Repository<T>)this.repositories[typeof(T)];
        }
    }
}
