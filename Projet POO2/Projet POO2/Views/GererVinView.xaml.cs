using Microsoft.Identity.Client;
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

    }
}
