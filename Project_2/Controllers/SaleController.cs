using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project_2.Models;

namespace Project_2.Controllers
{
    public class SaleController : Controller
    {
        private BakeryEntities db = new BakeryEntities();

        public ActionResult Index()
        {
            return View(db.Sales.ToList());
        }

        public ActionResult Details(int? id)
        {
            var saleDetail = new List<SaleDetail>();
            saleDetail = db.SaleDetails.Where(s => s.SaleKey == id).ToList();
            return View(saleDetail);
        }

        public ActionResult Receipt(int? id)
        {
            var saleDetail = new List<SaleDetail>();
            saleDetail = db.SaleDetails.Where(s => s.SaleKey == id).ToList();
            return View(saleDetail);
        }
    }
}