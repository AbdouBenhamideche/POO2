using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_POO2.Models
{
    public class Performance
    {
        [Key] public int IdPerformance { get; set; }
        public float TauxReconnaissance { get; set; }
        public Performance() { }
    }
}
