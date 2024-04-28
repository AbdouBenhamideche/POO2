using Microsoft.Identity.Client;
using Projet_POO2.Migrations;
using Projet_POO2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Projet_POO2.Views
{
    /// <summary>
    /// Logique d'interaction pour GererVinView.xaml
    /// </summary>
    public partial class GererVinView : Window
    {
        public GererVinView()
        {
            InitializeComponent();
        }

        private void AjouterVin(object sender, RoutedEventArgs e)
        {
            AjoutVinWindow ajoutVinWindow = new AjoutVinWindow();
            ajoutVinWindow.ShowDialog();
        }
        private void ModifierVin(object sender, RoutedEventArgs e)
        {
            ModifierVinWindow modifierVinWindow = new ModifierVinWindow(); modifierVinWindow.ShowDialog();
        }
        private void SupprimerVin(object sender, RoutedEventArgs e)
        {
            SupprimerVinWindow supprimerVinWindow = new SupprimerVinWindow(); supprimerVinWindow.ShowDialog();
 
        }
        private void Raflaichir(object sender, RoutedEventArgs e)
        {
            AddVinElementsToStackPanel(ApplicationVinDbContext.GetAllVins());

        }
        private void AddVinElementsToStackPanel(List<Models.Vin> vins)
        {
            // Get the StackPanel element from XAML
            StackPanel listVinStackPanel = FindName("ListVin") as StackPanel;

            // Check if the StackPanel exists
            if (listVinStackPanel != null)
            {
                // Iterate through the Vin objects
                foreach (Models.Vin vin in vins)
                {
                    // Create a TextBlock to display Vin information
                    TextBlock vinTextBlock = new TextBlock();
                    vinTextBlock.Text = $"Vin ID: {vin.IdVin}, Alcohol: {vin.Alcohol}, Citric Acid: {vin.CitricAcid}, Sulphates: {vin.Sulphates}, Volatile Acidity: {vin.VolatileAcidity}";

                    // Add the TextBlock to the StackPanel
                    listVinStackPanel.Children.Add(vinTextBlock);
                }
            }
            else
            {
                // Handle the case where the StackPanel is not found
                Console.WriteLine("StackPanel with name 'ListVin' not found.");
            }
        }

    }
}
