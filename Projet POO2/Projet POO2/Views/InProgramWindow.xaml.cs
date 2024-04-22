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
        }

        public void AjouterEntite(object sender, RoutedEventArgs e)
        {
            AjoutEntiteWindow ajoutEntiteWindow = new AjoutEntiteWindow();
            ajoutEntiteWindow.ShowDialog();

            ListEntite.Children.Clear();
            foreach (var ent in Models.ListEntite.entiteList)
            {
                // Créez un bouton
                Button button = new Button();

                // Définissez le contenu du bouton
                button.Content = ent.Name;

                // Ajoutez le bouton au StackPanel
                ListEntite.Children.Add(button);
            }

        }
    }
}
