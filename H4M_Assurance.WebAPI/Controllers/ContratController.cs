using H4M_Assurance.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace H4M_Assurance.WebAPI.Controllers
{
    public class ContratController : ApiController
    {
        IContratService svcContrat = new ContratService();
        // GET: api/Contrat
        public IHttpActionResult Get()
        {
            //var contrats=new 

            return Ok( svcContrat.GetAll() );
        }

        [Route("api/Contrat/{idContrat}")]
        // GET: api/Contrat/5
        public IHttpActionResult Get(string idContrat)
        {
            return Ok( svcContrat.getContrat(idContrat) );
        }

        // POST: api/Contrat
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Contrat/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Contrat/5
        public void Delete(int id)
        {
        }
    }
}
