using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CabManagment.Controllers
{
    public class BookingRequestsController : Controller
    {
        // GET: BookingRequests
        public ActionResult Index()
        {
            return View();
        }

        // GET: BookingRequests/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BookingRequests/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BookingRequests/Create
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

        // GET: BookingRequests/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BookingRequests/Edit/5
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

        // GET: BookingRequests/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BookingRequests/Delete/5
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
