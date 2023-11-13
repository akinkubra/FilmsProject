using FilmProject.Entities;

namespace FilmsProject.Repository.Interfaces
{
    public interface IUserRepository
    {
        User GetSingle(int id);
    }
}
