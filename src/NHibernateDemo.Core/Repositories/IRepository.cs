using NHibernateDemo.Domain.Entities;
using System.Linq;

namespace NHibernateDemo.Domain.Repositories
{
    public interface IRepository<T> where T : IEntity
    {
        IQueryable<T> GetAll();
        T GetById(int id);
        void Create(T entity);
        void Update(T entity);
        void Delete(int id);
    }
}
