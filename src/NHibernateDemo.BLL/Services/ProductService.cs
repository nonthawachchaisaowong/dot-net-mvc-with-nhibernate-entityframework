using NHibernateDemo.Core.Services;
using NHibernateDemo.Domain.Entities;
using NHibernateDemo.Domain.Repositories;
using System.Collections.Generic;

namespace NHibernateDemo.BLL.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productService)
        {
            _productRepository = productService;
        }

        public void AddProduct(Product product)
        {
            _productRepository.Add(product);
        }

        public void RemoveProduct(Product productId)
        {
            _productRepository.Remove(productId);
        }

        public Product GetProduct(int productId)
        {
            var product = new Product { Id = productId };
            return product;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            var products = _productRepository.GetAll();
            return products;
        }

        public IEnumerable<Product> GetAllProductsByCategory(int categoryId)
        {
            var products = _productRepository.GetAllProductsByCategoryQuery(categoryId);
            return products;
        }

        public IEnumerable<Category> GetAllCategory()
        {
            var categories = _productRepository.GetAllCategoriesQuery();
            return categories;
        }
    }
}
