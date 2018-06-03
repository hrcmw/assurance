using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace H4M_Assurance.Web.Controllers
{
    public class PieceController : Controller
    {
        // GET: Piece
        public ActionResult Index()
        {
            return View();
        }

        // GET: Piece/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Piece/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Piece/Create
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

        // GET: Piece/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Piece/Edit/5
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

        // GET: Piece/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Piece/Delete/5
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
