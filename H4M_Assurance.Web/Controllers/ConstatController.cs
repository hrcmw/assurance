using H4M_Assurance.Domain.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace H4M_Assurance.Web.Controllers
{
    public class ConstatController : Controller
    {
        HttpClient Client;
        string BaseUrl = @"http://localhost:30326/";

        public ConstatController()
        {
            Client = new HttpClient();
            Client.BaseAddress = new Uri(BaseUrl);
            Client.DefaultRequestHeaders.Accept.Clear();
            Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
        // GET: Constat
        public ActionResult Index()
        {
            List<Constat> constats = new List<Constat>();
            Constat constat = new Constat();            
            HttpResponseMessage response = Client.GetAsync("api/Constat").Result;
            if (response.IsSuccessStatusCode)
            {
                var ConstatResponse = response.Content.ReadAsStringAsync().Result;
                constats = JsonConvert.DeserializeObject<List<Constat>>(ConstatResponse);
                constat = constats.Count>0? constats.First():null;
            }

            ViewBag.Piece = constat;
            
            return View(constats);
        }

        //// GET: Constat/Details/5
        //public ActionResult Details(int id)
        //{
        //    Constat constat = new Constat();
        //    Client = new HttpClient();
        //    Client.BaseAddress = new Uri(BaseUrl);
        //    Client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        //    HttpResponseMessage response = Client.GetAsync("api/Constat/"+id).Result;
        //    if (response.IsSuccessStatusCode)
        //    {
        //        var ConstatResponse = response.Content.ReadAsStringAsync().Result;
        //        constat = JsonConvert.DeserializeObject<Constat>(ConstatResponse);
                
        //    }
           
        //    return View(constat);
        //}

        // GET: Constat/Create
        public ActionResult Create()
        {
            Constat constat = new Constat()
            {
                ConducteurAssure = new Conducteur(),
                ConducteurTiers=new Conducteur()
                
                
            };
            return View(constat);
        }

        // POST: Constat/Create
        [HttpPost]
        public async Task<ActionResult> Create(Constat constat)
        {            
            HttpResponseMessage responseMessage = Client.PostAsJsonAsync("api/Constat", constat).Result;
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return RedirectToAction("Error");
        }

        // GET: Constat/Edit/5
       

        public async Task<ActionResult> Details(int id)
        {
            HttpResponseMessage responseMessage = await Client.GetAsync("api/Constat/" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                var responseData = responseMessage.Content.ReadAsStringAsync().Result;

                var Constat = JsonConvert.DeserializeObject<Constat>(responseData);

                return View(Constat);
            }
            return View("Error");
        }

        public async Task<ActionResult> Edit(int id)
        {
            HttpResponseMessage responseMessage = await Client.GetAsync("api/Constat/" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                var responseData = responseMessage.Content.ReadAsStringAsync().Result;

                var Constat = JsonConvert.DeserializeObject<Constat>(responseData);

                return View(Constat);
            }
            return View("Error");
        }

        [HttpPost]
        public async Task<ActionResult> Edit(int id, Constat constat)
        {
            HttpResponseMessage responseMessage = Client.PutAsJsonAsync("api/Constat/" + id, constat).Result;
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return RedirectToAction("Error");
        }

        public async Task<ActionResult> Delete(int id)
        {
            HttpResponseMessage responseMessage = await Client.GetAsync("api/Constat/" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                var responseData = responseMessage.Content.ReadAsStringAsync().Result;

                var Constat = JsonConvert.DeserializeObject<Constat>(responseData);

                return View(Constat);
            }
            return View("Error");
        }

        //The DELETE method
        [HttpPost]
        public async Task<ActionResult> Delete(int id, Constat Constat)
        {

            HttpResponseMessage responseMessage = await Client.DeleteAsync("api/Constat/" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return RedirectToAction("Error");
        }
    }
}
