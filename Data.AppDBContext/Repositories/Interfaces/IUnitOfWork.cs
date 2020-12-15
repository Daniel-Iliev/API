using Data.Models.Models;

namespace Data.AppDBContext.Repositories.Interfaces
{
    public interface IUnitOfWork
    {
        public IRepository<Song> Songs { get; }
        public IRepository<User> Users { get; }
        public IRepository<Album> Albums { get; }
        public IRepository<Genre> Genres { get; }
        public IRepository<Performer> Performers { get; }
    }
}
