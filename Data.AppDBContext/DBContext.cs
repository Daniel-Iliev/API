using Data.Models.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.AppDBContext
{
    public partial class DBContext : DbContext
    {

        public virtual DbSet<Album> Albums { get; set; }

       
        public virtual DbSet<Performer> Performers { get; set; }


        public virtual DbSet<User> Users { get; set; }


        public virtual DbSet<Product> Products { get; set; }


        public virtual DbSet<Order> Orders { get; set; }

    }
}
