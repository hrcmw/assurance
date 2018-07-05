using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Description;


namespace H4M_Assurance.Domain.Entities
{
    public enum TypeMotorisation { Essence, Diesel };

    [DataContract(IsReference = true)]
    [JsonObject(IsReference = false)]
    public class Vehicule
    {
        [Key]
        public int IdVehicule { set; get; }

        public string Matricule { get; set; }

        public string NumChassie { get; set; }

        public DateTime DateFabrication { get; set; }

        public DateTime DateCirculation { get; set; }

        public Assure Proprietaire { get; set; }

        public string Marque { get; set; }

        public string Gamme { get; set; }

        public string PuissanceFiscale { get; set; }

        public TypeMotorisation Motorisation { get; set; }
        
        public ICollection<Contrat> Contrats { get; set; }

    }
}
