using Data.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.AppDBContext.Repositories.Interfaces
{
   public  interface IUnitOfWork
    {
        public IRepository<User> Users { get; }
        public IRepository<Album> Albums { get; }
        public IRepository<Buyer> Buyers { get; }
        public IRepository<Order> Orders { get; }
        public IRepository<Performer> Performers { get; }
        public IRepository<Product> Products { get; }
    }
}
