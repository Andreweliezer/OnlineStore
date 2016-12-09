using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineStore.Domain.Abstract;

namespace OnlineStore.WebUI.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository repository;
        public int pageSize=4;
        
        public ProductController(IProductRepository repo)
        {
            repository = repo; //comment
        }

        public ActionResult List(int page=2)
        {
            return View(repository.Products
                .OrderBy(p=>p.productId)
                .Skip((page-1)*pageSize)
                .Take(pageSize));
        }
    }
}