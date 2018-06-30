using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H4M_Assurance.Domain.Entities
{
    public enum IdentifiactionAssure { A, B};
    public class Constat : Document
    {
        public string CodeConstat { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateSinistre { get; set; }

        public string LieuSinistre { get; set; }

        public bool Blesse { get; set; }

        public bool Degats { get; set; }

        public IEnumerable<NomComplet> Temoins { get; set; }

        [ForeignKey("IdContratAssure")]
        public int IdContrat { get; set; }
        public Contrat ContratAssure { get; set; }
        
        public Conducteur ConducteurAssure { get; set; }
       
        public Conducteur ConducteurTiers { get; set; }

        public string IdContratTiers { get; set; }

        public string CodeAgenceTiers { get; set; }

        public string AssuranceTiers { get; set; }

        public string AgenceTiers { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime ValableDuTiers { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime ValableAuTiers { get; set; }

        public NomComplet NomAssureTiers { get; set; }

        public Adresse AdresseAssureTiers { get; set; }

        public string TelAssureTiers { get; set; }

        public string VenantDeAssure { get; set; }

        public string AllantAAssure { get; set; }

        public string VenantDeTiers { get; set; }

        public string AllantATiers { get; set; }

        public string ObservationsAssure { get; set; }

        public string ObservationTiers { get; set; }

        public bool EstValide { get; set; }

        
        [DataType(DataType.Date)]
        public DateTime DateValidation { get; set; }

        public AgentAssureur Validateur { get; set; }

        public Expert ExpertAffecte { get; set; }

        public ICollection<Circonstance> CirconstancesA { get; set; }

        public ICollection<Circonstance> CirconstancesB { get; set; }


        public Constat()
        {
            
            this.ContratAssure = new Contrat();
            ConducteurTiers = new Conducteur();
            ConducteurAssure = new Conducteur();
        }
    }
}
