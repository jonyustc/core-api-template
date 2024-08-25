using CoreApi.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using QMS_API.Application.Interfaces;
using QMS_API.Persistence.Models;
using QMS_API.Persistence.Services;
using System.Runtime.CompilerServices;

namespace QMS_API.Persistence.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _context;
        //private LoggedInUserDataService _loggedInUserData;

        public UnitOfWork(DataContext context)
        {
            _context = context;
        }

        public async Task<int> ExecWithStoreProcedure(string query, params object[] parameters)
        {
            return await _context.Database.ExecuteSqlRawAsync(query, parameters);
        }

        public IQueryable<int> ExecuteRawQuery(string query)
        {
            var formatableQuery = FormattableStringFactory.Create(query);
            return _context.Database.SqlQuery<int>(formatableQuery);
        }
        
        public async Task<int> Complete()
        {
            return await _context.SaveChangesAsync();
        }
        
        public void Dispose()
        {
            _context.Dispose();
        }

        public IRepository<T> Repository<T>() where T : BaseEntity
        {
            return new RepositoryBase<T>(_context);
        }
    }
}
