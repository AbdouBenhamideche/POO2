using GestionVin;
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
    /// Logique d'interaction pour ModifierMotDePasse.xaml
    /// </summary>
    public partial class ModifierMotDePasse : Window
    {
        public Utilisateur user = new Utilisateur();
        public ModifierMotDePasse()
        {
            InitializeComponent();
            
            user = ApplicationVinDbContext.GetUserByEmail(MainWindow.x);
        }
        
        string password;
        string password2;
        public void OK(object sender, RoutedEventArgs e) {
            if (password == user.MotDePasse ) { 
                if(password2.Length < 8)
                {
                    MessageBox.Show("Nouveau mot de passe inseré est trop petit");
                }
                else
                {
                    ApplicationVinDbContext.UpdateUserPassword(MainWindow.x, password2);
                    MessageBox.Show("Nouveau mot de passe a été attribué");
                }


            } 
            else
            {
                MessageBox.Show("Mot de passe inseré est faux");
            }
        
        
        
        
        }
        public void Annuler(object sender, RoutedEventArgs e)
        {

            this.Close();
        }

        public void OnPasswordChangedChangement(object sender, RoutedEventArgs e)
        {


            PasswordBox passwordBox = (PasswordBox)sender;
            this.password = passwordBox.Password;

        }
        public void OnPasswordChangedNouveau(object sender, RoutedEventArgs e)
        {


            PasswordBox passwordBox = (PasswordBox)sender;
            this.password2 = passwordBox.Password;

        }

    }
 
}
