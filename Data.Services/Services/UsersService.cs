using Data.AppDBContext;
using Data.Services.Dto;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Data.Services.Services
{
    public class UsersService
    {
        private readonly DBContext applicationDb;

        public UsersService(DBContext applicationDb)
        {
            this.applicationDb = applicationDb;
        }
        public List<UserDto> GetAll()
        {
            using (applicationDb)
            {
                var users = applicationDb.Users
                    .Include(x => x.Favourites)
                    .ThenInclude(x=>x.Song)
                    .Select(x => new UserDto()
                    {
                        UserName = x.Username,
                        FavouriteSongs = x.Favourites.Select(z=>z.Song.Name).ToList(),
                        AddedOn = x.CreatedAt.Date.ToShortDateString()

                    }).ToList();
                return (users);
            }
        }

    }
}
