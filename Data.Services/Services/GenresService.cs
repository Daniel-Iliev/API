using Data.AppDBContext;
using Data.Models.Models;
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

                var genres = applicationDb.Genres
                    .Include(x => x.AlbumGenres)
                    .ThenInclude(x => x.Album)
                    .Select(x => new GenreDto()
                    {
                        Name = x.Name,
                        Albums = x.AlbumGenres.Select(z=>z.Album.Name).ToList(),
                        AddedOn = x.CreatedAt.Date.ToShortDateString()
                    }).ToList();
                   
                    
                    
                return (genres);
            }
        }

    }
}
