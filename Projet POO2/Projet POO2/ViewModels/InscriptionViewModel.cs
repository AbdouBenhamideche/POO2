using GestionVin;
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
    
}
