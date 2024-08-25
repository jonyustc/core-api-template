using QMS_API.Persistence;
using QMS_API.Persistence.Models;

namespace QMS_API.Application.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        Task<int> Complete();
        IRepository<T> Repository<T>() where T : BaseEntity;


    }
}
