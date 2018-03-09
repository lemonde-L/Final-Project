using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project_2.Models;

namespace Project_2.Controllers
{
    public class ProductController : Controller
    {
        private BakeryEntities db = new BakeryEntities();
        // GET: Products
        public ActionResult Index()
        {
            return View(db.Products.ToList());
        }
    }
}