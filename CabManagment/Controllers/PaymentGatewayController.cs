using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CabManagment.Controllers
{
    public class PaymentGatewayController : Controller
    {
        // GET: PaymentGateway
        public ActionResult Index()
        {
            return View();
        }

        // GET: PaymentGateway/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PaymentGateway/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PaymentGateway/Create
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

        // GET: PaymentGateway/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PaymentGateway/Edit/5
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

        // GET: PaymentGateway/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PaymentGateway/Delete/5
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
