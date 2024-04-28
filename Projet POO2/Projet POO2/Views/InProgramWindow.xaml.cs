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
    /// Logique d'interaction pour InProgramWindow.xaml
    /// </summary>
    public partial class InProgramWindow : Window
    {
        public InProgramWindow()
        {
            InitializeComponent();
            MessageAccueil.Text = "            Bienvenue dans notre application de gestion du vin !Découvrez une expérience unique pour explorer, cataloguer, apprécier et évaluer la qualité d'une large sélection de vins. Que vous soyez un amateur passionné ou un professionnel du vin, notre application vous offre les outils nécessaires pour enrichir votre expérience vinicole. \r\n";
        }

        public void AjouterVin(object sender, RoutedEventArgs e)
        {
            AjoutVinWindow ajoutVinWindow = new AjoutVinWindow();
            ajoutVinWindow.ShowDialog();

            ListVin.Children.Clear();
            foreach (var ent in Models.ListVin.VinList)
            {
                // Créez un bouton
                Button button = new Button();

                // Définissez le contenu du bouton
                button.Content = ent.Name;

                // Ajoutez le bouton au StackPanel
                ListVin.Children.Add(button);
            }

        }
        public void AjouterVignoble(object sender, RoutedEventArgs e) {
            AjoutVignobleWindow ajoutVignobleWindow = new AjoutVignobleWindow();
            ajoutVignobleWindow.ShowDialog();
        }
        public void AjouterTerrain(object sender, RoutedEventArgs e) {
        AjoutTerrainWindow ajoutTerrainWindow = new AjoutTerrainWindow();
            ajoutTerrainWindow.ShowDialog();
        }
        public void Annuler(object sender, RoutedEventArgs e) { }
        public void Confirmer(object sender, RoutedEventArgs e) { }
        public void ModifierMotDePasse(object sender, RoutedEventArgs e) { 
        ModifierMotDePasse modifierMotDePasse = new ModifierMotDePasse();
            modifierMotDePasse.ShowDialog();
        
        }

    }
}
