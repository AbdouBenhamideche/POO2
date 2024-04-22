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
    /// Logique d'interaction pour AjoutEntiteWindow.xaml
    /// </summary>
    public partial class AjoutEntiteWindow : Window
    {
        public AjoutEntiteWindow()
        {
            InitializeComponent();
            DataContext = new ViewModels.AjoutEntiteWindowViewModel(this);
        }
        private void Annuler(object sender, RoutedEventArgs e)
        {
            // Fermer la fenêtre
            this.Close();
        }
        private void Ajouter(object sender, RoutedEventArgs e)
        {
            // Supprimer tous les enfants du StackPanel



            this.Close();
        }



    }
}
