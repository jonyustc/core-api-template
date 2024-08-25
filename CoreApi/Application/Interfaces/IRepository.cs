using System.Linq.Expressions;

namespace QMS_API.Application.Interfaces
{
    public interface IRepository<T> where T : class
    {
        IQueryable<T> GetByExpression(Expression<Func<T, bool>> expression=null);
        Task<T> GetById(long? id);
        Task<T> GetById(long id);
        Task<List<T>> GetAll();
        IQueryable<T> GetQueryable();
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        IQueryable<T> GetByQuery(string query);
    }
}
