using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRANSCONNET
{
    internal class Camion_citerne : Camion
    {
        #region Champs
        string typeCuve;
        #endregion

        #region Constructeur
        public Camion_citerne(string immatriculation, int capacite, List<string> matieresTransportees, string typeCuve) : base(immatriculation, capacite, matieresTransportees)
        {
            this.typeCuve = typeCuve;
        }
        #endregion

        #region getter-setter
        public string TypeCuve
        {
            get { return typeCuve; }
        }
        #endregion

        #region Méthodes
        public override string ToString()
        {
            return "Camion_citerne : " + base.ToString() + " Type de cuve : " + typeCuve;
        }
        #endregion
    }
}
