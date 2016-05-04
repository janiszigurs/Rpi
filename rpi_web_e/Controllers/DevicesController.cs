using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using rpi_web_e.Models;

namespace rpi_web_e.Controllers
{
    public class DevicesController : Controller
    {
        private rpi_web_eContext db = new rpi_web_eContext();
        private bool details_shown=true;


        [HttpGet]
        public ActionResult Index()
        {
            return View(db.Devices.ToList());
        }

        [HttpGet]
        public PartialViewResult Details(int? id)
        {
            Device device = db.Devices.Find(id);
            details_shown = true;
            return PartialView("_PartialEditDetails",device);
        }

        [HttpGet]
        public PartialViewResult Edit(int? id)
        {
            Device device = db.Devices.Find(id);
            details_shown = false;
            return PartialView("_Edit",device);
        }
        [HttpGet]
        public PartialViewResult PartialViewLogic(int? id)
        {
            Device device = db.Devices.Find(id);
            if (details_shown == true)
            {
                return PartialView("_Details", device);
            }
            else
            {
                return PartialView("_Edit", device);
            }           
        }

        [HttpPost]       
        public ActionResult Edit(Device device)
        {
            if (ModelState.IsValid)
            {
                db.Entry(device).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

        // POST: Devices/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Device device = db.Devices.Find(id);
            db.Devices.Remove(device);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
