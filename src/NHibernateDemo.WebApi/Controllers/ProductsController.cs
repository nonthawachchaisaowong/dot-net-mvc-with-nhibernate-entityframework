﻿using NHibernateDemo.Domain.Entities;
using NHibernateDemo.Domain.Services;

using System.Linq;
using System.Web.Http;

namespace NHibernateDemo.WebApi.Controllers
{
    [RoutePrefix("products")]
    public class ProductsController : ApiController
    {
        private IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public IHttpActionResult GetProducts()
        {
            // ensure there are products for the example
            if (!_productService.GetAll().Any())
            {
                _productService.Create(new Product { Name = "Product 1" });
                _productService.Create(new Product { Name = "Product 2" });
                _productService.Create(new Product { Name = "Product 3" });
            }

            return Ok(_productService.GetAll());
        }
    }
}