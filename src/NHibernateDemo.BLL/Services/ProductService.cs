using NHibernateDemo.Core.Services;
using NHibernateDemo.Domain.Entities;
using NHibernateDemo.Domain.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace NHibernateDemo.BLL.Services
{
    public class ProductService : IProductService
    {
        private IRepository<Product> _productRepository;

        public ProductService(IRepository<Product> productRepository)
        {
            _productRepository = productRepository;
        }

        public IList<Product> GetAll()
        {
            return _productRepository
                .GetAll()
                .ToList();
        }

        public Product GetById(int id)
        {
            return _productRepository.GetById(id);
        }

        public void Create(Product product)
        {
            _productRepository.Create(product);
        }

        public void Update(Product product)
        {
            _productRepository.Update(product);
        }

        public void Delete(int id)
        {
            _productRepository.Delete(id);
        }

    }
}
