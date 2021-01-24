using Data.AppDBContext;
using Data.Models.Models;
using Data.Services.Dto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;

namespace Data.Services.Services
{
    public class SongsService
    {
        private readonly DBContext applicationDb;

        public SongsService(DBContext applicationDb)
        {
            this.applicationDb = applicationDb;
        }
        public List<SongDto> GetAll(string order,bool descending=false)
        {
            using (applicationDb)
            {
                var songs = new List<SongDto>();
                if (descending == true)
                {
                    switch (order)
                    {
                        case "year":
                            songs = applicationDb.Songs
                            .Include(x => x.Album)
                            .ThenInclude(x => x.AlbumGenres)
                            .ThenInclude(x => x.Genre)
                            .Include(x => x.Album.Performer)
                            .Select(x => new SongDto()
                            {
                                Name = x.Name,
                                AlbumName = x.Album.Name,
                                PerformerName = x.Performer.Name,
                                YearReleased = x.Album.YearReleased,
                                Genres = x.Album.AlbumGenres.Select(z => z.Genre.Name).ToList(),
                                Favourited = x.Favourites.Count(),
                                AddedOn = x.CreatedAt.ToString()
                            })
                            .OrderByDescending(x => x.YearReleased)
                            .ToList();
                            break;

                        case "name":
                            songs = applicationDb.Songs
                            .Include(x => x.Album)
                            .ThenInclude(x => x.AlbumGenres)
                            .ThenInclude(x => x.Genre)
                            .Include(x => x.Album.Performer)
                            .Select(x => new SongDto()
                            {
                                Name = x.Name,
                                AlbumName = x.Album.Name,
                                PerformerName = x.Performer.Name,
                                YearReleased = x.Album.YearReleased,
                                Genres = x.Album.AlbumGenres.Select(z => z.Genre.Name).ToList(),
                                Favourited = x.Favourites.Count(),
                                AddedOn = x.CreatedAt.ToString()
                            })
                            .OrderByDescending(x => x.Name)
                            .ToList();
                            break;

                        case "favourite":
                            songs = applicationDb.Songs
                            .Include(x => x.Album)
                            .ThenInclude(x => x.AlbumGenres)
                            .ThenInclude(x => x.Genre)
                            .Include(x => x.Album.Performer)
                            .Select(x => new SongDto()
                            {
                                Name = x.Name,
                                AlbumName = x.Album.Name,
                                PerformerName = x.Performer.Name,
                                YearReleased = x.Album.YearReleased,
                                Genres = x.Album.AlbumGenres.Select(z => z.Genre.Name).ToList(),
                                Favourited = x.Favourites.Count(),
                                AddedOn = x.CreatedAt.ToString()
                            })
                            .OrderByDescending(x => x.Favourited)
                            .ToList();
                            break;

                        case "performer":
                            songs = applicationDb.Songs
                            .Include(x => x.Album)
                            .ThenInclude(x => x.AlbumGenres)
                            .ThenInclude(x => x.Genre)
                            .Include(x => x.Album.Performer)
                            .Select(x => new SongDto()
                            {
                                Name = x.Name,
                                AlbumName = x.Album.Name,
                                PerformerName = x.Performer.Name,
                                YearReleased = x.Album.YearReleased,
                                Genres = x.Album.AlbumGenres.Select(z => z.Genre.Name).ToList(),
                                Favourited = x.Favourites.Count(),
                                AddedOn = x.CreatedAt.ToString()
                            })
                            .OrderByDescending(x => x.PerformerName)
                            .ToList();
                            break;

                        case "album":
                            songs = applicationDb.Songs
                            .Include(x => x.Album)
                            .ThenInclude(x => x.AlbumGenres)
                            .ThenInclude(x => x.Genre)
                            .Include(x => x.Album.Performer)
                            .Select(x => new SongDto()
                            {
                                Name = x.Name,
                                AlbumName = x.Album.Name,
                                PerformerName = x.Performer.Name,
                                YearReleased = x.Album.YearReleased,
                                Genres = x.Album.AlbumGenres.Select(z => z.Genre.Name).ToList(),
                                Favourited = x.Favourites.Count(),
                                AddedOn = x.CreatedAt.ToString()
                            })
                            .OrderByDescending(x => x.AlbumName)
                            .ToList();
                            break;

                        case "date":
                            songs = applicationDb.Songs
                            .Include(x => x.Album)
                            .ThenInclude(x => x.AlbumGenres)
                            .ThenInclude(x => x.Genre)
                            .Include(x => x.Album.Performer)
                            .Select(x => new SongDto()
                            {
                                Name = x.Name,
                                AlbumName = x.Album.Name,
                                PerformerName = x.Performer.Name,
                                YearReleased = x.Album.YearReleased,
                                Genres = x.Album.AlbumGenres.Select(z => z.Genre.Name).ToList(),
                                Favourited = x.Favourites.Count(),
                                AddedOn = x.CreatedAt.ToString()
                            })
                            .OrderByDescending(x => x.AddedOn)
                            .ToList();
                            break;

                        default:
                            songs = applicationDb.Songs
                            .Include(x => x.Album)
                            .ThenInclude(x => x.AlbumGenres)
                            .ThenInclude(x => x.Genre)
                            .Include(x => x.Album.Performer)
                            .Select(x => new SongDto()
                            {
                                Name = x.Name,
                                AlbumName = x.Album.Name,
                                PerformerName = x.Performer.Name,
                                YearReleased = x.Album.YearReleased,
                                Genres = x.Album.AlbumGenres.Select(z => z.Genre.Name).ToList(),
                                Favourited = x.Favourites.Count(),
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
                        case "year":
                            songs = applicationDb.Songs
                            .Include(x => x.Album)
                            .ThenInclude(x => x.AlbumGenres)
                            .ThenInclude(x => x.Genre)
                            .Include(x => x.Album.Performer)
                            .Select(x => new SongDto()
                            {
                                Name = x.Name,
                                AlbumName = x.Album.Name,
                                PerformerName = x.Performer.Name,
                                YearReleased = x.Album.YearReleased,
                                Genres = x.Album.AlbumGenres.Select(z => z.Genre.Name).ToList(),
                                Favourited = x.Favourites.Count(),
                                AddedOn = x.CreatedAt.ToString()
                            })
                            .OrderBy(x => x.YearReleased)
                            .ToList();
                            break;

                        case "name":
                            songs = applicationDb.Songs
                            .Include(x => x.Album)
                            .ThenInclude(x => x.AlbumGenres)
                            .ThenInclude(x => x.Genre)
                            .Include(x => x.Album.Performer)
                            .Select(x => new SongDto()
                            {
                                Name = x.Name,
                                AlbumName = x.Album.Name,
                                PerformerName = x.Performer.Name,
                                YearReleased = x.Album.YearReleased,
                                Genres = x.Album.AlbumGenres.Select(z => z.Genre.Name).ToList(),
                                Favourited = x.Favourites.Count(),
                                AddedOn = x.CreatedAt.ToString()
                            })
                            .OrderBy(x => x.Name)
                            .ToList();
                            break;

                        case "favourite":
                            songs = applicationDb.Songs
                            .Include(x => x.Album)
                            .ThenInclude(x => x.AlbumGenres)
                            .ThenInclude(x => x.Genre)
                            .Include(x => x.Album.Performer)
                            .Select(x => new SongDto()
                            {
                                Name = x.Name,
                                AlbumName = x.Album.Name,
                                PerformerName = x.Performer.Name,
                                YearReleased = x.Album.YearReleased,
                                Genres = x.Album.AlbumGenres.Select(z => z.Genre.Name).ToList(),
                                Favourited = x.Favourites.Count(),
                                AddedOn = x.CreatedAt.ToString()
                            })
                            .OrderBy(x => x.Favourited)
                            .ToList();
                            break;

                        case "performer":
                            songs = applicationDb.Songs
                            .Include(x => x.Album)
                            .ThenInclude(x => x.AlbumGenres)
                            .ThenInclude(x => x.Genre)
                            .Include(x => x.Album.Performer)
                            .Select(x => new SongDto()
                            {
                                Name = x.Name,
                                AlbumName = x.Album.Name,
                                PerformerName = x.Performer.Name,
                                YearReleased = x.Album.YearReleased,
                                Genres = x.Album.AlbumGenres.Select(z => z.Genre.Name).ToList(),
                                Favourited = x.Favourites.Count(),
                                AddedOn = x.CreatedAt.ToString()
                            })
                            .OrderBy(x => x.PerformerName)
                            .ToList();
                            break;

                        case "album":
                            songs = applicationDb.Songs
                            .Include(x => x.Album)
                            .ThenInclude(x => x.AlbumGenres)
                            .ThenInclude(x => x.Genre)
                            .Include(x => x.Album.Performer)
                            .Select(x => new SongDto()
                            {
                                Name = x.Name,
                                AlbumName = x.Album.Name,
                                PerformerName = x.Performer.Name,
                                YearReleased = x.Album.YearReleased,
                                Genres = x.Album.AlbumGenres.Select(z => z.Genre.Name).ToList(),
                                Favourited = x.Favourites.Count(),
                                AddedOn = x.CreatedAt.ToString()
                            })
                            .OrderBy(x => x.AlbumName)
                            .ToList();
                            break;

                        case "date":
                            songs = applicationDb.Songs
                            .Include(x => x.Album)
                            .ThenInclude(x => x.AlbumGenres)
                            .ThenInclude(x => x.Genre)
                            .Include(x => x.Album.Performer)
                            .Select(x => new SongDto()
                            {
                                Name = x.Name,
                                AlbumName = x.Album.Name,
                                PerformerName = x.Performer.Name,
                                YearReleased = x.Album.YearReleased,
                                Genres = x.Album.AlbumGenres.Select(z => z.Genre.Name).ToList(),
                                Favourited = x.Favourites.Count(),
                                AddedOn = x.CreatedAt.ToString()
                            })
                            .OrderBy(x => x.AddedOn)
                            .ToList();
                            break;

                        default:
                            songs = applicationDb.Songs
                            .Include(x => x.Album)
                            .ThenInclude(x => x.AlbumGenres)
                            .ThenInclude(x => x.Genre)
                            .Include(x => x.Album.Performer)
                            .Select(x => new SongDto()
                            {
                                Name = x.Name,
                                AlbumName = x.Album.Name,
                                PerformerName = x.Performer.Name,
                                YearReleased = x.Album.YearReleased,
                                Genres = x.Album.AlbumGenres.Select(z => z.Genre.Name).ToList(),
                                Favourited = x.Favourites.Count(),
                                AddedOn = x.CreatedAt.ToString()
                            })
                            .OrderBy(x => x.Name)
                            .ToList();
                            break;
                    }
                }
                    return (songs);
                
            }
        }
        public List<SongDto> GetSongsOfByYear(string perfName, int? year)
        {
            using (applicationDb)
            {
                var songs = new List<SongDto>();
                if (perfName == null)
                {
                        songs = applicationDb.Songs
                       .Include(x => x.Album)
                       .ThenInclude(x => x.AlbumGenres)
                       .ThenInclude(x => x.Genre)
                       .Include(x => x.Album.Performer)
                       .Select(x => new SongDto()
                       {
                           Name = x.Name,
                           AlbumName = x.Album.Name,
                           YearReleased = x.Album.YearReleased,
                           PerformerName = x.Performer.Name,
                           Genres = x.Album.AlbumGenres.Select(z => z.Genre.Name).ToList(),
                           Favourited = x.Favourites.Count(),
                           AddedOn = x.CreatedAt.ToString()
                       })
                       .Where(x => x.YearReleased == year)
                       .OrderByDescending(x=>x.YearReleased)
                       .ToList();
                    return (songs);
                }
                if (year == 0)
                {
                    songs = applicationDb.Songs
                   .Include(x => x.Album)
                   .ThenInclude(x => x.AlbumGenres)
                   .ThenInclude(x => x.Genre)
                   .Include(x => x.Album.Performer)
                   .Select(x => new SongDto()
                   {
                       Name = x.Name,
                       AlbumName = x.Album.Name,
                       YearReleased = x.Album.YearReleased,
                       PerformerName = x.Performer.Name,
                       Genres = x.Album.AlbumGenres.Select(z => z.Genre.Name).ToList(),
                       Favourited = x.Favourites.Count(),
                       AddedOn = x.CreatedAt.ToString()
                   })
                   .Where(x => x.PerformerName==perfName)
                   .ToList();
                    return (songs);
                }
                songs = applicationDb.Songs
                    .Include(x => x.Album)
                    .ThenInclude(x => x.AlbumGenres)
                    .ThenInclude(x => x.Genre)
                    .Include(x => x.Album.Performer)
                    .Select(x => new SongDto()
                    {
                        Name = x.Name,
                        AlbumName=x.Album.Name,
                        YearReleased = x.Album.YearReleased,
                        PerformerName = x.Performer.Name,
                        Genres = x.Album.AlbumGenres.Select(z => z.Genre.Name).ToList(),
                        Favourited = x.Favourites.Count(),
                        AddedOn = x.CreatedAt.ToString()
                    })
                    .Where(x=>x.YearReleased<year&&x.PerformerName==perfName)
                    .ToList();
                return (songs);
            }
        }
       
        public string AddSong(SongPost song)
        {
            using (applicationDb)
            {
                var check = applicationDb.Songs.FirstOrDefault(x => x.Name == song.Name);
                if (check == null)
                {
                    var performer = applicationDb.Performers.FirstOrDefault(x => x.Name == song.PerformerName);
                    var album = applicationDb.Albums.FirstOrDefault(x => x.Name == song.AlbumName);
                    if (performer != null && album != null)
                    {
                        var data = new Song()
                        {
                            Name = song.Name,
                            PerformerId = performer.Id,
                            AlbumId = album.Id
                        };
                        applicationDb.Songs.Add(data);
                        applicationDb.SaveChanges();
                        return "Song " + '"' + song.Name + '"' + " has been added succesfully";
                    }
                    else if (performer == null){ 
                        return "Performer " + '"' + song.PerformerName + '"' + " does not exist";
                    }
                    else if (album == null){
                       return "Album " + '"' + song.AlbumName + '"' + " does not exist";
                    }
                }
                return "Song " + '"' + song.Name + '"' + " already exists";
            }
        }
        public string UpdateSong(string songName,SongPost song)
        {
            using (applicationDb)
            {
                var findsong = applicationDb.Songs.FirstOrDefault(x => x.Name == songName);
                if (findsong != null)
                {
                    var performer = applicationDb.Performers.FirstOrDefault(x => x.Name == song.PerformerName);
                    var album = applicationDb.Albums.FirstOrDefault(x => x.Name == song.AlbumName);
                    if (performer != null && album != null)
                    {
                        findsong.Name = song.Name;
                        findsong.PerformerId = performer.Id;
                        findsong.AlbumId = album.Id;
                        applicationDb.SaveChanges();
                        return "Song " + '"' + songName + '"' + " has been updated succesfully";
                    }
                    else if (performer == null)
                    {
                        return "Performer " + '"' + song.PerformerName + '"' + " does not exist";
                    }
                    else if (album == null)
                    {
                        return "Album " + '"' + song.AlbumName + '"' + " does not exist";
                    }
                }
                return "Song " + '"' + songName + '"' + " does not exist";
            }
        }

        public string DeleteSong(string songname)
        {
            using (applicationDb)
            {
                var song = applicationDb.Songs.FirstOrDefault(x => x.Name == songname);
                if (song != null)
                {
                    var favs = applicationDb.Favourites.FirstOrDefault(x => x.SongId == song.Id);
                    if (favs != null) {
                        return "Song can not be deleted while it is in favourites";
                    }
                    applicationDb.Remove(song);
                    applicationDb.SaveChanges();
                    return "Song " + '"' + songname + '"' + " has been deleted succesfully";
                }
                return "Song " + '"' + songname + '"' + " does not exist";
            }
        }
    }
}
