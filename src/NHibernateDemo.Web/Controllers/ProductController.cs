using NHibernateDemo.Core.Services;
using NHibernateDemo.Domain.Entities;
using System.Web.Mvc;

namespace NHibernateDemo.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public ActionResult List()
        {
            var products = _productService.GetAllProducts();
            return View(products);
        }

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Product product)
        {
            if (ModelState.IsValid)
            {
                _productService.AddProduct(product);
            }
            return View();
        }
    }
}