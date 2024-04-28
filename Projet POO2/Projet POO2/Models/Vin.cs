using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.ComponentModel.DataAnnotations;

namespace Projet_POO2.Models
{
    public class Vin : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        [Key] public int _idVin { get; set; }
        private string _name;
        private string _type;
        private float _alchool;
        private float _acideCitric;
        private float _sulphates;
        private float _volatileAcidity;
        private int _qualite;
        public Qualite Quality { get; set; }
        public ICollection<Test> Tests { get; set; }
        public ICollection<TestVin> TestVins { get; set; }


        public Vin(string name, string type, float alcohol, float acideCitric, float sulphates, float volatileAcidity) {

            this._name = name;
            this._type = type;
            this._alchool = alcohol;
            this._acideCitric = acideCitric;
            this._sulphates = sulphates;
            this._volatileAcidity = volatileAcidity;

        }
        public Vin(string name, string type, float alcohol, float acideCitric, float sulphates, float volatileAcidity, int qualite) {

            this._name = name;
            this._type = type;
            this._alchool = alcohol;
            this._acideCitric = acideCitric;
            this._sulphates = sulphates;
            this._volatileAcidity = volatileAcidity;
            this._qualite = qualite;

        }
        public Vin()
        {

        }



        public int IdVin { get { return _idVin; } set { this._idVin = value; } }

        public string Name
        {
            get { return _name; }
            set {
                _name = value;
                this.SetIsValid();
                OnPropertyChanged();
            }
        }

        // Accesseur pour _type
        public string Type
        {
            get { return _type; }
            set { _type = value;
                this.SetIsValid();
                OnPropertyChanged();
            }
        }

        // Accesseur pour _alcohol
        public float Alcohol
        {
            get { return _alchool; }
            set { _alchool = value;
                this.SetIsValid();
                OnPropertyChanged();
            }
        }

        // Accesseur pour _citricAcid
        public float CitricAcid
        {
            get { return _acideCitric ; }
            set { _acideCitric = value;
                this.SetIsValid();
                OnPropertyChanged();
            }
        }

        // Accesseur pour _sulphates
        public float Sulphates
        {
            get { return _sulphates; }
            set { _sulphates = value;
                this.SetIsValid();
                OnPropertyChanged();
            }
        }

        // Accesseur pour _volatileAcidity
        public float VolatileAcidity
        {
            get { return _volatileAcidity; }
            set { _volatileAcidity = value;
                this.SetIsValid();
                OnPropertyChanged();
            }
        }

        public int Qualite
        {
            get { return _qualite; }
            set { _qualite = value;}
        }

        private bool _isValid;

        public bool IsValid
        {
            get { return this._isValid; }
        }
        private void SetIsValid()
        {
            this._isValid = !string.IsNullOrEmpty(Name) &&
           !string.IsNullOrEmpty(Type);
        }
        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
