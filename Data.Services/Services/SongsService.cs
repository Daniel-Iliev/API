using Data.AppDBContext;
using Data.Services.Dto;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
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
        public List<SongDto> GetAll()
        {
            using (applicationDb)
            {
                var songs = applicationDb.Songs
                    .Include(x=>x.Album)
                    .ThenInclude(x=>x.AlbumGenres)
                    .ThenInclude(x=>x.Genre)
                    .Include(x=>x.Album.Performer)
                    .Select(x=>new SongDto()
                {
                    Name = x.Name,
                    AlbumName = x.Album.Name,
                    PerformerName = x.Album.Performer.Name,
                    YearReleased = x.Album.YearReleased,
                    Genres = x.Album.AlbumGenres.Select(z => z.Genre.Name).ToList(),
                        AddedOn = x.CreatedAt.Date.ToShortDateString()


                    }).ToList();
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
                           AddedOn = x.CreatedAt.Date.ToShortDateString()
                       })
                       .Where(x => x.YearReleased < year)
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
                       AddedOn = x.CreatedAt.Date.ToShortDateString()
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
                        AddedOn = x.CreatedAt.Date.ToShortDateString()
                    })
                    .Where(x=>x.YearReleased<year&&x.PerformerName==perfName)
                    .ToList();
                return (songs);
            }
        }
        public List<SongDto> GetMostFavourited()
        {
            using (applicationDb)
            {
                var songs = applicationDb.Songs
                    .Include(x => x.Album)
                    .Include(x => x.Favourites)
                    .Select(x => new SongDto()
                    {
                        Name = x.Name,
                        PerformerName = x.Performer.Name,
                        YearReleased = x.Album.YearReleased,
                        Favourited = x.Favourites.Count(),
                        AddedOn = x.CreatedAt.Date.ToShortDateString()
                    })
                    .GroupBy(x => new { x.Name, x.PerformerName,x.Favourited})
                    .Select(x => new SongDto{ Name = x.Key.Name,PerformerName = x.Key.PerformerName, Favourited = x.Key.Favourited })
                    .OrderByDescending(x => x.Favourited)
                    .ToList();
                return (songs);
            }
        }

    }
}
