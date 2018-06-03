using H4M_Assurance.Domain.Entities;
using H4M_Assurance.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

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
        public Constat Get(int id)
        {
            return constatSvc.GetById((long)id);
        }

        // POST: api/Constat
        public void Post([FromBody]Constat c)
        {
            constatSvc.Add(c);
            constatSvc.Commit();
        }

        // PUT: api/Constat/5
        public void Put(string id, [FromBody]Constat c)
        {
            c.IdContratTiers = id;
            constatSvc.Update(c);
            constatSvc.Commit();
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
