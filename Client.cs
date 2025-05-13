using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRANSCONNET
{
    internal class Client :Personne
    {
        #region Champs
        List<Commande> commandes;
        #endregion
        #region Constructeur
        public Client(int id, string nom, string prenom, DateTime dateNaissance, string adressePostale, string adresseMail, int telephone):base (id,nom,prenom,dateNaissance,adressePostale,adresseMail,telephone)
        {
            this.commandes =new List<Commande>();
        }
        public Client(): base()
        {
            this.commandes = new List< Commande>();
        }
        #endregion
        #region getter-setter
        public List<Commande> Commandes
        {
            get { return commandes; }
        }
        #endregion
        #region Ajout et Retrait de Commande
        public void AjouteCommande( Commande command)
        {
            commandes.Add(command);
        }
        public void RetireCommande( Commande command)
        {
            commandes.Remove(command);

        }
        public void RetireCommande(int id)
        {
            foreach ( Commande command in commandes)
            {
                if (command.Id == id)
                {
                    commandes.Remove(command);
                    break;
                }


            }
        }
        #endregion

        #region Affichage
        public override string ToString()
        {
           string res = "Client :" + base.ToString();
            foreach ( Commande com in commandes)
            {
                res += "\n" + com.ToString();
            }
            return res;
        }
        public override string ToStringComplete()
        {
            string res = " Client : " + base.ToStringComplete() + "ID : " + id + "\n Prix Total de la commande : " + PrixCommandes() + " euros ";
            foreach ( Commande com in commandes)
            {
                res += "\n" + com.ToString();
            }
            return res;
        }
        public void AfficherClient()
        {
            Console.WriteLine(this);
        }
        #endregion
        public int PrixCommandes() // Renvoie la somme totale payé par le client 
        {
            int prix = 0;
            foreach ( Commande com in commandes)
            {
                if (com != null)
                {
                    prix += com.Prix;
                }
            }
            return prix;
        }
        

    }
}
