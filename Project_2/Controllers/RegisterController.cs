using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project_2.Models;

namespace Project_2.Controllers
{
    public class RegisterController : Controller
    {
        private BakeryEntities db = new BakeryEntities();

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(
            [Bind(Include = "LastName, FirstName, Email, Phone, Password")]NewCustomer nc)
        {
            Message m = new Message();
            m.MessageText = "Thank you for Signning Up";
            return View("RegisterResult", m);
        }
    }
}