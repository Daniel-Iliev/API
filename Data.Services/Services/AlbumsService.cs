using Data.AppDBContext;
using Data.Models.Models;
using Data.Services.Dto;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
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
        //public void AddAlbum(string name,int yearreleased,string perfname)
        //{
        //    using (applicationDb)
        //    {
                
        //            var album = new Album()
        //            {
        //                Name = name,
        //                YearReleased=yearreleased,
        //                PerformerId = applicationDb.Performers.Select(x => x.Id.Where(x.Name ==perfname))
        //            };
        //            applicationDb.Albums.Add(album);


        //            applicationDb.SaveChanges();
                
        //    }
        //}


    }
}
