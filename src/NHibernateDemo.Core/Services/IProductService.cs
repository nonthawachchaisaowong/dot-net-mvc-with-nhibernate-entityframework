using NHibernateDemo.Domain.Entities;
using System.Collections.Generic;

namespace NHibernateDemo.Core.Services
{
    public interface IProductService
    {
        void AddProduct(Product product);
        void RemoveProduct(Product productId);
        Product GetProduct(int productId);
        IEnumerable<Product> GetAllProducts();
        IEnumerable<Product> GetAllProductsByCategory(int categoryId);
        IEnumerable<Category> GetAllCategory();
    }
}
