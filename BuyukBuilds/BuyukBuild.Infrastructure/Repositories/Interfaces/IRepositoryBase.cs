using BuyukBuild.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyukBuild.Infrastructure.Repositories.Interfaces
{
    public interface IRepositoryBase<T, TId> : IQueryable<T> , IAsyncEnumerable<T> where T : BaseEntity<TId>  
    {
        IQueryable<T> GetAllAsQueryable( bool asNoTracking = false);
        Task<T?> GetByIdAsync(TId id, bool asNoTracking = false);
        Task<T> AddAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task<T> DeleteAsync(TId id);
        Task<T> RemoveAsync(T entity);
        Task AddRangeAsync(params T[] values);
        Task UpdateRangeAsync(params T[] values);
        Task DeleteRangeAsync(params T[] values);

    }
}
