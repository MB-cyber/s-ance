using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanqueAPP
{
    class CompteCourant : Compte
    {
        private static MAD decouvert=new MAD(2000);

        public CompteCourant(Client titu, MAD somme) : base(titu, somme)
        {

        }

        public override bool debiter(MAD somme)
        {
            // on peut declarer le solde protected au bien methode 
            if ( this.verifier(decouvert)==true )
            {
                return base.debiter(somme);
            }
            else
                
                return false;
        }


        public override void consulter()
        {
            base.consulter();
            Console.WriteLine("le decouvert");
            decouvert.afficher();
        }


    }
}
