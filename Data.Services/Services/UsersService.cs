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
                var findUser = applicationDb.Users.FirstOrDefault(x => x.Username == username);
                if (findUser!=null) 
                {
                    var song = applicationDb.Songs.FirstOrDefault(x => x.Name == songName);
                    if (song != null)
                    {
                        var data = new Favourite()
                        {
                            UserId = findUser.Id,
                            SongId = song.Id
                        };
                        applicationDb.Favourites.Add(data);
                        applicationDb.SaveChanges();
                        return "Song " + '"' + songName + '"' + " added to favourites succesfully";
                    }
                    else {
                        return "Song " + '"' + songName + '"' + " does not exist";
                    }
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
                var favourite = applicationDb.Favourites.FirstOrDefault(x => x.SongId == song.Id && x.UserId == findUser.Id);
                if (findUser != null)
                {
                    if (song != null)
                    {
                        if (favourite != null)
                        {

                            applicationDb.Favourites.Remove(favourite);
                            applicationDb.SaveChanges();
                            return "Song " + '"' + songname + '"' + " has been succesfully deleted from your favourites";
                        }
                        return "Song " + '"' + songname + '"' + " does not exist in your favourites";
                    }
                    return "Song " + '"' + songname + '"' + " does not exist";
                }
                return "Invalid token";
            }
        }
        public string DeleteUser(string username)
        {
            using (applicationDb)
            {
                var findUser = applicationDb.Users.FirstOrDefault(x => x.Username == username);
                var favs = applicationDb.Favourites.FirstOrDefault(x=>x.UserId == findUser.Id);
                if (findUser != null)
                {
                    if (favs != null)
                    {
                        return "User " + '"' + username + '"' + " can not be deleted while it has favourites";
                    }

                    applicationDb.Users.Remove(findUser);
                    applicationDb.SaveChanges();
                    return "User " + '"' + username + '"' + " has been succesfully deleted";
                   
                }
                return "User " + '"' + username + '"' + " does not exist";
            }
        }
        public string UpdateUserRole(string username,string role)
        {
            using (applicationDb)
            {
                var findUser = applicationDb.Users.FirstOrDefault(x => x.Username == username);
                if (findUser != null)
                {
                    if (findUser.Role == role)
                    {
                        return "User is already in that role";
                    }
                    findUser.Role = role;
                    applicationDb.SaveChanges();
                    return "User " + '"' + username + '"' + "'s role been succesfully changed to " + role;
                }
                return "User " + '"' + username + '"' + " does not exist";
            }
        }
        public List<FavouriteDto> GetFavourites(string username)
        {
            using (applicationDb)
            {
                var favourites = new List<FavouriteDto>();
                            favourites = applicationDb.Users
                            .Where(x =>x.Username == username)
                           .Include(x => x.Favourites)
                           .ThenInclude(x => x.Song)
                           .Select(x => new FavouriteDto()
                           {
                               FavouriteSongs= x.Favourites.Select(z => z.Song.Name).ToList(),
                           })
                          
                           .ToList();
                            return (favourites);
            }
        
        }

    }
}
