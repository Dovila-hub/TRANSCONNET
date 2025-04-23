using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRANSCONNET
{
    internal class Salarie: Personne, IPrix
    {
        #region Champs
        DateTime dateEmbauche;
        string poste;
        int salaire;
        List<DateTime> planning; // ici nous allons mettre les dates ou le conducteur nest plus libre
        #endregion

        #region Constructeur
        public Salarie( int id, string nom, string prenom, DateTime dateNaissance, string adressePostale, string adresseMail, int telephone, DateTime dateEmbauche, string poste, int salaire ): base(id, nom,prenom,dateNaissance,adressePostale, adresseMail, telephone)
        {
            this.dateEmbauche = dateEmbauche;
            this.poste = poste;
            this.salaire = salaire;
            this.planning = new List<DateTime>();
        }

        public Salarie() : base() 
        {
            this.dateEmbauche = new DateTime();
            this.poste = poste = "";
            this.salaire = 0;
            this.planning = new List<DateTime>();
        }
        #endregion

        #region get-set
        public DateTime DateEmbauche
        {
            get { return dateEmbauche;}

        }
        public string Poste
        {
            get { return poste; }
            set { poste = value; }
        }
        public int Salaire
        {
            get { return salaire; }
            set { salaire = value;}
        }
        public int Prix
        {
            get { return salaire; }
            set { salaire = value;}
        }
        public bool IsDriver()
        { 
            return poste.ToUpper()== "CHAUFFEUR";
        }
        public List<DateTime> Planning
        {
            get { if (IsDriver()) return planning; else return null; }
            set { planning = value; }
        }
        public float TarifHoraire
        {
            get { if (IsDriver()) return (float)salaire / 140f; else return -1;}

        }
        #endregion
        #region Methodes
        public override string ToString()
        {
            return "Salarié : " + base.ToStringComplete() + "\n Date d'embauche : " + dateEmbauche + "\n Poste : " + poste + "\n Salaire : " + salaire + "\n Sécurité sociale : " + id + "\n Adresse Mail : " + adresseMail + "\n Adresse Mail : " + adresseMail + "\n Telephone : " + telephone + "\n";
        }
        public override string ToStringComplete()
        {
            return " \n Salarié: " + base.ToStringComplete() + "\n Date d'embauche: " + dateEmbauche + "\n Poste : " + poste + "\n Salaire : " + salaire + " Sécurité sociale : " + base.id;

        }

        public static bool Equal (Salarie s1, Salarie s2)
        { 
            return s1.Nom == s2.Nom && s2.Prenom == s2.Prenom; 
        }
        public bool EstDisponible(DateTime dateLivraison)
        {
            return !this.Planning.Contains(dateLivraison);
        }
        #endregion



    }
}
