using NHibernateDemo.Domain.Entities;
using System.Collections.Generic;

namespace NHibernateDemo.Core.Services
{
    public interface IProductService
    {
        IList<Product> GetAll();
        Product GetById(int id);
        void Create(Product product);
        void Update(Product product);
        void Delete(int id);
    }
}
