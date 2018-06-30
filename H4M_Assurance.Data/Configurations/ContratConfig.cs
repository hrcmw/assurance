using H4M_Assurance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H4M_Assurance.Data.Configurations
{
    public class ContratConfig:EntityTypeConfiguration<Contrat>
    {
        public ContratConfig()
        {
            HasKey(c => c.IdContrat);
            HasRequired(c => c.Assure)   
                .WithMany(a => a.Contrats)
                .HasForeignKey(c => c.AssureId)
                .WillCascadeOnDelete(false);

            HasRequired(c => c.Vehicule)
                .WithMany(v => v.Contrats)
                .HasForeignKey(c => c.IdVehicule)
                .WillCascadeOnDelete(false);

            HasRequired(c => c.Usercreat)
                .WithMany(u => u.Contrats)
                .HasForeignKey(c => c.IdUserCreat)
                .WillCascadeOnDelete(false);

            HasRequired(c => c.UserModif)
                .WithMany(u => u.Contrats)
                .HasForeignKey(c => c.IdUserModif)
                .WillCascadeOnDelete(false);
        }
    }
}
