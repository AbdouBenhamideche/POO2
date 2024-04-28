using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;

namespace Projet_POO2.ViewModels
{
    public class ModifierMotDePasseWindowViewModel
    {
        public Models.Utilisateur Utilisateur { get; set; }
        private GestionVin.MainWindow _mainWindow;
        public ModifierMotDePasseWindowViewModel(GestionVin.MainWindow mainWindow)
        {
            this.Utilisateur = new Models.Utilisateur();
            this._mainWindow = mainWindow;
            InscriptionCommande = new RelayCommand(
                o => Utilisateur.VerifierMotDePasse,
                o => Inscreption()

                );

        }

        public ICommand InscriptionCommande { get; private set; }
        public void Inscreption()
        {
            MessageBox.Show(Utilisateur.MotDePasse);

        }
    }
}
