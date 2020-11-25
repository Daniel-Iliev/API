using Data.Models.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Data.AppDBContext
{
    public partial class DBContext : DbContext
    {
        private IConfigurationRoot configurationRoot;
        public virtual DbSet<Album> Albums { get; set; }


        public virtual DbSet<Performer> Performers { get; set; }


        public virtual DbSet<User> Users { get; set; }


        public virtual DbSet<Product> Products { get; set; }


        public virtual DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            configurationRoot = new ConfigurationBuilder().SetBasePath(Path.Combine(@"C:\Users\IvanAnemi4niq\AppData\Roaming\Microsoft\UserSecrets\6cdaf365-1093-48f7-a9ca-bd1b3274c0ee")).AddJsonFile("secrets.json").Build();
            dbContextOptionsBuilder.UseSqlServer(configurationRoot.GetSection("DefaultConnection:ConnectionString").Value);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Album>().HasMany(album => album.Performers);
            modelBuilder.Entity<Performer>().HasMany(performer => performer.Albums);




        }
    }
}
