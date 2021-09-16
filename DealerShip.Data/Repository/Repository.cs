using DealerShip.Data.Context;
using DealerShip.Domain.Interfaces;
using DealerShip.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DealerShip.Data.Repository
{
    public abstract class Repository<T> : IRepository<T> where T : Entity, new()
    {
        protected readonly SqlContext _sqlContext;
        protected readonly DbSet<T> _dbSet;
        public Repository(SqlContext sqlContext)
        {
            _sqlContext = sqlContext;
            _dbSet = sqlContext.Set<T>();
        }
        public async Task Cadastrar(T entity)
        {
            _dbSet.Add(entity);
            await SaveChanges();
        }

        public async Task Delete(int id)
        {
            _dbSet.Remove(new T { Id = id});
            await SaveChanges();
        }

        public async Task<List<T>> FindAll()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<T> FindById(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<int> SaveChanges()
        {
            return await _sqlContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> Search(Expression<Func<T, bool>> predicate)
        {
            return await _dbSet.AsNoTracking().Where(predicate).ToListAsync();
        }

        public async Task Update(T entity)
        {
            _dbSet.Update(entity);
            await SaveChanges();
        }
        public void Dispose()
        {
            _sqlContext?.Dispose();
        }
    }
}
