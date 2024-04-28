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
    /// Logique d'interaction pour ModifierMotDePasse.xaml
    /// </summary>
    public partial class ModifierMotDePasse : Window
    {
        public ModifierMotDePasse()
        {
            InitializeComponent();
        }
        public void OK(object sender, RoutedEventArgs e) { }
        public void Annuler(object sender, RoutedEventArgs e)
        {

            this.Close();
        }
    }
 
}
