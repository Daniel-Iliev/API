using Data.Models.Interface;
using Data.Models.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Data.AppDBContext
{
    public partial class DBContext : DbContext
    {
        private IConfigurationRoot configurationRoot;
        public virtual DbSet<Album> Albums { get; set; }


        public virtual DbSet<Performer> Performers { get; set; }


        public virtual DbSet<User> Users { get; set; }


        public virtual DbSet<Song> Songs { get; set; }


        public virtual DbSet<AlbumGenre> AlbumGenres { get; set; }


        public virtual DbSet<Favourite> Favourites { get; set; }


        public virtual DbSet<Genre> Genres { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            configurationRoot = new ConfigurationBuilder().SetBasePath(Path.Combine(@"C:\Users\IvanAnemi4niq\AppData\Roaming\Microsoft\UserSecrets\6cdaf365-1093-48f7-a9ca-bd1b3274c0ee")).AddJsonFile("secrets.json").Build();
            dbContextOptionsBuilder.UseSqlServer(configurationRoot.GetSection("DefaultConnection:ConnectionString").Value);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Album>().HasMany(album => album.Songs);
            modelBuilder.Entity<Album>().HasMany(album => album.AlbumGenres);
            modelBuilder.Entity<Genre>().HasMany(genre => genre.AlbumGenres);
            modelBuilder.Entity<Performer>().HasMany(performer => performer.Albums);
            modelBuilder.Entity<Performer>().HasMany(performer => performer.Songs);
            modelBuilder.Entity<Song>().HasMany(song => song.Favourites);
            modelBuilder.Entity<User>().HasMany(user => user.Favourites);
            List<User> users = new List<User>()
            {
                new User()
                {
                    Id=Guid.NewGuid().ToString(),
                    Username="George",
                    Password="123",
                    CreatedAt=DateTime.Now
                },
                new User()
                {
                    Id=Guid.NewGuid().ToString(),
                    Username="Martin",
                     Password="123",
                    CreatedAt=DateTime.Now
                },
                new User()
                {
                    Id=Guid.NewGuid().ToString(),
                    Username="Jake",
                     Password="123",
                    CreatedAt=DateTime.Now
                }
            };
            List<Performer> performers = new List<Performer>()
             {
                 new Performer()
                 {
                      Id=Guid.NewGuid().ToString(),
                     Name="Metallica",
                     CreatedAt=DateTime.Now
                 },
                  new Performer()
                 {
                      Id=Guid.NewGuid().ToString(),
                     Name="Iron Maiden",
                     CreatedAt=DateTime.Now
                 },
                   new Performer()
                 {
                      Id=Guid.NewGuid().ToString(),
                     Name="Linkin Park",
                     CreatedAt=DateTime.Now
                 },
             };
            List<Album> albums = new List<Album>()
            {
                new Album
                {
                     Id = Guid.NewGuid().ToString(),
                     Name = "Ride The Lightning",
                     YearReleased = 1984,
                     PerformerId=performers[0].Id,
                     CreatedAt = DateTime.Now
                },
                 new Album
                {
                     Id = Guid.NewGuid().ToString(),
                     Name = "Master Of Puppets",
                     YearReleased = 1986,
                     PerformerId=performers[0].Id,
                     CreatedAt = DateTime.Now
                },
                  new Album
                {
                     Id = Guid.NewGuid().ToString(),
                     Name = "Fear Of The Dark",
                     YearReleased = 1992,
                     PerformerId=performers[1].Id,
                     CreatedAt = DateTime.Now
                },
                   new Album
                {
                     Id = Guid.NewGuid().ToString(),
                     Name = "Meteora",
                     YearReleased = 2003,
                     PerformerId=performers[2].Id,
                     CreatedAt = DateTime.Now
                },
            };
            List<Song> songs = new List<Song>()
            {
                new Song()
                {
                     Id = Guid.NewGuid().ToString(),
                    Name ="Master Of Puppets",
                    AlbumId=albums[1].Id,
                    PerformerId = performers[0].Id,
                    CreatedAt = DateTime.Now

                },
                 new Song()
                {
                      Id = Guid.NewGuid().ToString(),
                    Name ="Numb",
                    AlbumId=albums[3].Id,
                    PerformerId = performers[2].Id,
                    CreatedAt = DateTime.Now

                },
                 new Song()
                {
                      Id = Guid.NewGuid().ToString(),
                    Name ="Fear Of The Dark",
                    AlbumId=albums[2].Id,
                    PerformerId = performers[1].Id,
                    CreatedAt = DateTime.Now

                },
                  new Song()
                {
                       Id = Guid.NewGuid().ToString(),
                    Name ="For Whom The Bell Tolls",
                    AlbumId=albums[0].Id,
                    PerformerId = performers[0].Id,
                    CreatedAt = DateTime.Now

                },
                   new Song()
                {
                     Id = Guid.NewGuid().ToString(),
                    Name ="Battery",
                    AlbumId=albums[1].Id,
                    PerformerId = performers[0].Id,
                    CreatedAt = DateTime.Now

                },
            };
            List<Genre> genres = new List<Genre>()
            {
                new Genre()
                {
                     Id = Guid.NewGuid().ToString(),
                    Name = "Metal",
                     CreatedAt = DateTime.Now
                },
                new Genre()
                {
                     Id = Guid.NewGuid().ToString(),
                    Name = "Nu-Metal",
                     CreatedAt = DateTime.Now
                },
                new Genre()
                {
                     Id = Guid.NewGuid().ToString(),
                    Name = "Rock",
                     CreatedAt = DateTime.Now
                },
            };
            List<AlbumGenre> albumGenres = new List<AlbumGenre>()
            {
                new AlbumGenre()
                {
                   AlbumId = albums[0].Id,
                   GenreId = genres[0].Id
                },
                new AlbumGenre()
                {
                   AlbumId = albums[1].Id,
                   GenreId = genres[2].Id
                },
                new AlbumGenre()
                {
                   AlbumId = albums[2].Id,
                   GenreId = genres[0].Id
                },
                new AlbumGenre()
                {
                   AlbumId = albums[3].Id,
                   GenreId = genres[1].Id
                },
            };
            List<Favourite> favourites = new List<Favourite>()
            {
                new Favourite()
                {
                   SongId = songs[0].Id,
                   UserId = users[0].Id,
                     CreatedAt = DateTime.Now
                },
                new Favourite()
                {
                   SongId = songs[0].Id,
                   UserId = users[1].Id,
                     CreatedAt = DateTime.Now
                },
                 new Favourite()
                {
                   SongId = songs[1].Id,
                   UserId = users[0].Id,
                     CreatedAt = DateTime.Now
                },
                  new Favourite()
                {
                   SongId = songs[1].Id,
                   UserId = users[2].Id,
                     CreatedAt = DateTime.Now
                },
                   new Favourite()
                {
                   SongId = songs[2].Id,
                   UserId = users[1].Id,
                     CreatedAt = DateTime.Now
                },
                    new Favourite()
                {
                   SongId = songs[3].Id,
                   UserId = users[0].Id,
                     CreatedAt = DateTime.Now
                },
                     new Favourite()
                {
                   SongId = songs[3].Id,
                   UserId = users[1].Id,
                     CreatedAt = DateTime.Now
                },
                      new Favourite()
                {
                   SongId = songs[3].Id,
                   UserId = users[2].Id,
                     CreatedAt = DateTime.Now
                },
            };
           
            
            modelBuilder.Entity<Album>().HasData(albums);
            modelBuilder.Entity<AlbumGenre>().HasData(albumGenres);
            modelBuilder.Entity<Favourite>().HasData(favourites);
            modelBuilder.Entity<Genre>().HasData(genres);
            modelBuilder.Entity<Performer>().HasData(performers);
            modelBuilder.Entity<Song>().HasData(songs);
            modelBuilder.Entity<User>().HasData(users);
            base.OnModelCreating(modelBuilder);


        }
        private void ApplyChanges()
        {
            var entries = this.ChangeTracker.Entries().Where(x => x.Entity is IEntryInfo).ToList();

            foreach (var entry in entries)
            {
                var entity = (IEntryInfo)entry.Entity;

                if (entry.State == EntityState.Added)
                {
                    entity.CreatedAt = DateTime.UtcNow;
                }
                else if (entry.State == EntityState.Modified)
                {
                    entity.ModifiedAt = DateTime.UtcNow;
                }
                else
                {
                    entity.DeletedAt = DateTime.UtcNow;
                }
            }
        }
        public override int SaveChanges()
        {
            return SaveChanges(true);
        }
        public override int SaveChanges(bool acceptAllChangesOnSuccess)
        {
            this.ApplyChanges();
            return base.SaveChanges(acceptAllChangesOnSuccess);
        }
        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
        {
            this.ApplyChanges();
            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return SaveChangesAsync(cancellationToken);
        }
    }
}
