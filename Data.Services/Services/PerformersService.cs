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
        public List<PerformerDto> GetAll(string order, bool decending = false)
        {
            using (applicationDb)
            {
                var performers = new List<PerformerDto>();
                if (decending == true)
                {
                    switch (order)
                    {
                        case "name":
                            performers = applicationDb.Performers
                            .Include(x => x.Songs)
                            .Include(x => x.Albums)
                            .Select(x => new PerformerDto()
                            {

                                Name = x.Name,
                                Albums = x.Albums.Select(z => z.Name).ToList(),
                                Songs = x.Songs.Select(z => z.Name).ToList(),
                                AddedOn = x.CreatedAt.ToString()
                            })
                            .OrderByDescending(x => x.Name)
                            .ToList();
                            break;

                        case "date":
                            performers = applicationDb.Performers
                            .Include(x => x.Songs)
                            .Include(x => x.Albums)
                            .Select(x => new PerformerDto()
                            {

                                Name = x.Name,
                                Albums = x.Albums.Select(z => z.Name).ToList(),
                                Songs = x.Songs.Select(z => z.Name).ToList(),
                                AddedOn = x.CreatedAt.ToString()
                            })
                            .OrderByDescending(x => x.AddedOn)
                            .ToList();
                            break;

                         default:
                            performers = applicationDb.Performers
                            .Include(x => x.Songs)
                            .Include(x => x.Albums)
                            .Select(x => new PerformerDto()
                            {

                                Name = x.Name,
                                Albums = x.Albums.Select(z => z.Name).ToList(),
                                Songs = x.Songs.Select(z => z.Name).ToList(),
                                AddedOn = x.CreatedAt.ToString()
                            })
                            .OrderByDescending(x => x.Name)
                            .ToList();
                            break;
                    }
                }
                else
                {
                    switch (order)
                    {
                        case "name":
                            performers = applicationDb.Performers
                            .Include(x => x.Songs)
                            .Include(x => x.Albums)
                            .Select(x => new PerformerDto()
                            {

                                Name = x.Name,
                                Albums = x.Albums.Select(z => z.Name).ToList(),
                                Songs = x.Songs.Select(z => z.Name).ToList(),
                                AddedOn = x.CreatedAt.ToString()
                            })
                            .OrderBy(x => x.Name)
                            .ToList();
                            break;

                        case "date":
                            performers = applicationDb.Performers
                            .Include(x => x.Songs)
                            .Include(x => x.Albums)
                            .Select(x => new PerformerDto()
                            {

                                Name = x.Name,
                                Albums = x.Albums.Select(z => z.Name).ToList(),
                                Songs = x.Songs.Select(z => z.Name).ToList(),
                                AddedOn = x.CreatedAt.ToString()
                            })
                            .OrderBy(x => x.AddedOn)
                            .ToList();
                            break;

                        default:
                            performers = applicationDb.Performers
                            .Include(x => x.Songs)
                            .Include(x => x.Albums)
                            .Select(x => new PerformerDto()
                            {

                                Name = x.Name,
                                Albums = x.Albums.Select(z => z.Name).ToList(),
                                Songs = x.Songs.Select(z => z.Name).ToList(),
                                AddedOn = x.CreatedAt.ToString()
                            })
                            .OrderBy(x => x.Name)
                            .ToList();
                            break;
                    }
                }
                return (performers);
            }
        }
        public string AddPerformer(PerformerPost performer)
        {
            using (applicationDb)
            {
                var check = applicationDb.Performers.FirstOrDefault(x => x.Name == performer.Name);
                if (check == null)
                {
                    var data = new Performer()
                    {
                        Name = performer.Name,
                        CreatedAt = DateTime.Now
                    };
                    applicationDb.Performers.Add(data);
                    applicationDb.SaveChanges();
                    return "Performer " + '"' + performer.Name + '"' + " has been added succesfully";
                }
                return "Performer " + '"' + performer.Name + '"' + " already exists";
            }
        }
        public string UpdatePerformer(string performerName, PerformerPost performer)
        {
            using (applicationDb)
            {
                var findPerformer = applicationDb.Performers.FirstOrDefault(x => x.Name == performerName);
                if (findPerformer != null)
                {

                    findPerformer.Name = performer.Name;
                    findPerformer.ModifiedAt = DateTime.Now;
                    applicationDb.SaveChanges();
                    return "Performer " + '"' + performer.Name + '"' + " has been updated succesfully";
                }
                return "Performer " + '"' + performerName + '"' + " has been added succesfully";

            }
        }

        public string DeletePerformer(string performerName)
        {
            using (applicationDb)
            {
                var performer = applicationDb.Performers.FirstOrDefault(x => x.Name == performerName);
                var song = applicationDb.Songs.FirstOrDefault(x => x.PerformerId == performer.Id);
                var album = applicationDb.Albums.FirstOrDefault(x => x.PerformerId == performer.Id);
                if (performer != null)
                {
                    if (album != null)
                    {
                       
                        return "Performer can not be deleted while it has albums";
                    }
                    if (song != null)
                    {
                        return "Performer can not be deleted while it has songs";
                    }
                    applicationDb.Remove(performer);
                    applicationDb.SaveChanges();
                    return "Performer " + '"' + performerName + '"' + " has been deleted succesfully";
                }
                return "Performer " + '"' + performerName + '"' + " does not exist";
            }
        }

    }
}
