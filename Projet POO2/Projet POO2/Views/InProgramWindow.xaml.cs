﻿using GestionVin;
using Microsoft.VisualBasic.ApplicationServices;
using Projet_POO2.Migrations;
using Projet_POO2.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Linq;
using Projet_POO2.Models;

namespace Projet_POO2.Views
{
    /// <summary>
    /// Logique d'interaction pour InProgramWindow.xaml
    /// </summary>
    public partial class InProgramWindow : Window
    {
        public InProgramWindow()
        {
            InitializeComponent();
            Utilisateur user = new Utilisateur();
            user = ApplicationVinDbContext.GetUserByEmail(MainWindow.x);

            
            

            MessageAccueil.Text = $"            Bienvenue {user.Prenom}  {user.Nom} dans notre application de gestion du vin !Découvrez une expérience unique pour explorer, cataloguer, apprécier et évaluer la qualité d'une large sélection de vins. Que vous soyez un amateur passionné ou un professionnel du vin, notre application vous offre les outils nécessaires pour enrichir votre expérience vinicole. \r\n";

            ApplicationVinDbContext context = new ApplicationVinDbContext();
            
            DataContext = new ViewModels.InProgramViewModel(this);
        }

        public void GererVin(object sender, RoutedEventArgs e)
        {
            GererVinView gererVin = new GererVinView();
            gererVin.Show();

            //ListVin.Children.Clear();
            //foreach (var ent in Models.ListVin.VinList)
            //{
            //    // Créez un bouton
            //    Button button = new Button();

            //    // Définissez le contenu du bouton
            //    button.Content = ent.Name;

            //    // Ajoutez le bouton au StackPanel
            //    ListVin.Children.Add(button);
            //}

        }
        public void GererVignoble(object sender, RoutedEventArgs e) {
            AjoutVignobleWindow ajoutVignobleWindow = new AjoutVignobleWindow();
            ajoutVignobleWindow.ShowDialog();
        }
        public void GererTerrain(object sender, RoutedEventArgs e) {
        AjoutTerrainWindow ajoutTerrainWindow = new AjoutTerrainWindow();
            ajoutTerrainWindow.ShowDialog();
        }
        public void Annuler(object sender, RoutedEventArgs e) {
            txtNom.Text = "";
            txtPrenom.Text = "";
            DatePicker datePicker = (DatePicker)FindName("DateDeNaissance");
            datePicker.SelectedDate = null;


        }


        public void Quitter(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
            


        }
        public void Ouvrir(object sender, RoutedEventArgs e)
        {
            // Create an OpenFileDialog object
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Set filter for the file types the dialog should display
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            // Set the initial directory
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            // Set the title of the dialog
            openFileDialog.Title = "Select a File to Open";

            // Show the dialog and get the result
            var result = openFileDialog.ShowDialog();

            // Check if the user selected a file
            
                // Get the selected file path
                string selectedFilePath = openFileDialog.FileName;

                try
                {
                    // Open the file in read mode (without returning content)
                    using (StreamReader reader = new StreamReader(selectedFilePath))
                    {
                        // You can process the file content line by line here
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            // Process each line of the file
                            Console.WriteLine(line);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle any exceptions that occur while opening the file
                    Console.WriteLine("Error opening file: " + ex.Message);
                }
            

        }
        public void Apprentissage_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Predire(object sender, RoutedEventArgs e)
        {
            //effectuer une prediction 
        }

        public void Confirmer(object sender, RoutedEventArgs e) {
            string nom, prenom, dateDeNaissance;
            Utilisateur user = new Utilisateur();
            user = ApplicationVinDbContext.GetUserByEmail(MainWindow.x);
            DatePicker datePicker = (DatePicker)FindName("DateDeNaissance");

            nom = txtNom.Text;
            prenom = txtPrenom.Text;
            dateDeNaissance = datePicker.SelectedDate.ToString();
            if (!string.IsNullOrEmpty(nom) && !string.IsNullOrEmpty(prenom) && !string.IsNullOrEmpty(dateDeNaissance)) { 
            ApplicationVinDbContext.UpdateUser(nom, prenom, user.IdUtilisateur, dateDeNaissance);
                System.Windows.MessageBox.Show("Modification effectué avec succées, Redemarrez l'application pour effectuer les changements");
               user.Nom = nom;
                user.Prenom = prenom;
                user.DateDeNaissance = dateDeNaissance.ToString();
                
            }
            else
            {
                System.Windows.MessageBox.Show("Vouillez remplir tout les champs");
            }


        }
        public void ModifierMotDePasse(object sender, RoutedEventArgs e) { 
        ModifierMotDePasse modifierMotDePasse = new ModifierMotDePasse();
            modifierMotDePasse.ShowDialog();
        
        }

    }
}
