using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H4M_Assurance.Domain.Entities
{
    public class Piece
    {
        [Key]
        public int IdPiece { get; set; }

        public string Designation { get; set; }

        public string Reference { get; set; }

        public string Description { get; set; }

        public ICollection<DetailOP> OffresPrix { get; set; }

        public ICollection<DetailFR> FacturesReparation { get; set; }

        public ICollection<DetailDiag> Diagnostiques { get; set; }
    }
}
