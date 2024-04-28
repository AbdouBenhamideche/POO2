using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Projet_POO2.ViewModels
{
    public class AjoutVignobleWindowViewModel
    {

        public Models.Vignoble Vignoble { get; set; }
        private Views.AjoutVignobleWindow _ajoutVignobleWindow;

        public AjoutVignobleWindowViewModel(Views.AjoutVignobleWindow ajoutVignobleWindow)
        {
            this.Vignoble = new Models.Vignoble();
            this._ajoutVignobleWindow = ajoutVignobleWindow;

            VignobleCommand = new RelayCommand(
               o => this.Vignoble.VerifierVignoble,
               o => this.ActionTest()
           );
        }
        public ICommand VignobleCommand { get; private set; }
        public void ActionTest()
        {
            Models.Vignoble Vignoble = new Models.Vignoble(this.Vignoble.Surface, this.Vignoble.Emplacement, this.Vignoble.IdTerrain, this.Vignoble.IdProprietaireVignoble);
            _ajoutVignobleWindow.Close();

        }

    }
}
