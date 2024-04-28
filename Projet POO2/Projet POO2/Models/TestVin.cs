using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_POO2.Models
{
    public class TestVin
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        public int IdTestVin { get; set; }
        [ForeignKey("IdTest")] public Test Test { get; set; }
        [ForeignKey("IdVin")] public Vin Vin { get; set; }
    }
}
