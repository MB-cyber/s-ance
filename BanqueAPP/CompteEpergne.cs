using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanqueAPP
{
    class CompteEpergne : Compte
    {
        private double TauxInteret;


        public CompteEpergne(Client titu, MAD somme, double Taux) : base(titu, somme)
        {
            if (Taux >100.00 || Taux<0)
            {
                throw new ArgumentOutOfRangeException("taux invalide le taux doit etre 0<taux <100");
            }
            else
            {
                this.TauxInteret = Taux;
            }


        }


        public override void consulter()
        {
            base.consulter();
            Console.WriteLine("interete" + this.TauxInteret);
        }
         
        public void CalcullInteret()
        {
            double interet = this.TauxInteret / 100;


            this.crediter(this.multipledesolde(interet));

        }
        


    }
}
