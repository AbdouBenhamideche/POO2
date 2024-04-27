using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_POO2.Models
{
    public class ListVin
    {
        public static List<Vin> VinList = new List<Vin>(); // Modifier ici

        public static void AddToList(Vin vin)
        {
            VinList.Add(vin);
        }
    }
}
