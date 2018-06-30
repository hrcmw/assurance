using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace H4M_Assurance.Domain.Entities
{
    public class Circonstance
    {
        [Key]
        [Column(Order = 0)]
        public int CirconstanceId { get; set; }

        [Key]
        [Column(Order = 1)]
        public int CirconstanceConstatId { get; set; }

        [Key]
        [Column(Order = 2)]
        public int IdDocument { get; set; }

        public virtual CirconstanceConstat CirconstanceConstat { get; set; }

        public virtual Constat Constat { get; set; }

        public bool EstCochee { get; set; }      

        
    }
}