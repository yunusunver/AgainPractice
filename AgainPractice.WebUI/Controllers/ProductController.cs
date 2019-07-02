using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AgainPractice.Business.Abstract;
using AgainPractice.WebUI.Models;

namespace AgainPractice.WebUI.Controllers
{
    public class ProductController : Controller
    {
        private IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }


        // GET: Product
        public ActionResult Index()
        {

            ProductViewModel model= new ProductViewModel
            {
                Products = _productService.GetAll()
            };

            return View(model);
        }
    }
}