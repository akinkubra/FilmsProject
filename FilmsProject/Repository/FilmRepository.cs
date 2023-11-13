using FilmProject;
using FilmProject.Entities;

using FilmsProject.Entities.Base;
using FilmsProject.Repository.Interfaces;

using Microsoft.EntityFrameworkCore;

namespace FilmsProject.Repository
{
    public class FilmRepository : IFilmRepository
    {
        protected DatabaseContext _dbContext;

        public FilmRepository(DatabaseContext dbContext)          
        {
            this._dbContext = dbContext;
        }

        public void Add(Film film)
        {
            _dbContext.Add(film);
            _dbContext.SaveChanges();
        }

        public void Delete(Film film)
        {
            _dbContext.Remove(film);
            _dbContext.SaveChanges();
        }

        public ICollection<Film> GetAll() {

           var FilmList = _dbContext.Films.AsQueryable().Include(x => x.Category).Where(x => x.IsDeleted == false).ToList();

            return FilmList;
        }

        public Film GetSingle(int filmId)
        {
            var film = _dbContext.Films.AsQueryable().Include(x => x.Category).Where(x => x.Id == filmId).SingleOrDefault();

            return film;
        }

        public void Update(Film film)
        {
            _dbContext.Update(film);
            _dbContext.SaveChanges();
        }
    }
}
