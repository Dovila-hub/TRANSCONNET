using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRANSCONNET
{

     internal class Voiture : Vehicule
        {
            #region Champs
            int nbPlaces;
            #endregion

            #region Constructeur
            public Voiture(string immatriculation, int nbPlaces) : base(immatriculation)
            {
                this.nbPlaces = nbPlaces;
            }
            #endregion

            #region getter-setter
            public int NbPlaces
            {
                get { return nbPlaces; }
            }
            #endregion

            #region Méthodes
            public override string ToString()
            {
                return "Voiture : " + base.ToString() + " NbPlaces : " + nbPlaces;
            }
            #endregion
        }
    }

