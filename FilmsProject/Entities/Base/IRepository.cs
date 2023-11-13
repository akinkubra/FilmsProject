using System.Linq.Expressions;

namespace FilmsProject.Entities.Base
{
    public interface IRepository<T> where T : class
    {
        List<T> GetAll();    
        T GetSingle(int id);
        T Add(T model);
        void Delete(T instance);
        void Update(T instance);
    }
}
