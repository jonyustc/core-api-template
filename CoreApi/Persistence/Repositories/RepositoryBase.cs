using CoreApi.Persistence;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using QMS_API.Application.Interfaces;
using QMS_API.Persistence.Models;
using QMS_API.Persistence.Services;
using System.Data;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace QMS_API.Persistence.Repositories
{
    public class RepositoryBase<T> : IRepository<T> where T : BaseEntity
    {
        private readonly DataContext _context;
        //private readonly LoggedInUserDataService _loggedInUserData;

        public RepositoryBase(DataContext oracleContext)
        {
            _context = oracleContext;
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public void Add(T entity)
        {
            entity.CreationDate = DateTime.Now;
            //entity.CreatedBy = _loggedInUserData.LoggedInUserID;
            //entity.CreatedByName = _loggedInUserData.LoggedInUserName;
            _context.Add(entity);
        }

        public void Update(T entity)
        {
            entity.LastUpdateDate = DateTime.Now;
            //entity.LastUpdateBy = _loggedInUserData.LoggedInUserID;
            //entity.LastUpdateByName = _loggedInUserData.LoggedInUserName;
            _context.Update(entity);
        }

        public IQueryable<T> GetByExpression(Expression<Func<T, bool>> expression)
        {
            return _context.Set<T>().Where(expression);
        }


        public async Task<T> GetById(long? id)
        {
            return await _context.Set<T>().FindAsync(id);
        }


        public IQueryable<T> GetByQuery(string query)
        {
            var formatableQuery = FormattableStringFactory.Create(query);
            return _context.Database.SqlQuery<T>(formatableQuery);
        } 
        

        public async Task<List<T>> GetAll()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public Task<T> GetById(long id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetQueryable()
        {
            return _context.Set<T>().AsQueryable();
        }
    }
}
