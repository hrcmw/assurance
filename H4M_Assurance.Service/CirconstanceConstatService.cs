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
    public class CirconstanceConstatService : Service<CirconstanceConstat>, ICirconstanceConstat
    {
        private static IDatabaseFactory dbf = new DatabaseFactory();
        private static IUnitOfWork ut = new UnitOfWork(dbf);
        public CirconstanceConstatService():base(ut)
        {

        }
    }
}
