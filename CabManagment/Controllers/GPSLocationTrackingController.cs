using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CabManagment.Controllers
{
    public class GPSLocationTrackingController : Controller
    {
        // GET: GPSLocationTracking
        public ActionResult Index()
        {
            return View();
        }

        // GET: GPSLocationTracking/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: GPSLocationTracking/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GPSLocationTracking/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: GPSLocationTracking/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: GPSLocationTracking/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: GPSLocationTracking/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: GPSLocationTracking/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
