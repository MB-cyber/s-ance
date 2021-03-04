using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MAD
    {
        Double valeur ;
        public MAD(Double val)
        {
            this.valeur = val;
        }
        public  MAD ajouter(MAD val) 
        {
            MAD somme =new MAD(this.valeur+val.valeur);
            
            return somme;
        }

        public int xx(MAD val)
        {

            if (this.valeur >= val.valeur)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }

        public MAD supp(MAD val)
        {
            MAD somme = new MAD(this.valeur - val.valeur);

            return somme;
        }

        public String showVal()
        {

            String s = this.valeur.ToString();
            return s;
        }
    }
}
