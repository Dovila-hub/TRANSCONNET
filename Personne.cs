using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRANSCONNET
{
    abstract internal class Personne : IId
    {
        #region Champs
        protected int id;
        protected string nom;
        protected string prenom;
        protected DateTime dateNaissance;
        protected string adressePostale;
        protected string adresseMail;
        protected int telephone;
        #endregion

        #region Constructeur
        public Personne ( int id, string nom, string prenom, DateTime dateNaissance, string adressePostale, string adresseMail, int telephone)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.dateNaissance = dateNaissance;
            this.adressePostale = adressePostale;
            this.adresseMail = adresseMail;
            this.telephone = telephone;
        }

        public Personne () 
        {
            this.id = 0;
            this.nom = nom;
            this.prenom = prenom;
            this.dateNaissance = dateNaissance;
            this.adressePostale = adressePostale;
            this.adresseMail = adresseMail;
            this.telephone = telephone;
        }
        #endregion

        #region get-set
        public int Id
        {
            get { return id; }
        }
        public string Nom
        {
            get { return nom; } 
            set { nom = value; }
        }
        public string Prenom
        {
            get { return prenom; } 
            set { prenom = value; }
        }
        public DateTime DateNaissance
        {
            get {return dateNaissance; }
            set { dateNaissance = value; }
        }

        public string AdressePostale
        { get { return adressePostale; }
          set {  adressePostale = value; } 
        }
        public string AdresseMail

        {
          get { return adresseMail; } 
          set { adresseMail = value; }
        }
        public int Telephone
        { 
            get { return telephone; }
            set {  telephone = value; }
        }
        #endregion

        #region Methodes
        public override string ToString()
        {
            return nom + "  " + prenom;
        }
        public virtual string ToStringComplete()
        {
           return "Nom : " + nom + "\n Prenom : " + prenom + "\n Date de naissance : " + dateNaissance + "\n Adresse Postale : " + adressePostale + "\n Adresse Mail : " + adresseMail + "\n Telephone : " + telephone + "\n"; 
        }

        #endregion
    }
}
