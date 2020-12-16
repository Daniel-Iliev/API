using Data.AppDBContext;
using Data.Models.Models;
using Data.Services.Dto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace Data.Services.Services
{
    public class PerformersService
    {
        private readonly DBContext applicationDb;

        public PerformersService(DBContext applicationDb)
        {
            this.applicationDb = applicationDb;
        }
        public List<PerformerDto> GetAll()
        {
            using (applicationDb)
            {
                var performers = applicationDb.PerformerAlbums
                    .Include(x => x.Album)
                    .Include(x => x.Performer)
                    .Where(x=>x.Album.PerformerId==x.Performer.Id)
                    .Select(x => new PerformerDto()
                    {
                        
                        Name = x.Performer.Name,
                        AlbumsCount = x.Performer.PerformerAlbums.Count(),
                        SongsCount = x.Album.Songs.Count(),
                        
                    }).Distinct()
                    
                    .ToList();
                return (performers);
            }
        }
    }
}
