using Data.AppDBContext;
using Data.AppDBContext.Repositories;
using Data.Services.Identity;
using System;

namespace TestConsole1
{
    class Program
    {
        static void Main(string[] args)
        {
            UnitOfWork unitOfWork = new UnitOfWork(new DBContext());
            //UserService userService = new UserService(new DBContext());
        }
    }
}
