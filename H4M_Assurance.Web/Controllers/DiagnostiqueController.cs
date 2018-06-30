using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace H4M_Assurance.Web.Controllers
{
    public class DiagnostiqueController : Controller
    {

        // GET: Diagnostique
        public ActionResult Index()
        {
            return View();
        }

        // GET: Diagnostique/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Diagnostique/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Diagnostique/Create
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

        // GET: Diagnostique/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Diagnostique/Edit/5
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

        // GET: Diagnostique/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Diagnostique/Delete/5
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
