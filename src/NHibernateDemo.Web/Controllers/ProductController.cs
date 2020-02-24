using NHibernateDemo.Core.Services;
using NHibernateDemo.Domain.Entities;
using System.Web.Mvc;

namespace NHibernateDemo.Controllers
{
    public class ProductController : BaseController
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {  
            _productService = productService;
        }

        public ActionResult Index()
        {
            var products = _productService.GetAll();
            return View(products);
        }

        public ActionResult Create()
        {  
            return View();
        }

        public ActionResult Delete(int id)
        {
            var product = _productService.GetById(id);
            return View(product);
        }

        public ActionResult Edit(int id)
        {
            var product = _productService.GetById(id);
            return View(product);
        }

        [HttpPost]
        public ActionResult Add(Product product)
        {
            if (ModelState.IsValid)
            {
                _productService.Create(product);
            }

           return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Remove(int id)
        {
            if (ModelState.IsValid)
            {
                _productService.Delete(id);
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Update(Product product)
        {
            if (ModelState.IsValid)
            {
                _productService.Update(product);
            }

            return RedirectToAction("Index");
        }
    }
}