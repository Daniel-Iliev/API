using Data.AppDBContext;
using Data.Models.Models;
using Data.Services.Dto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading;

namespace Data.Services.Services
{
    public class UsersService
    {
        private readonly DBContext applicationDb;

        public UsersService(DBContext applicationDb)
        {
            this.applicationDb = applicationDb;
        }
        public List<UserDto> GetAll(string order, bool decending = false)
        {
            using (applicationDb)
            {
                var users = new List<UserDto>();
                if (decending == true)
                {
                    switch (order)
                    {
                        case "name":
                            users = applicationDb.Users
                           .Include(x => x.Favourites)
                           .ThenInclude(x => x.Song)
                           .Select(x => new UserDto()
                           {
                               UserName = x.Username,
                               FavouriteSongs = x.Favourites.Select(z => z.Song.Name).ToList(),
                               AddedOn = x.CreatedAt.ToString()
                           })
                           .OrderByDescending(x => x.UserName)
                           .ToList();
                            break;

                        case "date":
                            users = applicationDb.Users
                           .Include(x => x.Favourites)
                           .ThenInclude(x => x.Song)
                           .Select(x => new UserDto()
                           {
                               UserName = x.Username,
                               FavouriteSongs = x.Favourites.Select(z => z.Song.Name).ToList(),
                               AddedOn = x.CreatedAt.ToString()
                           })
                           .OrderByDescending(x => x.AddedOn)
                           .ToList();
                            break;

                        default:
                            users = applicationDb.Users
                           .Include(x => x.Favourites)
                           .ThenInclude(x => x.Song)
                           .Select(x => new UserDto()
                           {
                               UserName = x.Username,
                               FavouriteSongs = x.Favourites.Select(z => z.Song.Name).ToList(),
                               AddedOn = x.CreatedAt.ToString()
                           })
                           .OrderByDescending(x => x.UserName)
                           .ToList();
                            break;
                    }
                }
                else
                {
                    switch (order)
                    {
                        case "name":
                            users = applicationDb.Users
                           .Include(x => x.Favourites)
                           .ThenInclude(x => x.Song)
                           .Select(x => new UserDto()
                           {
                               UserName = x.Username,
                               FavouriteSongs = x.Favourites.Select(z => z.Song.Name).ToList(),
                               AddedOn = x.CreatedAt.ToString()
                           })
                           .OrderBy(x => x.UserName)
                           .ToList();
                            break;

                        case "date":
                            users = applicationDb.Users
                           .Include(x => x.Favourites)
                           .ThenInclude(x => x.Song)
                           .Select(x => new UserDto()
                           {
                               UserName = x.Username,
                               FavouriteSongs = x.Favourites.Select(z => z.Song.Name).ToList(),
                               AddedOn = x.CreatedAt.ToString()
                           })
                           .OrderBy(x => x.AddedOn)
                           .ToList();
                            break;

                        default:
                            users = applicationDb.Users
                           .Include(x => x.Favourites)
                           .ThenInclude(x => x.Song)
                           .Select(x => new UserDto()
                           {
                               UserName = x.Username,
                               FavouriteSongs = x.Favourites.Select(z => z.Song.Name).ToList(),
                               AddedOn = x.CreatedAt.ToString()
                           })
                           .OrderBy(x => x.UserName)
                           .ToList();
                            break;
                    }
                }
                return (users);
            }
        }
        public string AddFavourite(string username,string songName)
        {
            using (applicationDb)
            {

                var song = applicationDb.Songs.FirstOrDefault(x => x.Name == songName);
                var findUser = applicationDb.Users.FirstOrDefault(x => x.Username == username);
                if (findUser!=null) 
                {
                    var data = new Favourite()
                    {
                        UserId = findUser.Id,
                        SongId = song.Id,
                        CreatedAt = DateTime.Now
                    };
                    applicationDb.Favourites.Add(data);
                    applicationDb.SaveChanges();
                    return "Song " + '"' + songName + '"' + " added to favourites succesfully";
                }
                return "Invalid Token";
            }
        }

        public string DeleteFavourite(string username,string songname)
        {
            using (applicationDb)
            {
                var findUser = applicationDb.Users.FirstOrDefault(x => x.Username == username);
                var song = applicationDb.Songs.FirstOrDefault(x => x.Name == songname);
                var favs = applicationDb.Favourites.FirstOrDefault(x => x.SongId == song.Id && x.UserId == findUser.Id);
                if (song!=null) {
                    if (favs != null)
                    {

                        applicationDb.Favourites.Remove(favs);
                        applicationDb.SaveChanges();
                        return "Song " + '"' + songname + '"' + " has been succesfully deleted from your favourites";
                    }
                    return "Song " + '"' + songname + '"' + " does not exist in your favourites";
                }
                return "Song " + '"' + songname + '"' + " does not exist";
            }
        }

    }
}
