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



        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlServer(@"Data Source=DOGRAMA\DANIEL;Initial Catalog=MusicApi;Integrated Security=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>().HasKey(x => new { x.ProductId, x.BuyerId });

        }
    }
}
