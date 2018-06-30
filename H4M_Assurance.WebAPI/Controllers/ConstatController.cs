using H4M_Assurance.Domain.Entities;
using H4M_Assurance.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace H4M_Assurance.WebAPI.Controllers
{
    public class ConstatController : ApiController
    {

        IConstatService constatSvc = new ConstatService();
        // GET: api/Constat
        public IEnumerable<Constat> Get()
        {
            return constatSvc.GetAll();
        }

        // GET: api/Constat/5
        public IHttpActionResult Get(int id)
        {
            try
            {
                return Ok( constatSvc.GetById((long)id));
            }
            catch (Exception ex)
            {
                return NotFound();
            }

        }

        // POST: api/Constat
        [ResponseType(typeof(void))]
        public IHttpActionResult Post([FromBody]Constat c)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            constatSvc.Add(c);
            constatSvc.Commit();

            return CreatedAtRoute("DefaultApi", new { id = c.IdDocument }, c);
        }

        // PUT: api/Constat/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Put(string id, [FromBody]Constat c)
        {
            c.IdContratTiers = id;
            constatSvc.Update(c);
            constatSvc.Commit();
            return StatusCode(HttpStatusCode.NoContent);
        }

        // DELETE: api/Constat/5
        public void Delete(int id)
        {
            Constat c = new Constat();
            c = constatSvc.GetById((long)id);
            constatSvc.Delete(c);
        }
    }
}
