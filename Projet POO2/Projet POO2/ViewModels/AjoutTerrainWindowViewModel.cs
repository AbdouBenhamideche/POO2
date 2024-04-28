using Projet_POO2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Projet_POO2.ViewModels
{
    public class AjoutTerrainWindowViewModel
    {
        public Models.Terrain Terrain { get; set; }
        private Views.AjoutTerrainWindow _ajoutTerrainWindow;

        public AjoutTerrainWindowViewModel(Views.AjoutTerrainWindow ajoutTerrainWindow)
        {
            this.Terrain = new Models.Terrain();
            this._ajoutTerrainWindow = ajoutTerrainWindow;

            TerrainCommand = new RelayCommand(
               o => this.Terrain.VerifierTerrain,
               o => this.ActionTest()
           );
        }
        public ICommand TerrainCommand { get; private set; }
        public void ActionTest()
        {
            Models.Terrain Terrain = new Models.Terrain(this.Terrain.Surface, this.Terrain.Emplacement);
            _ajoutTerrainWindow.Close();

        }
    }
}
