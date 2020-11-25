using Data.AppDBContext;
using Data.Services.Identity;
using System;

namespace TestConsole
{
    public class Test
    {
        UserService userService = new UserService(new DBContext());
    }
}
