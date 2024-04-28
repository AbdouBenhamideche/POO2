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
    public class Vignoble : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        [Key] public int _idVignoble { get; set; }
        public float _surface { get; set; }
        public string _emplacement { get; set; }
        public int _idTerrain { get; set; }
        public Terrain _terrain { get; set; }
        public int _idProprietaireVignoble { get; set; }
        public ProprietaireVignoble _proprietaireVignoble { get; set; }


        public Vignoble()
        {

        }
        public Vignoble(float surface, string emplacement, int idTerrain, int idProprietaireVignoble)
        {
            this._surface = surface;
            this._emplacement = emplacement;
            this._idTerrain = idTerrain;
            this._idProprietaireVignoble = idProprietaireVignoble;
        }

        public int IdVignoble
        {
            get { return _idVignoble; }
            set { this._idVignoble = value;}
        }
        public float Surface
        {
            get { return this._surface; }
            set { this._surface = value;
                SetVerifierVignoble();
                OnPropertyChanged();



            }
        }
        public string Emplacement
        {
            get { return this._emplacement; }
            set { this._emplacement = value;
                SetVerifierVignoble();
                OnPropertyChanged();

            }
        }
        public int IdTerrain
        {
            get { return this._idTerrain; }
            set { this._idTerrain = value;
                SetVerifierVignoble();
                OnPropertyChanged();

            }
        }
        public int IdProprietaireVignoble
        {
            get { return this._idProprietaireVignoble; }
            set { this._idProprietaireVignoble = value;
                SetVerifierVignoble();
                OnPropertyChanged();

            }
        }







        private bool _verifierVignoble;
        public bool VerifierVignoble
        {
            get { return _verifierVignoble; }
            set { _verifierVignoble = value; }
        }


        private void SetVerifierVignoble()
        {
            this._verifierVignoble = (Surface != 0) &&
            (IdTerrain != 0) &&
            (IdProprietaireVignoble != 0) &&
            !string.IsNullOrEmpty(Emplacement); 
         
        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }







    }
}
