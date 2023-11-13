using FilmProject.Entities;

namespace FilmsProject.Repository.Interfaces
{
    public interface IFilmRepository
    {
        ICollection<Film> GetAll();
        Film GetSingle(int Id);

        void Add(Film film);

        void Update(Film film);
        void Delete(Film film);
    }
}
