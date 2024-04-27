using Projet_POO2.Models;
using Projet_POO2.ViewModels;
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
using System.Windows.Media.Media3D;
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
            DataContext = new Projet_POO2.ViewModels.InscriptionViewModel(this);
        }
        public InProgramWindow inProgramWindow;
        public void Inscription_Click(object sender, RoutedEventArgs e)
        {
           
        }
        public void Connexion_Click(object sender, RoutedEventArgs e) {
            inProgramWindow = new InProgramWindow();
            inProgramWindow.Show();

            this.Close();

        }
        public void OnPasswordChanged(object sender, RoutedEventArgs e)
        {
            // Access the password entered in the PasswordBox
            PasswordBox passwordBox = (PasswordBox)sender;
            string password = passwordBox.Password;
            InscriptionViewModel inscriptionViewModel = (InscriptionViewModel)DataContext;
            Utilisateur utilisateur = inscriptionViewModel.Utilisateur; // Assuming InscriptionViewModel has an Utilisateur property
            utilisateur.MotDePasse = pwPassword.Password;


            // Perform actions based on the entered password (e.g., validation, storing in model)
            // ... (your logic here)
        }
    }
}
