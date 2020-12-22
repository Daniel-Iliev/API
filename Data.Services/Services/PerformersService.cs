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
                var performers = applicationDb.Performers
                    .Include(x => x.Songs)
                    .Include(x => x.Albums)
                    .Select(x => new PerformerDto()
                    {

                        Name = x.Name,
                        Albums = x.Albums.Select(z => z.Name).ToList(),
                        Songs = x.Songs.Select(z => z.Name).ToList(),
                        AddedOn = x.CreatedAt.Date.ToShortDateString()
                    }).ToList();
                return (performers);
            }
        }
       

    }
}
