using FilmProject;
using FilmProject.Entities;

using FilmsProject.Repository;
using FilmsProject.Repository.Interfaces;

using Microsoft.EntityFrameworkCore;

namespace FilmsProject.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        protected DatabaseContext _dbContext;

        public CategoryRepository(DatabaseContext dbContext)
        {
            this._dbContext = dbContext;
        }
        public Category GetSingle(int id)
        {
            var category = _dbContext.Categories.AsQueryable().Where(x => x.Id == id).SingleOrDefault();

            return category;
        }
    }
}
