using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Projet_POO2.ViewModels
{
     class SupprimerVinWindowViewModel
    {
        public Models.Vin Vin { get; set; }
        private Views.SupprimerVinWindow _supprimerVinWindow;

        public SupprimerVinWindowViewModel(Views.SupprimerVinWindow supprimerVinWindow)
        {
            this.Vin = new Models.Vin();
            this._supprimerVinWindow = supprimerVinWindow;

            SupprimerVinCommand = new RelayCommand(
               o => this.Vin.IsValid2,
               o => this.ActionTest()
           );
        }
        public ICommand SupprimerVinCommand { get; private set; }
        public void ActionTest()
        {



        }
    }
}
