using Data.AppDBContext.Repositories.Interfaces;
using Data.Models.Abstraction;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.AppDBContext.Repositories
{
    public class Repository<T> : IRepository<T> where T : BaseModel
    {
        private DbContext DbContext { get; }
        private DbSet<T> DbSet { get; }
        public Repository(DbContext context)
        {
            DbContext = context ?? throw new ArgumentException("Db context is null");
            DbSet = this.DbContext.Set<T>();
        }
        public void Add(T entity)
        {
            try
            {
                EntityEntry entry = this.DbContext.Entry(entity);
                if (entry.State != EntityState.Detached)
                {
                    entry.State = EntityState.Added;
                }
                else
                {
                    this.DbSet.Add(entity);
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }

        public int CommitChanges()
        {
            return this.DbContext.SaveChanges();
        }

        public T Find(string id)
        {
            try
            {
                var entity = this.DbSet.FirstOrDefault(x => x.Id == id);

                if (entity != null)
                {
                    return entity;
                }
                return default;
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public IEnumerable<T> GetAll(Func<T, bool> func = null)
        {
            if (func != null)
            {
                return this.DbSet.Where(func);
            }
            return this.DbSet.AsEnumerable<T>();
        }

        public void Remove(T entity)
        {
            try
            {
                var res = this.DbSet.Find(entity);
                if (res != null)
                {
                    this.Remove(res);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void Remove(string id)
        {
            try
            {
                var entity = this.DbSet.Where(x => x.Id == id).Single();
                if (entity != null)
                {
                    this.DbSet.Remove(entity);
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }

        public void Update(T entity)
        {
            try
            {
                EntityEntry entry = this.DbContext.Entry(entity);
                if (entry.State == EntityState.Detached)
                {
                    this.DbSet.Attach(entity);
                }
                entry.State = EntityState.Modified;
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }
    }
}
