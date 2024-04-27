using GestionVin;
using Projet_POO2.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Projet_POO2.ViewModels
{
    public class InscriptionViewModel
    {
        public Models.Utilisateur Utilisateur { get; set; }
        private GestionVin.MainWindow _mainWindow;
        public InscriptionViewModel(GestionVin.MainWindow mainWindow) {
        this.Utilisateur = new Models.Utilisateur();
        this._mainWindow = mainWindow;
            InscriptionCommande = new RelayCommand(
                o => Utilisateur.VerifierInfosInscription,
                o => Inscreption()

                );
            
        }

        public ICommand InscriptionCommande { get;private set; }
        public void Inscreption()
        {
            MessageBox.Show(Utilisateur.MotDePasse);
            
        }
    }
    //public class ConnexionViewModel
    //{
    //    public Models.Connexion Connexion { get; set; }
    //    private GestionVin.MainWindow _mainWindow;
    //    public ConnexionViewModel(GestionVin.MainWindow mainWindow)
    //    {
    //        this.Connexion = new Models.Connexion();
    //        this._mainWindow = mainWindow;
    //        ConnexionCommande = new RelayCommand(
    //            o => Connexion.VerifierInfosConnexion,
    //            o => ConnexionIn()

    //            );

    //    }

    //    public ICommand ConnexionCommande { get; private set; }
    //    public void ConnexionIn()
    //    {
    //        _mainWindow.inProgramWindow = new InProgramWindow();
    //        _mainWindow.inProgramWindow.Show();

    //        _mainWindow.Close();

    //    }
    //}

}
