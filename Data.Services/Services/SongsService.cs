using Data.AppDBContext;
using Data.Services.Dto;
using System.Collections.Generic;
using System.Linq;

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
                return applicationDb.Songs.Select(x => new SongDto()
                {
                    Name = x.Name

                }).ToList();
            }
        }
        
    }
}
