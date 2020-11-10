using Data.Models.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
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

        private IConfigurationRoot configurationRoot;


        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlServer("Server=localhost;Initial Catalog=MusicApi;Trusted_Connection=true;");
        }

    }
}
