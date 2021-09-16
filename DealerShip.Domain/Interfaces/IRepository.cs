using DealerShip.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DealerShip.Domain.Interfaces
{
    public interface IRepository<T>: IDisposable where T : Entity
    {
        Task Cadastrar(T entity);
        Task<T> FindById(int id);
        Task<List<T>> FindAll();
        Task Update(T entity);
        Task Delete(int id);
        Task<IEnumerable<T>> Search(Expression<Func<T, bool>> predicate);
        Task<int> SaveChanges();

    }
}
