using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace Projet_POO2.Models
{
    public class DonneesEntrainementArbre : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        private string _trainingData;
        private string _testingData;
        private float _accuracy;
        public float Accuracy { get { return _accuracy; } set { _accuracy = value; OnPropertyChanged(); } }

        public string SelectFileOnDesktop()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Définir le répertoire initial pour le bureau
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            // Définir les filtres de fichiers si nécessaire
            openFileDialog.Filter = "Fichiers CSV (*.csv)|*.csv|Tous les fichiers (*.*)|*.*";

            // Afficher la boîte de dialogue de sélection de fichier
            bool? result = openFileDialog.ShowDialog();

            // Vérifier si un fichier a été sélectionné
            if (result == true)
            {
                // Récupérer le chemin complet du fichier sélectionné
                return openFileDialog.FileName;
            }
            else
            {
                return null;
            }
        }

        public string TrainingData
        {
            get { return _trainingData; }
            set { if (_trainingData != value) { _trainingData = SelectFileOnDesktop(); SetIsValid(); OnPropertyChanged(); } }
        }


        public string TestingData
        {
            get { return _testingData; }
            set { if (_testingData != value) { _testingData = SelectFileOnDesktop(); SetIsValid(); OnPropertyChanged(); } }
        }
        private bool _isValid;

        public bool IsValid
        {
            get { return _isValid; }
        }

        private void SetIsValid()
        {
            _isValid = !string.IsNullOrEmpty(TrainingData) && !string.IsNullOrEmpty(TestingData);
        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


    }
}

