using BuyukBuild.Domain.Entities.Common;
using BuyukBuild.Infrastructure.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BuyukBuild.Infrastructure.Repositories
{
    public class RepositoryBase<T, TId> :
        IRepositoryBase<T, TId> ,
        IAsyncEnumerable<T> where T :
        BaseEntity<TId>
    {
        private protected readonly DbContext context;

        public RepositoryBase(DbContext context)
        {
            this.context = context;
        }

        public Type ElementType
        {
            get => this.GetAllAsQueryable().ElementType;
        }

        public Expression Expression
        {
            get => this.GetAllAsQueryable()!.Expression;
        }

        public IQueryProvider Provider
        {
            get => this.GetAllAsQueryable().Provider;
        }

        public async Task<T> AddAsync(T entity)
        {
            var result = await this.context.Set<T>()
                .AddAsync(entity);
            await this.context.SaveChangesAsync();
            return result.Entity;
        }

        public async Task AddRangeAsync(params T[] values)
        {
            await this.context.Set<T>()
                .AddRangeAsync(values);
            await this.context.SaveChangesAsync();

        }

        public async Task<T> DeleteAsync(TId id)
        {
            var  result = await GetByIdAsync(id);
             this.context.Set<T>().Remove(result);
            await this.context.SaveChangesAsync();
            return result;
        }

        public async Task DeleteRangeAsync(params T[] values)
        {
             this.context.Set<T>()
                                     .RemoveRange(values);
            await this.context.SaveChangesAsync();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public IQueryable<T> GetAllAsQueryable(bool asNoTracking = false)
        {
            if(asNoTracking)
            {
                return this.context.Set<T>()
                    .AsNoTracking();
            }
            return this.context.Set<T>();
        }

        public IAsyncEnumerator<T> GetAsyncEnumerator(CancellationToken 
            cancellationToken = default)
        {
            return this.context.Set<T>()
                .GetAsyncEnumerator(cancellationToken);
        }

        public async Task<T?> GetByIdAsync(TId id, bool asNoTracking = false)
        {
            return await this.GetAllAsQueryable(asNoTracking)
                .FirstOrDefaultAsync(x => x.Id!.Equals(id));
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this.GetAllAsQueryable().GetEnumerator();
        }

        public async Task<T> UpdateAsync(T entity)
        {
            var result =  this.context.Set<T>().Update(entity);
            await this.context.SaveChangesAsync();

            return result.Entity;
        }

        public async Task UpdateRangeAsync(params T[] values)
        {
            this.context.Set<T>().UpdateRange(values);
            await this.context.SaveChangesAsync();  
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
