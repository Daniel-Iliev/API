using Data.AppDBContext;
using Data.Services.Dto;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
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
                    .Include(x=>x.Album.Performer)
                    .Select(x=>new SongDto()
                {
                    Name = x.Name,
                    AlbumName = x.Album.Name,
                    PerformerName = x.Album.Performer.Name,
                    YearReleased = x.Album.YearReleased
                    

                }).ToList();
                return (songs);
            }
        }
        
    }
}
