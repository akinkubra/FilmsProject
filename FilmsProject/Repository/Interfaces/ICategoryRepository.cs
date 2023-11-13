using FilmProject.Entities;

namespace FilmsProject.Repository.Interfaces
{
    public interface ICategoryRepository
    {
        Category GetSingle(int id);
    }
}
