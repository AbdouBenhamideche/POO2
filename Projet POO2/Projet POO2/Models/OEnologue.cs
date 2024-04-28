﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_POO2.Models
{
    public class OEnologue
    {

        [Key] public int IdOEnologue { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateDeNaissance { get; set; }
        public string Civilite { get; set; }
        public string Email { get; set; }
        public string MotDePasse { get; set; }

    }
}
