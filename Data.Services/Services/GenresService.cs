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
        public string AddGenre(GenrePost genre)
        {
            using (applicationDb)
            {

                var check = applicationDb.Genres.FirstOrDefault(x => x.Name == genre.Name);
                if (check == null)
                {
                    var data = new Genre()
                    {
                        Name = genre.Name,
                        CreatedAt = DateTime.Now
                    };
                    applicationDb.Genres.Add(data);
                    applicationDb.SaveChanges();
                    return "Genre " + '"' + genre.Name + '"' + " has been added succesfully";
                }
                return "Genre " + '"' + genre.Name + '"' + " already exists";
            }
        }
        public string UpdateGenre(string name, GenrePost genre)
        {
            using (applicationDb)
            {
                var findGenre = applicationDb.Genres.FirstOrDefault(x => x.Name == name);
                if (findGenre != null)
                {

                    findGenre.Name = genre.Name;
                    findGenre.ModifiedAt = DateTime.Now;
                    applicationDb.SaveChanges();
                    return "Genre " + '"' + name + '"' + " has been updated succesfully";
                }
                return "Genre " + '"' + genre.Name + '"' + " does not exist";
            }
        }
        public string DeleteGenre(string genreName)
        {
            using (applicationDb)
            {
                var genre = applicationDb.Genres.FirstOrDefault(x => x.Name == genreName);
                var albumGenres = applicationDb.AlbumGenres.FirstOrDefault(x => x.GenreId == genre.Id);
                if (genre != null)
                {
                    if (albumGenres != null)
                    {
                        return "Genre can not be deleted while it has albums";
                    }
                   
                    applicationDb.Remove(genre);
                    applicationDb.SaveChanges();
                    return "Genre " + '"' + genreName + '"' + " has been deleted succesfully";
                }
                return "Genre " + '"' + genreName + '"' + " does not exist";
            }
        }

    }
}
