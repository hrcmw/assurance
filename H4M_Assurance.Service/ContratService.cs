using H4M_Assurance.Data.Infrastructure;
using H4M_Assurance.Domain.Entities;
using Service.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H4M_Assurance.Service
{
    public class ContratService : Service<Contrat>, IContratService
    {
        private static IDatabaseFactory dbf = new DatabaseFactory();
        private static IUnitOfWork ut = new UnitOfWork(dbf);

        public ContratService() : base(ut)
        {

        }


        public Contrat getContrat(string idContrat)
        {
            return ut.getRepository<Contrat>().Get(c => c.IdContrat == idContrat);
        }
    }
}
