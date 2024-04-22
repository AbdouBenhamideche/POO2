using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_POO2.Models
{
    public class ListEntite
    {
        public static List<Entite> entiteList = new List<Entite>(); // Modifier ici

        public static void AddToList(Entite entite)
        {
            entiteList.Add(entite);
        }
    }
}
