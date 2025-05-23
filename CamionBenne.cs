﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRANSCONNET
{
        internal class Camion_benne : Camion
        {
            #region Champs
            List<string> equipements;
            #endregion

            #region constructeur
            public Camion_benne(string immatriculation, int capacite, List<string> matieresTransportees, List<string> equipements) : base(immatriculation, capacite, matieresTransportees)
            {
                this.equipements = equipements;
            }
            #endregion

            #region getter-setter
            public List<string> Equipements
            {
                get { return equipements; }
                set { equipements = value; }
            }
            #endregion

            #region Méthodes
            public override string ToString()
            {
                string res = "Camion_benne : " + base.ToString() + " equipements : ";
                foreach (string s in equipements)
                {
                    res += s + " ";
                }
                return res;
            }
            #endregion

        }
    }

