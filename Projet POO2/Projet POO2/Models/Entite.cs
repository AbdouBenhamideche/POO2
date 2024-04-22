using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Projet_POO2.Models
{
    class Entite : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string _name;
        private string _type;
        private float _alchool;
        private float _acideCitric;
        private float _sulphates;
        private float _volatileAcidity;



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

        private bool _isValid;

        public bool IsValid
        {
            get { return this._isValid; }
        }
        private void SetIsValid()
        {
            this._isValid = !string.IsNullOrEmpty(Name) &&
           !string.IsNullOrEmpty(Type) &&
           !string.IsNullOrEmpty(Alcohol.ToString()) &&
           !string.IsNullOrEmpty(Sulphates.ToString()) &&
           !string.IsNullOrEmpty(CitricAcid.ToString()) &&
           !string.IsNullOrEmpty(VolatileAcidity.ToString());
        }
        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
