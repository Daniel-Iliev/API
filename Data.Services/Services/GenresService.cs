using Data.AppDBContext;
using Data.Models.Models;
using Data.Services.Dto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Data.Services.Services
{
    public class GenresService
    {
        private readonly DBContext applicationDb;

        public GenresService(DBContext applicationDb)
        {
            this.applicationDb = applicationDb;
        }
        public List<GenreDto> GetAll(string order, bool decending = false)
        {
            using (applicationDb)
            {
                var genres = new List<GenreDto>();
                if (decending == true)
                {
                    switch (order)
                    {
                        case "name":
                            genres = applicationDb.Genres
                           .Include(x => x.AlbumGenres)
                           .ThenInclude(x => x.Album)
                           .Select(x => new GenreDto()
                           {
                               Name = x.Name,
                               Albums = x.AlbumGenres.Select(z => z.Album.Name).ToList(),
                               AddedOn = x.CreatedAt.ToString()
                           })
                           .OrderByDescending(x => x.Name)
                           .ToList();
                            break;

                        case "date":
                            genres = applicationDb.Genres
                           .Include(x => x.AlbumGenres)
                           .ThenInclude(x => x.Album)
                           .Select(x => new GenreDto()
                           {
                               Name = x.Name,
                               Albums = x.AlbumGenres.Select(z => z.Album.Name).ToList(),
                               AddedOn = x.CreatedAt.ToString()
                           })
                           .OrderByDescending(x => x.AddedOn)
                           .ToList();
                            break;

                        default:
                            genres = applicationDb.Genres
                           .Include(x => x.AlbumGenres)
                           .ThenInclude(x => x.Album)
                           .Select(x => new GenreDto()
                           {
                               Name = x.Name,
                               Albums = x.AlbumGenres.Select(z => z.Album.Name).ToList(),
                               AddedOn = x.CreatedAt.ToString()
                           })
                           .OrderByDescending(x => x.Name)
                           .ToList();
                            break;
                    }
                }
                else 
                {
                    switch (order)
                    {
                        case "name":
                            genres = applicationDb.Genres
                           .Include(x => x.AlbumGenres)
                           .ThenInclude(x => x.Album)
                           .Select(x => new GenreDto()
                           {
                               Name = x.Name,
                               Albums = x.AlbumGenres.Select(z => z.Album.Name).ToList(),
                               AddedOn = x.CreatedAt.ToString()
                           })
                           .OrderBy(x => x.Name)
                           .ToList();
                            break;

                        case "date":
                            genres = applicationDb.Genres
                           .Include(x => x.AlbumGenres)
                           .ThenInclude(x => x.Album)
                           .Select(x => new GenreDto()
                           {
                               Name = x.Name,
                               Albums = x.AlbumGenres.Select(z => z.Album.Name).ToList(),
                               AddedOn = x.CreatedAt.ToString()
                           })
                           .OrderBy(x => x.AddedOn)
                           .ToList();
                            break;

                        default:
                            genres = applicationDb.Genres
                           .Include(x => x.AlbumGenres)
                           .ThenInclude(x => x.Album)
                           .Select(x => new GenreDto()
                           {
                               Name = x.Name,
                               Albums = x.AlbumGenres.Select(z => z.Album.Name).ToList(),
                               AddedOn = x.CreatedAt.ToString()
                           })
                           .OrderBy(x => x.Name)
                           .ToList();
                            break;
                    }
                }
                   
                    
                    
                return (genres);
            }
        }
        public void AddGenre(GenrePost genre)
        {
            using (applicationDb)
            {
               
                var data = new Genre()
                {
                    Name = genre.Name,
                    CreatedAt = DateTime.Now
                };
                applicationDb.Genres.Add(data);


                applicationDb.SaveChanges();

            }
        }
        public void UpdateGenre(string name, GenrePost genre)
        {
            using (applicationDb)
            {
                var findGenre = applicationDb.Genres.FirstOrDefault(x => x.Name == name);
                if (findGenre != null)
                {

                    findGenre.Name = genre.Name;
                    findGenre.ModifiedAt = DateTime.Now;
                    applicationDb.SaveChanges();
                }
            }
        }

    }
}
