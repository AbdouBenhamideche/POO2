using Projet_POO2.Views;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GestionVin
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public void Inscription_Click(object sender, RoutedEventArgs e)
        {
           
        }
        public void Connexion_Click(object sender, RoutedEventArgs e) {
            InProgramWindow inProgramWindow = new InProgramWindow();
            inProgramWindow.Show();

            this.Close();

        }
    }
}
