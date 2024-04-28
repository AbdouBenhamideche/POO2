using Projet_POO2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Projet_POO2.ViewModels
{
    public class ModifierVinWindowViewModel 
    {
        public Models.Vin Vin { get; set; }
        private Views.ModifierVinWindow _modifierVinWindow;

        public ModifierVinWindowViewModel(Views.ModifierVinWindow modifierVinWindow)
        {
            this.Vin = new Models.Vin();
            this._modifierVinWindow = modifierVinWindow;

            ModifierVinCommand = new RelayCommand(
               o => this.Vin.IsValid1,
               o => this.ActionTest()
           );
        }
        public ICommand ModifierVinCommand { get; private set; }
        public void ActionTest()
        {
            
            

        }
    }
}
