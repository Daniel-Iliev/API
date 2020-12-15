using Data.AppDBContext.Repositories.Interfaces;
using Data.Models.Abstraction;
using Data.Models.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
namespace Data.AppDBContext.Repositories
{
    public class UnitOfWork : IUnitOfWork
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
        public IRepository<Song> Songs
        {
            get
            {
                return this.CreateInstance<Song>();
            }
        }

        public IRepository<Album> Albums => throw new NotImplementedException();

        public IRepository<Genre> Genres => throw new NotImplementedException();
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
