using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRANSCONNET
{
    public delegate void Ui();
    internal class AffichageGraphique
    {
        #region Champs
        public Manager manager;
        public LectureFichier fileExplorerSalarie; //modifie les salariés
        public LectureFichier fileExplorerClient;// modifie les clients
        public LectureFichier fileExplorerDistances; // permet de lire le fichier distances_villes_france.csv
        public LectureFichier fileExplorerCommandes; // permet de lire le fichier commandes.csv
        bool display = false; // permet d'afficher l'organigramme de l'entreprise
        bool main = true;
        #endregion

        #region Constructeurrs
        public AffichageGraphique(string pathSalaries, string pathClients, string pathDistances, string pathCommandes, Manager manager)
        { 
            this.manager = manager;

        }
        #region AffichageTransconnect
        void ExceptionManager(Ui func)
        {
            try
            {
                func();
            }
            catch (Exception e)
            {
                main = false;
                Console.WriteLine(e.Message);
                Console.WriteLine("Veillez reessayer");
                Console.WriteLine("Appuyer sur une touche");
                Console.ReadKey();
                Console.Clear();
                ExceptionManager(Affichage);

            }
        }


    }
}
