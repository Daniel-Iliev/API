using System;
using System.Collections.Generic;

namespace Data.Services.Dto
{
    public class UserDto
    {
        public string UserName { get; set; }
        public List<string> FavouriteSongs { get; set; }
        public string AddedOn { get; set; }

    }
}
