using ShippmentWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShippmentWebApplication.Controllers
{
    public class SenderController : Controller
    {
        // GET: Sender
        
        public ActionResult Index()
        {
            Shippment_DBEntities dbContext = new Shippment_DBEntities();
            List<Sender> Senderlist = new List<Sender>();
            return View(Senderlist);
        }
        [HttpPost]
        public ActionResult Index(Sender sender)
        {
            using (Shippment_DBEntities objSenderDbContext = new Shippment_DBEntities())
            {
                objSenderDbContext.Senders.Add(sender);
                objSenderDbContext.SaveChanges();
                Int64 id = sender.SenderId;
            }
            return View(sender);
        }

        [HttpPost]
        public ActionResult Save(Sender sender)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("AddSender", "Sender");
            }
            Shippment_DBEntities dbContext = new Shippment_DBEntities();
            if (sender.SenderId == 0)
                dbContext.Senders.Add(sender);

            else
            {
                var senderdb = dbContext.Senders.FirstOrDefault(x => x.SenderId == sender.SenderId);
                senderdb.SenderName = sender.SenderName;
                senderdb.Description = sender.Description;
                senderdb.Expedited = sender.Expedited;
                senderdb.RecipientAddress = sender.RecipientAddress;
                senderdb.Shipment = sender.Shipment;
              
            }

            dbContext.SaveChanges();
            return RedirectToAction("Index", "Sender");
        }

    }
}
        //[Route("delete")]
        //[HttpGet]
        //public ActionResult Delete()
        //{
        //    return View("Delete");
        //}

        //[Route("delete")]
        //[HttpPost]
        //public ActionResult Delete(int id)
        //{
        //    Shippment_DBEntities dbContext = new Shippment_DBEntities();
        //    dbContext.Senders.Remove(dbContext.Senders.Find(id));
        //    dbContext.SaveChanges();
        //    return RedirectToAction("Index");
        //}
    
