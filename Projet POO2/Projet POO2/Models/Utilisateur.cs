using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Xml.Linq;

namespace Projet_POO2.Models
{
    public class Utilisateur : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public int _identifiant;
        public string _nom;
        public string _prenom;
        public string _dateDeNaissance;
        public string _civilite;
        public string _email { get; set; }
        public string _motDePasse{ get; set; }

        public Utilisateur(string nom, string prenom,string dateDeNaissance, string civilite  ,string email, string motDePasse)
        {
            this._nom = nom;
            this._prenom = prenom;
            this._dateDeNaissance = dateDeNaissance;    
            this._civilite = civilite;
            this._email = email;
            this._motDePasse = motDePasse;
        }


        public string Nom
        {
            get { return _nom; }
            set
            {
                _nom = value;
                this.SetVerifierInfosInscription();
                OnPropertyChanged();
            }
        }
        public string Prenom
        {
            get { return _prenom; }
            set
            {
                _prenom = value;
                this.SetVerifierInfosInscription();
                OnPropertyChanged();
            }
        }

        public string DateDeNaissance
        {
            get { return _dateDeNaissance; }
            set
            {
                _dateDeNaissance = value.ToString();
                this.SetVerifierInfosInscription();
                OnPropertyChanged(nameof(DateDeNaissance));

            }
        }

        public string Civilite
        {
            get { return _civilite; }
            set
            {
                _civilite = value;
                this.SetVerifierInfosInscription();
                OnPropertyChanged();
            }
        }

        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
                this.SetVerifierInfosInscription();
                OnPropertyChanged();
            }
        }

        public string MotDePasse
        {
            get { return _motDePasse; }
            set
            {
                _motDePasse = value;
                this.SetVerifierInfosInscription();
                OnPropertyChanged();
            }
        }
        







        public Utilisateur()
        {

        }
        private bool _verifierInfosInscription;
        public bool VerifierInfosInscription
        {
            get { return this._verifierInfosInscription; }
        }

        private void SetVerifierInfosInscription()
        {
            this._verifierInfosInscription = !string.IsNullOrEmpty(Nom) &&
         !string.IsNullOrEmpty(Prenom) &&
         !string.IsNullOrEmpty(Email) &&
         IsValidEmail(Email) &&
         !string.IsNullOrEmpty(Civilite) &&
         !string.IsNullOrEmpty(MotDePasse) &&
         HasAtLeast8Characters(MotDePasse);
         ;
        }
        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public static bool IsValidEmail(string email)
        {
            const string regex = @"^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$";
            return Regex.Match(email, regex).Success;
        }
        public static bool HasAtLeast8Characters(string inputString)
        {
            return inputString.Length >= 8;
        }
    }
}
