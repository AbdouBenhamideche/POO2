using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_POO2.Models
{
    public class Qualite
    {
        [Key] public int IdQualite { get; set; }
        public int Valeur { get; set; }

        public ICollection<Vin> Vins;
        public Qualite()
        {
            Vins = new List<Vin>();
        }
    }
}
