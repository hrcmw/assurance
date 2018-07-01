using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H4M_Assurance.Domain.Entities
{
    public class CirconstanceConstat
    {
        public int CirconstanceConstatId { get; set; }

        public string LibelleCircontanceConstat { get; set; }

        public int RangCirconstanceConstat { get; set; }

        public int GraviteCirconstanceConstat { get; set; }

        public ICollection<Constat> Constats { get; set; }

    }
}
