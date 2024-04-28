using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Projet_POO2.Models
{
    public class Terrain : INotifyPropertyChanged
   
    {
        public event PropertyChangedEventHandler PropertyChanged;
        [Key] public int _idTerrain { get; set; }
        public float _surface { get; set; }
        public string _emplacement { get; set; }
        public ICollection<Models.Vignoble> vignobles { get; set; }

        public Terrain(float surface, string emplacement)
        {
            this._surface = surface;
            this._emplacement = emplacement;
            vignobles = new List<Vignoble>();
        }
        public Terrain()
        {
            
            vignobles = new List<Vignoble>();
        }

        public string Emplacement
        {
            get { return this._emplacement; }
            set { this._emplacement = value;
                SetVerifierTerrain();
                OnPropertyChanged();

            }
        }
        public float Surface
        {
            get { return this._surface; }
            set { this._surface = value;
                SetVerifierTerrain();
                OnPropertyChanged();
            }
        }
        private bool _verifierTerrain;
        public bool VerifierTerrain
        {
            get { return _verifierTerrain; }
            set { _verifierTerrain = value; }
        }

        private void SetVerifierTerrain()
        {
            this._verifierTerrain = (Surface != 0) &&
         !string.IsNullOrEmpty(Emplacement);
        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
