using Data.AppDBContext;
using Data.Models.Models;
using Data.Services.Dto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

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
        public void AddFavourite(FavouritePost favourite)
        {
            using (applicationDb)
            {

                var song = applicationDb.Songs.FirstOrDefault(x => x.Name == favourite.Song);
                var user = applicationDb.Users.FirstOrDefault(x => x.Username == favourite.User);
                var data = new Favourite()
                {
                    UserId = user.Id,
                    SongId = song.Id,
                    CreatedAt = DateTime.Now
                };
                applicationDb.Favourites.Add(data);


                applicationDb.SaveChanges();

            }
        }
        public void ChangeUsername(string name, UserPost user)
        {
            using (applicationDb)
            {
                var findUser = applicationDb.Users.FirstOrDefault(x => x.Username == name);
                if (findUser != null)
                {

                    findUser.Username = user.UserName;
                    findUser.ModifiedAt = DateTime.Now;
                    applicationDb.SaveChanges();
                }
            }
        }

    }
}
