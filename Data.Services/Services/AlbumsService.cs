using Data.AppDBContext;
using Data.Models.Models;
using Data.Services.Dto;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Data.Services.Services
{
    public class AlbumsService
    {
        private readonly DBContext applicationDb;

        public AlbumsService(DBContext applicationDb)
        {
            this.applicationDb = applicationDb;
        }
        public List<AlbumDto> GetAll(string order, bool decending=false)
        {
            

            using (applicationDb)
            {
                var albums = new List<AlbumDto>();
                if (decending == true)
                {
                    switch (order)
                    {
                        case "name":
                            albums = applicationDb.Albums
                            .Include(x => x.AlbumGenres)
                            .ThenInclude(x => x.Genre)
                            .Select(x => new AlbumDto()
                            {
                                Name = x.Name,
                                YearReleased = x.YearReleased,
                                Songs = x.Songs.Select(z => z.Name).ToList(),
                                Genres = x.AlbumGenres.Select(z => z.Genre.Name).ToList(),
                                Performer = x.Performer.Name,
                                AddedOn = x.CreatedAt.ToString()

                            })
                            .OrderByDescending(x => x.Name)
                            .ToList();
                            break;

                        case "year":
                            albums = applicationDb.Albums
                            .Include(x => x.AlbumGenres)
                            .ThenInclude(x => x.Genre)
                            .Select(x => new AlbumDto()
                            {
                                Name = x.Name,
                                YearReleased = x.YearReleased,
                                Songs = x.Songs.Select(z => z.Name).ToList(),
                                Genres = x.AlbumGenres.Select(z => z.Genre.Name).ToList(),
                                Performer = x.Performer.Name,
                                AddedOn = x.CreatedAt.ToString()

                            })
                            .OrderByDescending(x => x.YearReleased)
                            .ToList();
                            break;

                        case "performer":
                            albums = applicationDb.Albums
                            .Include(x => x.AlbumGenres)
                            .ThenInclude(x => x.Genre)
                            .Select(x => new AlbumDto()
                            {
                                Name = x.Name,
                                YearReleased = x.YearReleased,
                                Songs = x.Songs.Select(z => z.Name).ToList(),
                                Genres = x.AlbumGenres.Select(z => z.Genre.Name).ToList(),
                                Performer = x.Performer.Name,
                                AddedOn = x.CreatedAt.ToString()

                            })
                            .OrderByDescending(x => x.Performer)
                            .ToList();
                            break;

                        case "date":
                            albums = applicationDb.Albums
                            .Include(x => x.AlbumGenres)
                            .ThenInclude(x => x.Genre)
                            .Select(x => new AlbumDto()
                            {
                                Name = x.Name,
                                YearReleased = x.YearReleased,
                                Songs = x.Songs.Select(z => z.Name).ToList(),
                                Genres = x.AlbumGenres.Select(z => z.Genre.Name).ToList(),
                                Performer = x.Performer.Name,
                                AddedOn = x.CreatedAt.ToString()

                            })
                            .OrderByDescending(x => x.AddedOn)
                            .ToList();
                            break;


                        default:
                            albums = applicationDb.Albums
                            .Include(x => x.AlbumGenres)
                            .ThenInclude(x => x.Genre)
                            .Select(x => new AlbumDto()
                            {
                                Name = x.Name,
                                YearReleased = x.YearReleased,
                                Songs = x.Songs.Select(z => z.Name).ToList(),
                                Genres = x.AlbumGenres.Select(z => z.Genre.Name).ToList(),
                                Performer = x.Performer.Name,
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
                            albums = applicationDb.Albums
                            .Include(x => x.AlbumGenres)
                            .ThenInclude(x => x.Genre)
                            .Select(x => new AlbumDto()
                            {
                                Name = x.Name,
                                YearReleased = x.YearReleased,
                                Songs = x.Songs.Select(z => z.Name).ToList(),
                                Genres = x.AlbumGenres.Select(z => z.Genre.Name).ToList(),
                                Performer = x.Performer.Name,
                                AddedOn = x.CreatedAt.ToString()

                            })
                            .OrderBy(x => x.Name)
                            .ToList();
                            break;

                        case "year":
                            albums = applicationDb.Albums
                            .Include(x => x.AlbumGenres)
                            .ThenInclude(x => x.Genre)
                            .Select(x => new AlbumDto()
                            {
                                Name = x.Name,
                                YearReleased = x.YearReleased,
                                Songs = x.Songs.Select(z => z.Name).ToList(),
                                Genres = x.AlbumGenres.Select(z => z.Genre.Name).ToList(),
                                Performer = x.Performer.Name,
                                AddedOn = x.CreatedAt.ToString()

                            })
                            .OrderBy(x => x.YearReleased)
                            .ToList();
                            break;

                        case "performer":
                            albums = applicationDb.Albums
                            .Include(x => x.AlbumGenres)
                            .ThenInclude(x => x.Genre)
                            .Select(x => new AlbumDto()
                            {
                                Name = x.Name,
                                YearReleased = x.YearReleased,
                                Songs = x.Songs.Select(z => z.Name).ToList(),
                                Genres = x.AlbumGenres.Select(z => z.Genre.Name).ToList(),
                                Performer = x.Performer.Name,
                                AddedOn = x.CreatedAt.ToString()

                            })
                            .OrderBy(x => x.Performer)
                            .ToList();
                            break;

                        case "date":
                            albums = applicationDb.Albums
                            .Include(x => x.AlbumGenres)
                            .ThenInclude(x => x.Genre)
                            .Select(x => new AlbumDto()
                            {
                                Name = x.Name,
                                YearReleased = x.YearReleased,
                                Songs = x.Songs.Select(z => z.Name).ToList(),
                                Genres = x.AlbumGenres.Select(z => z.Genre.Name).ToList(),
                                Performer = x.Performer.Name,
                                AddedOn = x.CreatedAt.ToString()

                            })
                            .OrderBy(x => x.AddedOn)
                            .ToList();
                            break;

                        default:
                            albums = applicationDb.Albums
                            .Include(x => x.AlbumGenres)
                            .ThenInclude(x => x.Genre)
                            .Select(x => new AlbumDto()
                            {
                                Name = x.Name,
                                YearReleased = x.YearReleased,
                                Songs = x.Songs.Select(z => z.Name).ToList(),
                                Genres = x.AlbumGenres.Select(z => z.Genre.Name).ToList(),
                                Performer = x.Performer.Name,
                                AddedOn = x.CreatedAt.ToString()

                            })
                            .OrderBy(x => x.Name)
                            .ToList();
                            break;
                    }
                }
                return (albums);
            }
        }
        public void AddAlbum(AlbumPost album)
        {
            using (applicationDb)
            {
                var perf = applicationDb.Performers.FirstOrDefault(x=>x.Name==album.Performer);
                var data = new Album()
                {
                    Name = album.Name,
                    YearReleased = album.YearReleased,
                    PerformerId = perf.Id,
                    CreatedAt = DateTime.Now
                };
                applicationDb.Albums.Add(data);

                applicationDb.SaveChanges();

            }
        }
        public void AddAlbumGenre( AlbumGenrePost albumGenrePost)
        {
            using (applicationDb)
            {
               
                var genr = applicationDb.Genres.FirstOrDefault(x => x.Name == albumGenrePost.Genre);
                var alb = applicationDb.Albums.FirstOrDefault(x => x.Name == albumGenrePost.Album);
                var data = new AlbumGenre()
                {
                    AlbumId = alb.Id,
                    GenreId = genr.Id,
                };
                applicationDb.AlbumGenres.Add(data);

                applicationDb.SaveChanges();

            }
        }
        public void UpdateAlbum(string albumname, AlbumPost album)
        {
            using (applicationDb)
            {
                var findalbum = applicationDb.Albums.FirstOrDefault(x => x.Name == albumname);
                var perf = applicationDb.Performers.FirstOrDefault(x => x.Name == album.Performer);
                if (findalbum != null)
                {

                    findalbum.Name = album.Name;
                    findalbum.PerformerId = perf.Id;
                    findalbum.YearReleased = album.YearReleased;
                    findalbum.ModifiedAt = DateTime.Now;
                    applicationDb.SaveChanges();
                }
            }
        }



    }
}
