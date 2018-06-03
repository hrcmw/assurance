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
    public class UtilisateurService: Service<Utilisateur>, IUtilisateurService
    {
        public static IDatabaseFactory dbf = new DatabaseFactory();
        public static IUnitOfWork ut = new UnitOfWork(dbf);

        public UtilisateurService():base(ut)
        {
                
        }
    }
}
