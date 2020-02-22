using NHibernateDemo.Domain.Entities;

using System.Collections.Generic;

namespace NHibernateDemo.Domain.Repositories
{
    public interface IProductRepository
    {
        void Add(Product product);
        Product Get(int id);
        void Remove(Product product);
        IEnumerable<Product> GetAll();
        IEnumerable<Product> GetAllProductsByCategoryQuery(int categoryId);
        IEnumerable<Category> GetAllCategoriesQuery();
    }
}
