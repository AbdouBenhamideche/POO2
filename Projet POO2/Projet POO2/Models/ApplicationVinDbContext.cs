using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_POO2.Models
{
    public class ApplicationVinDbContext : DbContext
    
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


        protected override void OnConfiguring(DbContextOptionsBuilder dbContextoptionsBuilder)
        {
            string connection_string = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            string database_name = "ApplicationVinDb";
            dbContextoptionsBuilder.UseSqlServer($"{connection_string}; Database={database_name};");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.Qualite>().HasData(
                 new Models.Qualite() { IdQualite = 1, Valeur = 3 },
                 new Models.Qualite() { IdQualite = 2, Valeur = 6 },
                 new Models.Qualite() { IdQualite = 3, Valeur = 9 }
                );

        }






        public static void AddClient(Models.Client client)
        {
            ApplicationVinDbContext context = new ApplicationVinDbContext();
            context.Clients.Add(client);
            context.SaveChanges();
        }
        public static void DeleteClient(int idClient)
        {
            ApplicationVinDbContext context = new ApplicationVinDbContext();
            Models.Client client = context.Clients.Find(idClient);

            if (client != null)
            {
                context.Clients.Remove(client);
                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("Le client avec l'identifiant spécifié n'existe pas.");
            }
        }
        public static void AddProprietaireVignoble(Models.ProprietaireVignoble proprietaire)
        {
            ApplicationVinDbContext context = new ApplicationVinDbContext();
            context.ProprietaireVignobles.Add(proprietaire);
            context.SaveChanges();
        }
        public static void DeleteProprietaireVignoble(int idProprietaire)
        {
            ApplicationVinDbContext context = new ApplicationVinDbContext();
            Models.ProprietaireVignoble proprietaire = context.ProprietaireVignobles.Find(idProprietaire);

            if (proprietaire != null)
            {
                context.ProprietaireVignobles.Remove(proprietaire);
                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("Le client avec l'identifiant spécifié n'existe pas.");
            }
        }
        public static void AddUser(Models.Utilisateur utilisateur)
        {
            ApplicationVinDbContext context = new ApplicationVinDbContext();
            context.Utilisateurs.Add(utilisateur);
            context.SaveChanges();
        }

        public static List<Models.Utilisateur> ShowUsers()
        {
            ApplicationVinDbContext context = new ApplicationVinDbContext();
            List<Models.Utilisateur> utilisateurs = context.Utilisateurs.ToList();
            return utilisateurs;

        }

        public static void ShowUser(int idUtilisateur)
        {
            ApplicationVinDbContext context = new ApplicationVinDbContext();
            Models.Utilisateur utilisateur = context.Utilisateurs.Find(idUtilisateur);

        }
        public static bool AuthenticateUser(string email, string motDePasse)
        {
            ApplicationVinDbContext context = new ApplicationVinDbContext();

            // Recherche de l'utilisateur par email
            Models.Utilisateur utilisateur = context.Utilisateurs.FirstOrDefault(u => u.Email == email);

            if (utilisateur != null)
            {
                // Vérification du mot de passe
                if (utilisateur.MotDePasse == motDePasse)
                {
                    // Authentification réussie
                    return true;
                }
            }

            // Utilisateur non trouvé ou mot de passe incorrect
            return false;
        }

        public static void UpdateUser(int identifiant, string nom, string prenom, string dateDeNaissance, string civilite, string email, string motDePasse)
        {
            ApplicationVinDbContext context = new ApplicationVinDbContext();
            Models.Utilisateur utilisateur = context.Utilisateurs.Find(identifiant);

            if (utilisateur != null)
            {
                utilisateur.Nom = nom;
                utilisateur.Prenom = prenom;
                utilisateur.DateDeNaissance = dateDeNaissance;
                utilisateur.Civilite = civilite;
                utilisateur.Email = email;
                utilisateur.MotDePasse = motDePasse;
                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("L'utilisateur avec l'identifiant spécifié n'existe pas.");
            }
        }
        public static void DeleteUser(int idUtilisateur)
        {
            ApplicationVinDbContext context = new ApplicationVinDbContext();
            Models.Utilisateur utilisateur = context.Utilisateurs.Find(idUtilisateur);

            if (utilisateur != null)
            {
                context.Utilisateurs.Remove(utilisateur);
                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("L'utilisateur avec l'identifiant spécifié n'existe pas.");
            }
        }
        public static bool UserExistsWithEmail(string email)
        {
            using (var context = new ApplicationVinDbContext())
            {
                return context.Utilisateurs.Any(u => u.Email == email);
            }
        }



        public static void AddQualite(Models.Qualite qualite)
        {
            ApplicationVinDbContext context = new ApplicationVinDbContext();
            context.Qualites.Add(qualite);
            context.SaveChanges();

        }
        public static void DeleteQualite(int idQualite)
        {
            ApplicationVinDbContext context = new ApplicationVinDbContext();
            Models.Qualite qualite = context.Qualites.Find(idQualite);
            context.Qualites.Remove(qualite);
            context.SaveChanges();
        }

        public static void AddVin(Models.Vin vin)
        {
            ApplicationVinDbContext context = new ApplicationVinDbContext();
            context.Vins.Add(vin);
            context.SaveChanges();
        }
        public static void UpdateVin(int idVin, float alcohol, float sulphates, float citricAcid, float volatileAcidity, int quality)
        {
            ApplicationVinDbContext context = new ApplicationVinDbContext();
            Models.Vin vin = context.Vins.Find(idVin);

            if (vin != null)
            {
                vin.Alcohol = alcohol;
                vin.Sulphates = sulphates;
                vin.CitricAcid = citricAcid;
                vin.VolatileAcidity = volatileAcidity;
                vin.Qualite = quality;

                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("Le vin avec l'identifiant spécifié n'existe pas.");
            }
        }
        public static void DeleteVin(int idVin)
        {
            ApplicationVinDbContext context = new ApplicationVinDbContext();
            Models.Vin vin = context.Vins.Find(idVin);
            context.Vins.Remove(vin);
            context.SaveChanges();
        }
        public static void AddTerrain(Models.Terrain terrain)
        {
            ApplicationVinDbContext context = new ApplicationVinDbContext();
            context.Terrains.Add(terrain);
            context.SaveChanges();
        }
        public static void UpdateTerrain(int idTerrain, float surface, string emplacement)
        {
            ApplicationVinDbContext context = new ApplicationVinDbContext();
            Models.Terrain terrain = context.Terrains.Find(idTerrain);

            if (terrain != null)
            {
                terrain.Surface = surface;
                terrain.Emplacement = emplacement;
                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("Le terrain avec l'identifiant spécifié n'existe pas.");
            }
        }
        public static void DeleteTerrain(int idTerrain)
        {
            ApplicationVinDbContext context = new ApplicationVinDbContext();
            Models.Terrain terrain = context.Terrains.Find(idTerrain);

            if (terrain != null)
            {
                context.Terrains.Remove(terrain);
                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("Le terrain avec l'identifiant spécifié n'existe pas.");
            }
        }
        public static void AddVignoble(Models.Vignoble vignoble)
        {
            ApplicationVinDbContext context = new ApplicationVinDbContext();
            context.Vignobles.Add(vignoble);
            context.SaveChanges();
        }

        public static void UpdateVignoble(int idVignoble, float surface, string emplacement, int idProprietaireVignoble, int idTerrain)
        {
            ApplicationVinDbContext context = new ApplicationVinDbContext();
            Models.Vignoble vignoble = context.Vignobles.Find(idVignoble);

            if (vignoble != null)
            {
                vignoble.Surface = surface;
                vignoble.Emplacement = emplacement;
                vignoble.IdProprietaireVignoble = idProprietaireVignoble;
                vignoble.IdTerrain = idTerrain;

                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("Le vignoble avec l'identifiant spécifié n'existe pas.");
            }
        }

        public static void DeleteVignoble(int idVignoble)
        {
            ApplicationVinDbContext context = new ApplicationVinDbContext();
            Models.Vignoble vignoble = context.Vignobles.Find(idVignoble);

            if (vignoble != null)
            {
                context.Vignobles.Remove(vignoble);
                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("Le vignoble avec l'identifiant spécifié n'existe pas.");
            }
        }
        public static void AddTest(Models.Test test)
        {
            ApplicationVinDbContext context = new ApplicationVinDbContext();
            context.Tests.Add(test);
            context.SaveChanges();
        }

        public static void UpdateTest(int idTest, string nom, string description)
        {
            ApplicationVinDbContext context = new ApplicationVinDbContext();
            Models.Test test = context.Tests.Find(idTest);

            if (test != null)
            {
                test.Nom = nom;
                test.Description = description;
                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("Le test avec l'identifiant spécifié n'existe pas.");
            }
        }
        public static void DeleteTest(int idTest)
        {
            ApplicationVinDbContext context = new ApplicationVinDbContext();
            Models.Test test = context.Tests.Find(idTest);

            if (test != null)
            {
                context.Tests.Remove(test);
                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("Le test avec l'identifiant spécifié n'existe pas.");
            }
        }
        public static void AddTestToVin(int idVin, Models.Test test)
        {
            ApplicationVinDbContext context = new ApplicationVinDbContext();
            Models.Vin vin = context.Vins.Include(v => v.Tests).Where(v => v.IdVin == idVin).First();
            vin.Tests.Add(test);
            context.SaveChanges();

        }
        public static void DeleteTestFromVin(int idVin, int idTest)
        {
            ApplicationVinDbContext context = new ApplicationVinDbContext();

            Models.Vin vin = context.Vins.Include(v => v.Tests).FirstOrDefault(v => v.IdVin == idVin);

            if (vin != null)
            {
                Models.Test test = vin.Tests.FirstOrDefault(t => t.IdTest == idTest);

                if (test != null)
                {
                    vin.Tests.Remove(test);
                    context.SaveChanges();
                }
                else
                {
                    Console.WriteLine("Le test avec l'identifiant spécifié n'est pas associé à ce vin.");
                }
            }
            else
            {
                Console.WriteLine("Le vin avec l'identifiant spécifié n'existe pas.");
            }
        }
        public static void ShowTestsOfVin(int idVin)
        {
            ApplicationVinDbContext context = new ApplicationVinDbContext();

            List<TestVin> testsVin = context.TestVins
                .Include(tv => tv.Test)
                .Include(tv => tv.Vin)
                .Where(tv => tv.Vin.IdVin == idVin)
                .ToList();

            if (testsVin.Any())
            {
                Console.WriteLine($"Tests associés au vin avec l'identifiant {idVin}:");
                foreach (TestVin testVin in testsVin)
                {
                    Console.WriteLine($" - Test ID: {testVin.Test.IdTest}, Nom: {testVin.Test.Nom}, Description: {testVin.Test.Description}");
                    Console.WriteLine($"   Vin associé - ID: {testVin.Vin.IdVin}, Alcohol: {testVin.Vin.Alcohol}, Citric Acid: {testVin.Vin.CitricAcid}, Sulphates: {testVin.Vin.Sulphates}, Volatile Acidity: {testVin.Vin.VolatileAcidity}, Quality: {testVin.Vin.Quality}");
                }
            }
            else
            {
                Console.WriteLine("Aucun test associé à ce vin.");
            }
        }



        public static void AddVignobleToProprietaire(int idProprietaire, Models.Vignoble vignoble)
        {
            ApplicationVinDbContext context = new ApplicationVinDbContext();
            Models.ProprietaireVignoble proprietaire = context.ProprietaireVignobles.Find(idProprietaire);
            if (proprietaire != null)
            {
                proprietaire.Vignobles.Add(vignoble);
                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("Le propriétaire avec l'identifiant spécifié n'existe pas.");
            }
        }

        public static void DeleteVignobleFromProprietaire(int idVignoble, int idProprietaire)
        {
            ApplicationVinDbContext context = new ApplicationVinDbContext();
            Models.ProprietaireVignoble proprietaire = context.ProprietaireVignobles.Find(idProprietaire);
            if (proprietaire != null)
            {
                Models.Vignoble vignoble = proprietaire.Vignobles.FirstOrDefault(v => v.IdVignoble == idVignoble);
                if (vignoble != null)
                {
                    proprietaire.Vignobles.Remove(vignoble);
                    context.SaveChanges();
                }
                else
                {
                    Console.WriteLine("Le vignoble avec l'identifiant spécifié n'est pas associé à ce propriétaire.");
                }
            }
            else
            {
                Console.WriteLine("Le propriétaire avec l'identifiant spécifié n'existe pas.");
            }
        }

        public static void ShowVignoblesOfProprietaire(int idProprietaireVignoble)
        {
            ApplicationVinDbContext context = new ApplicationVinDbContext();
            Models.ProprietaireVignoble proprietaire = context.ProprietaireVignobles.Include(p => p.Vignobles).FirstOrDefault(p => p.IdProprietaire == idProprietaireVignoble);
            if (proprietaire != null)
            {
                Console.WriteLine($"Vignobles associés au propriétaire avec l'identifiant {idProprietaireVignoble}:");
                foreach (Models.Vignoble vignoble in proprietaire.Vignobles)
                {
                    Console.WriteLine($" - ID: {vignoble.IdVignoble}, Surface: {vignoble.Surface} ha, Emplacement: {vignoble.Emplacement}, Propriétaire: {proprietaire.Nom}");
                }
            }
            else
            {
                Console.WriteLine("Le propriétaire avec l'identifiant spécifié n'existe pas.");
            }
        }

        public static void AddVinToQualite(int idQualite, Models.Vin vin)
        {
            ApplicationVinDbContext context = new ApplicationVinDbContext();
            Models.Qualite qualite = context.Qualites.Find(idQualite);
            if (qualite != null)
            {
                qualite.Vins.Add(vin);
                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("La qualité avec l'identifiant spécifié n'existe pas.");
            }
        }

        public static void DeleteVinFromQualite(int idVin, int idQualite)
        {
            ApplicationVinDbContext context = new ApplicationVinDbContext();
            Models.Qualite qualite = context.Qualites.Find(idQualite);
            if (qualite != null)
            {
                Models.Vin vin = qualite.Vins.FirstOrDefault(v => v.IdVin == idVin);
                if (vin != null)
                {
                    qualite.Vins.Remove(vin);
                    context.SaveChanges();
                }
                else
                {
                    Console.WriteLine("Le vin avec l'identifiant spécifié n'est pas associé à cette qualité.");
                }
            }
            else
            {
                Console.WriteLine("La qualité avec l'identifiant spécifié n'existe pas.");
            }
        }

        public static void ShowVinsOfQualite(int idQualite)
        {
            ApplicationVinDbContext context = new ApplicationVinDbContext();
            Models.Qualite qualite = context.Qualites.Include(q => q.Vins).FirstOrDefault(q => q.IdQualite == idQualite);
            if (qualite != null)
            {
                Console.WriteLine($"Vins associés à la qualité avec l'identifiant {idQualite}:");
                foreach (Models.Vin vin in qualite.Vins)
                {
                    Console.WriteLine($" - ID: {vin.IdVin}, Alcohol: {vin.Alcohol}%, Sulphates: {vin.Sulphates}, Citric Acid: {vin.CitricAcid}, Volatile Acidity: {vin.VolatileAcidity}, Quality: {vin.Quality}");
                }
            }
            else
            {
                Console.WriteLine("La qualité avec l'identifiant spécifié n'existe pas.");
            }
        }




    }
}
