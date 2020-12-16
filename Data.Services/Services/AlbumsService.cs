using Data.AppDBContext;
using Data.Services.Dto;
using Microsoft.EntityFrameworkCore;
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
        public List<AlbumDto> GetAll()
        {
            using (applicationDb)
            {
                var albums = applicationDb.Albums
                    .Include(x => x.AlbumGenres)
                    .Select(x => new AlbumDto()
                    {
                        Name = x.Name,
                        YearReleased = x.YearReleased,
                        SongsCount = x.Songs.Count(),
                        Genre = x.AlbumGenres.ToString()

                    }).ToList();
                return (albums);
            }
        }

    }
}
