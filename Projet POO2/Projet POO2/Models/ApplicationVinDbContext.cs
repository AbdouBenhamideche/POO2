using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_POO2.Models
{
    public class ApplicationVinDbContext
    {
        public DbSet<Models.Client> Clients { get; set; }
        public DbSet<Models.OEnologue> OEnologues { get; set; }
        public DbSet<Models.Performance> Performances { get; set; }
        public DbSet<Models.ProprietaireVignoble> ProprietaireVignobles { get; set; }
        public DbSet<Models.Qualite> Qualites { get; set; }
        public DbSet<TestVin> TestVins { get; set; }
        public DbSet<Models.Terrain> Terrains { get; set; }
        public DbSet<Models.Test> Tests { get; set; }
        public DbSet<Models.Utilisateur> Utilisateurs { get; set; }
        public DbSet<Models.Vignoble> Vignobles { get; set; }
        public DbSet<Models.Vin> Vins { get; set; }
        public DbSet<Models.VinBlanc> VinBlancs { get; set; }
        public DbSet<Models.VinMousseux> VinMousseuxes { get; set; }
        public DbSet<Models.VinRose> VinRoses { get; set; }
        public DbSet<Models.VinRouge> VinRouges { get; set; }
    }
}
