using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Collections.ObjectModel;
using Projet_POO2.Models;

namespace Projet_POO2.ViewModels
{
    class AjoutEntiteWindowViewModel
    {
        public Models.Entite Entite{ get; set; }
        private Views.AjoutEntiteWindow _ajoutEntiteWindow;

        public AjoutEntiteWindowViewModel(Views.AjoutEntiteWindow ajoutEntiteWindow)
        {
            this.Entite = new Models.Entite();
            this._ajoutEntiteWindow = ajoutEntiteWindow;

            EntiteCommand = new RelayCommand(
               o => this.Entite.IsValid,
               o => this.ActionTest()
           );
        }
        public ICommand EntiteCommand { get; private set; }
        public void ActionTest() {
            Models.Entite entite = new Models.Entite(this.Entite.Name, this.Entite.Type, this.Entite.Alcohol, this.Entite.CitricAcid, this.Entite.Sulphates, this.Entite.VolatileAcidity);
            ListEntite.AddToList(entite);

        }
    }
}
