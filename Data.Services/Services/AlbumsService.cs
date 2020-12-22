using Data.AppDBContext;
using Data.Models.Models;
using Data.Services.Dto;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Data.Services.Services
{
    public class AlbumsService
    {
        private readonly DBContext applicationDb;

        public AlbumsService(DBContext applicationDb)
        {
            this.applicationDb = applicationDb;
        }
        public List<AlbumDto> GetAll()
        {
            using (applicationDb)
            {
                var albums = applicationDb.Albums
                    .Include(x => x.AlbumGenres)
                    .ThenInclude(x => x.Genre)
                    .Select(x => new AlbumDto()
                    {
                        Name = x.Name,
                        YearReleased = x.YearReleased,
                        Songs = x.Songs.Select(z => z.Name).ToList(),
                        Genres = x.AlbumGenres.Select(z => z.Genre.Name).ToList(),
                        Performer = x.Performer.Name,
                        AddedOn = x.CreatedAt.Date.ToShortDateString()

                    }).ToList();
                return (albums);
            }
        }
        public Album AddAlbum(Album album)
        {
            using (applicationDb)
            {
                var add = applicationDb.Albums.Add(album);
                return album;
            }
        }


    }
}
