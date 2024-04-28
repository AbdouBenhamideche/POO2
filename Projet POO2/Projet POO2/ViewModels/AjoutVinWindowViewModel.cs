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
    class AjoutVinWindowViewModel
    {
        public Models.Vin Vin{ get; set; }
        private Views.AjoutVinWindow _ajoutVinWindow;

        public AjoutVinWindowViewModel(Views.AjoutVinWindow ajoutVinWindow)
        {
            this.Vin = new Models.Vin();
            this._ajoutVinWindow = ajoutVinWindow;

            VinCommand = new RelayCommand(
               o => this.Vin.IsValid,
               o => this.ActionTest()
           );
        }
        public ICommand VinCommand { get; private set; }
        public void ActionTest() {
            Models.Vin vin = new Models.Vin(this.Vin.Name, this.Vin.Type, this.Vin.Alcohol, this.Vin.CitricAcid, this.Vin.Sulphates, this.Vin.VolatileAcidity, new Qualite());
            ApplicationVinDbContext.AddVin(vin);
            //ListVin.AddToList(vin);

        }
    }
}
