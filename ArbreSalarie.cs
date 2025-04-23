using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRANSCONNET
{
    internal class ArbreSalarie
    {
        #region Champs
        Salarie s;
        ArbreSalarie frere;
        ArbreSalarie fils;
        #endregion
        #region Constructeurs
        public ArbreSalarie ( Salarie s )
        {
            this.s = s;
            frere = null;
            fils = null;

        }
        #endregion

        #region Properties
        public Salarie Salarie { get; }
        #endregion

        #region Gestion de l'arbre
        public void CreerArbre ( List<Salarie> salaries, ArbreSalarie boss = null)
        {
            if(salaries.Count > 1)
            {
                if ( boss == null)
                {
                    fils = new ArbreSalarie (salaries[0]);
                    salaries.RemoveAt (0);
                   //f (fils != null) fils.CreerArbre(salaries, this);

                }
                else
                {
                    frere = new ArbreSalarie(salaries[0]);
                    fils = new ArbreSalarie(salaries[1]);
                    salaries.RemoveAt (0);
                    salaries.RemoveAt(1);
                    if (fils != null)
                        fils.CreerArbre(salaries, this);
                }
            }
            if (salaries.Count == 1)
            {
                frere = new ArbreSalarie(salaries[0]);
                salaries.RemoveAt(0);

            }
            
        }
        public int NombreFreres()
        {
            if (frere != null) return 1 + frere.NombreFreres();
            else return 1;
        }
        #endregion
        #region ToString
        public override string ToString()
        {
            string self = s.ToString();
            if (frere != null) self += "\n"+frere.ToString();
            if (fils != null) self += "\n" + fils.ToString();
            return self;
        }
        #endregion

        #region Verification

    }
}
