using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShippmentWebApplication.Models;
namespace ShippmentWebApplication.Controllers
{
    public class AddController : Controller
    {
        // GET: Add
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Save()
        {
            return View("~/Views/Add/Save.cshtml");
        }

        [HttpPost]
        public ActionResult SaveSender(Sender sender)
        {
            Shippment_DBEntities dbContext = new Shippment_DBEntities();

            dbContext.Senders.Add(sender);
            dbContext.SaveChanges();

            //Fetch the CustomerId returned via SCOPE IDENTITY.
            int id = sender.SenderId;

            return RedirectToAction("Index", "Sender", new { id = id });
        }
    }
}
