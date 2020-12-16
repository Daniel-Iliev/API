using Data.AppDBContext;
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
        public List<GenreDto> GetAll()
        {
            using (applicationDb)
            {

                var genres = applicationDb.AlbumGenres
                    .Include(x => x.Album)
                    .Include(x => x.Genre)
                    .Where(x => x.GenreId == x.Genre.Id)
                    .Select(x => new GenreDto()
                    {
                        Name = x.Genre.Name,

                    })

                    .ToList();
                    
                    
                return (genres);
            }
        }

    }
}
