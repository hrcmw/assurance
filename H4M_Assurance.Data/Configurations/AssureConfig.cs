using H4M_Assurance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H4M_Assurance.Data.Configurations
{
    public class AssureConfig:EntityTypeConfiguration<Assure>
    {
        public AssureConfig()
        {
            HasKey(a=>a.IdUtilisateur);
        }
    }
}
