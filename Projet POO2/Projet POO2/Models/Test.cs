﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projet_POO2.Models
{
    public class Test
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        public int IdTest { get; set; }
        public string Nom { get; set; } = "test";
        public string Description { get; set; }
        public ICollection<TestVin> TestVins { get; set; }
        public Test()
        {

        }
    }

}
