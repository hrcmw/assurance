using H4M_Assurance.Domain.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace H4M_Assurance.Web.Controllers
{
    public class PieceController : Controller
    {
        HttpClient Client = new HttpClient();
        string BaseUrl=@"http://localhost:30326/";
        // GET: Piece
        public ActionResult Index()
        {
            List<Piece> Pieces = new List<Piece>();
            Piece piece = new Piece();
            Client = new HttpClient();
            Client.BaseAddress = new Uri(BaseUrl);
            Client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = Client.GetAsync("api/Piece").Result;
            if (response.IsSuccessStatusCode)
            {
                var PieceResponse =response.Content.ReadAsStringAsync().Result;
                Pieces = JsonConvert.DeserializeObject<List<Piece>>(PieceResponse);
                piece = Pieces.First();
            }

            ViewBag.Piece = piece;
            //retourner la liste des produits de la vue
            return View(Pieces);

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
