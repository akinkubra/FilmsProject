using FilmProject;
using FilmProject.Entities;
using FilmsProject.Repository.Interfaces;

namespace FilmsProject.Repository
{
    public class UserRepository : IUserRepository
    {
        protected DatabaseContext _dbContext;

        public UserRepository(DatabaseContext dbContext)
        {
            this._dbContext = dbContext;
        }
        public User GetSingle(int id)
        {
            var user = _dbContext.Users.AsQueryable().Where(x => x.Id == id).SingleOrDefault();

            return user;
        }
    }
}
