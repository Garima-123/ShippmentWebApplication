using ShippmentWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
namespace ShippmentWebApplication.Controllers
{
    public class SenderController : Controller
    {
        // GET: Sender

        public ActionResult Index()
        {
            Shippment_DBEntities dbContext = new Shippment_DBEntities();

            return View(from Sender in dbContext.Senders
                        select Sender);
           
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            Shippment_DBEntities dbContext = new Shippment_DBEntities();
            dbContext.Senders.Remove(dbContext.Senders.Find(id));
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}


