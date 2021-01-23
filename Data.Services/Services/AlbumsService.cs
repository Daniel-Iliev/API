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
        public string AddAlbum(AlbumPost album)
        {
            using (applicationDb)
            {
                var check = applicationDb.Albums.FirstOrDefault(x=>x.Name == album.Name);
                if (check == null)
                {
                    var performer = applicationDb.Performers.FirstOrDefault(x => x.Name == album.Performer);
                    if (performer != null)
                    {
                        var data = new Album()
                        {
                            Name = album.Name,
                            YearReleased = album.YearReleased,
                            PerformerId = performer.Id
                        };
                        applicationDb.Albums.Add(data);
                        applicationDb.SaveChanges();
                        return "Album " + '"' + album.Name + '"' + " has been added succesfully";
                    }
                    return "Performer " + '"' + album.Performer + '"' + " does not exist";
                }
                return "Album " + '"' + album.Name + '"' + " already exists";
            }
        }
        public string AddAlbumGenre( AlbumGenrePost albumGenrePost)
        {
            using (applicationDb)
            {
               
                var genre = applicationDb.Genres.FirstOrDefault(x => x.Name == albumGenrePost.Genre);
                var album = applicationDb.Albums.FirstOrDefault(x => x.Name == albumGenrePost.Album);
                if (genre != null && album != null)
                {

                    var check = applicationDb.AlbumGenres.FirstOrDefault(x => x.GenreId == genre.Id && x.AlbumId == album.Id);
                    if (check == null)
                    {
                        var data = new AlbumGenre()
                        {
                            AlbumId = album.Id,
                            GenreId = genre.Id,
                        };
                        applicationDb.AlbumGenres.Add(data);
                        applicationDb.SaveChanges();
                        return "Genre " + '"' + genre.Name + '"' + " has been added to Album " + '"' + album.Name + '"' + " succesfully";
                    }
                    return "Album " + '"' + album.Name + '"' + " already has Genre " + '"' + genre.Name + '"';
                }
                else if (genre == null) {
                    return "Genre " + '"' + albumGenrePost.Genre + '"' + " does not exist";
                }
                
                    return "Album " + '"' + albumGenrePost.Album + '"' + " does not exist";
                

            }
        }
        public string UpdateAlbum(string albumName, AlbumPost album)
        {
            using (applicationDb)
            {
                var findalbum = applicationDb.Albums.FirstOrDefault(x => x.Name == albumName);
                if (findalbum != null)
                {
                    var performer = applicationDb.Performers.FirstOrDefault(x => x.Name == album.Performer);
                    if (performer != null)
                    {
                        findalbum.Name = album.Name;
                        findalbum.PerformerId = performer.Id;
                        findalbum.YearReleased = album.YearReleased;
                        applicationDb.SaveChanges();
                        return "Album " + '"' + albumName + '"' + " has been updated succesfully";
                    }
                    return "Performer " + '"' + album.Performer + '"' + " does not exist";
                }
                return "Album " + '"' + albumName + '"' + " does not exist";
            }
        }
        public string DeleteAlbum(string albumName)
        {
            using (applicationDb)
            {
                var album = applicationDb.Albums.FirstOrDefault(x => x.Name == albumName);
               
                if (album != null)
                {
                    var songs = applicationDb.Songs.FirstOrDefault(x => x.AlbumId == album.Id);
                    var albumGenres = applicationDb.AlbumGenres.FirstOrDefault(x => x.AlbumId == album.Id);
                    if (songs != null)
                    {
                        return "Album can not be deleted while it has songs";
                    }
                    else if(albumGenres != null)
                    {
                        return "Album can not be deleted while it has a genre";
                    }
                    applicationDb.Albums.Remove(album);
                    applicationDb.SaveChanges();
                    return "Album " + '"' + albumName + '"' + " has been deleted succesfully";
                }
                return "Album " + '"' + albumName + '"' + " does not exist";
            }
        }

        public string DeleteAlbumGenre(string albumName,string genreName)
        {
            using (applicationDb)
            {
                var album = applicationDb.Albums.FirstOrDefault(x => x.Name == albumName);
                var genre = applicationDb.Genres.FirstOrDefault(x => x.Name == genreName);
                if (album != null)
                {
                    if (genre != null)
                    {
                        var albumGenre = applicationDb.AlbumGenres.FirstOrDefault(x => x.AlbumId == album.Id);
                        if (albumGenre != null)
                        {
                            applicationDb.AlbumGenres.Remove(albumGenre);
                            applicationDb.SaveChanges();
                            return "Genre " + '"' + genreName + '"' + " has been succesfully removed from Album " + '"' + albumName + '"';
                        }
                        return "Album " + '"' + albumName + '"' + " does not have Genre" + '"' + genreName + '"';
                    }
                    return "Genre " + '"' + genreName + '"' + " does not exist";

                }
                return "Album " + '"' + albumName + '"' + " does not exist";
            }
        }
    }
}
