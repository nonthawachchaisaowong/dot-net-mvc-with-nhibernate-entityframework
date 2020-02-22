using NHibernate;
using NHibernate.Linq;
using NHibernateDemo.Domain.Entities;
using NHibernateDemo.Domain.Repositories;

using System.Collections.Generic;
using System.Linq;

namespace NHibernateDemo.DAL.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ISession _session;

        public ProductRepository()
        {
            _session = SessionFactory.GetCurrentSession();
        }
        public void Add(Product product)
        {
            SessionFactory.GetCurrentSession().Save(product);
        }

        public Product Get(int id)
        {
            return SessionFactory.GetCurrentSession().Get<Product>(id);
        }

        public void Remove(Product product)
        {
            SessionFactory.GetCurrentSession().Delete(product);
        }

        public IEnumerable<Product> GetAll()
        {
            return _session.Query<Product>();
        }

        public IEnumerable<Product> GetAllProductsByCategoryQuery(int categoryId)
        {
            var products = _session.Query<Product>();
            var productsByCategory = from c in products
                                     where c.Id == categoryId
                                     select c;
            return productsByCategory;
        }

        public IEnumerable<Category> GetAllCategoriesQuery()
        {
            return _session.Query<Category>();
        }
    }
}
