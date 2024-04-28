using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_POO2.Models
{
    public class VinBlanc
    {
        //exemple pour les types de vin
        public float Concentration { get; set; }
        public float IntensitéArômes { get; set; }
        [Key] public int IdVinBlanc { get; set; }
        public double Alcohol { get; set; }
        public double Sulphates { get; set; }
        public double CitricAcid { get; set; }
        public double VolatileAcidity { get; set; }
        public int Quality { get; set; }
        public Qualite Qualite { get; set; }
    }
}
